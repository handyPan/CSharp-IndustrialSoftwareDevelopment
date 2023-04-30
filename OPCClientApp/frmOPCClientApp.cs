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
        }

        // define OPC server, groups, group, items, browser
        OPCServer kepServer;
        OPCGroups kepGroups;
        OPCGroup kepGroup;
        OPCItems kepItems;
        OPCBrowser kepBrowser;

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
                this.lstItems.Items.Add(item.ToString());
            }
        }

        private void kepGroupAsyncReadComplete(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps, ref Array Errors)
        {
            throw new NotImplementedException();
        }
    }
}
