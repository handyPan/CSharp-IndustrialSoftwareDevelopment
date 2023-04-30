using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OPCAutomation;

namespace OPCClientApp
{
    public partial class frmOPCClientApp : Form
    {
        public frmOPCClientApp()
        {
            InitializeComponent();
            // automatically get the server nodes at loading
            this.Load += frmOPCClientApp_Load;
        }

        private void frmOPCClientApp_Load(object sender, EventArgs e)
        {
            this.btnRefreshList_Click(null, null);
            this.timer1.Interval = 1000;
            this.timer1.Enabled = true;
            this.dgvData.AutoGenerateColumns = false;
        }

        // define OPC server, groups, group, items, browser
        OPCServer kepServer;
        OPCGroups kepGroups;
        OPCGroup kepGroup;
        OPCItems kepItems;
        OPCBrowser kepBrowser;
        // define OPC variables
        List<OPCItem> opcList = new List<OPCItem>();
        List<int> serverHandles = new List<int>();
        List<int> clientHandles = new List<int>();
        List<string> tempIDList = new List<string>();
        // define returned OPC tag errors
        Array iErrors;
        // define ids of OPC tags to add
        Array strTempIDs;
        Array strClientHandles;
        Array strServerHandles;
        Array readServerHandles;
        Array writeServerHandles;
        Array writeArrayHandles;
        Array readErrors;
        Array writeErrors;
        int readTransID;
        int writeTransID;
        int readCancelID;
        int writeCancelID;

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            // clear Server Node combobox
            this.cmbServerNode.Items.Clear();
            IPHostEntry IPHost = Dns.GetHostEntry(Environment.MachineName);
            if (IPHost.AddressList.Length>0)
            {
                int count = IPHost.AddressList.Length;
                for (int i=0;i<count;i++)
                {   
                    // get host name and add to Server Node combobox
                    string HostName = Dns.GetHostEntry(IPHost.AddressList[i].ToString()).HostName;
                    if (!this.cmbServerNode.Items.Contains(HostName))
                    {
                        this.cmbServerNode.Items.Add(HostName);
                    }
                }
            } else
            {
                return;
            }
        }

        private void cmbServerNode_SelectedIndexChanged(object sender, EventArgs e)
        {
            // clear Server Name combobox
            this.cmbServerName.Items.Clear();
            IPHostEntry ipHostEntry = Dns.GetHostEntry(this.cmbServerNode.Text.Trim());
            kepServer = new OPCServer();
            object serverList = kepServer.GetOPCServers(ipHostEntry.HostName.ToString());
            foreach (string item in (Array)serverList)
            {
                this.cmbServerName.Items.Add(item);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {   
            // connect the selected OPC server
            try
            {
                kepServer.Connect(this.cmbServerName.Text.Trim(), this.cmbServerNode.Text.Trim());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Connection Failed");
            }

            // assign values to kepGroups
            kepGroups = kepServer.OPCGroups;
            kepGroups.DefaultGroupDeadband = 0;
            kepGroups.DefaultGroupIsActive = true;
            kepGroup = kepGroups.Add("Group1");
            kepGroup.IsActive = true;
            kepGroup.IsSubscribed = true;
            kepGroup.UpdateRate = 250;
            kepGroup.AsyncReadComplete += kepGroupAsyncReadComplete;

            kepBrowser = kepServer.CreateBrowser();
            kepBrowser.ShowBranches();
            kepBrowser.ShowLeafs(true);

            foreach (object item in kepBrowser)
            {
                if (!this.cmbServerName.Items.Contains(item))
                {
                    this.lstItems.Items.Add(item.ToString());
                }
            }
        }

        private void kepGroupAsyncReadComplete(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps, ref Array Errors)
        {
            for (int i =1;i <= NumItems; i++)
            {
                object value = ItemValues.GetValue(i);
                if (value != null)
                {
                    this.opcList[i-1].Value = value.ToString();
                    this.opcList[i-1].Time = (DateTime)TimeStamps.GetValue(i);
                }
            }
            this.dgvData.DataSource = null;
            this.dgvData.DataSource = this.opcList;
        }

        private void lstItems_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstItems.SelectedItem!=null)
            {
                opcList.Add(new OPCItem() {
                    Tag = this.lstItems.SelectedItem.ToString()
                });
            }

            tempIDList.Clear();
            clientHandles.Clear();
            tempIDList.Add("0");
            clientHandles.Add(0);
            int count = this.opcList.Count;
            for (int i=0; i<count; i++)
            {
                tempIDList.Add(this.opcList[i].Tag);
                clientHandles.Add(i+1);
            }
            strTempIDs = (Array)tempIDList.ToArray();
            strClientHandles = (Array)clientHandles.ToArray();
            kepItems = kepGroup.OPCItems;
            // add tags for kep items
            kepItems.AddItems(this.opcList.Count, ref strTempIDs, ref strClientHandles, out strServerHandles, out iErrors);
            serverHandles.Clear();
            serverHandles.Add(0);
            for (int i = 0; i < count; i++)
            {
                serverHandles.Add(Convert.ToInt32(strServerHandles.GetValue(i + 1)));
            }
            readServerHandles = (Array)serverHandles.ToArray();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.opcList.Count>0)
            {
                kepGroup.AsyncRead(this.opcList.Count, ref readServerHandles, out readErrors, readTransID, out readCancelID);
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvData.SelectedRows!=null)
            {
                int idx = this.dgvData.CurrentRow.Index;
                OPCItem objItem = this.opcList[idx];
                frmModify objFrm = new frmModify(objItem.Value);
                DialogResult res = objFrm.ShowDialog();
                int[] serverHandle = new int[] { 0, Convert.ToInt32(strServerHandles.GetValue(idx + 1)) };
                object[] values = new object[2];
                string[] modifyResult;
                writeServerHandles = (Array)serverHandle;
                if (res == DialogResult.OK)
                {
                    modifyResult = objFrm.Tag.ToString().Split('|');
                    values[1] = modifyResult[0];
                    writeArrayHandles = (Array)values;
                    if (modifyResult[1]=="1")
                    {
                        kepGroup.AsyncWrite(1, writeServerHandles, writeArrayHandles, out writeErrors, writeTransID, out writeCancelID);
                    }
                    else
                    {
                        kepGroup.SyncWrite(1, writeServerHandles, writeArrayHandles, out writeErrors);
                    }
                }
            }
        }
    }
}
