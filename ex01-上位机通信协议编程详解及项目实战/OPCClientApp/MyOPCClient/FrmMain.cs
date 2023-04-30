using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyOPC;

namespace MyOPCClient
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Load += frmMain_Load;
        }

        OPC objOPC = new OPC();

        private void frmMain_Load(object sender, EventArgs e)
        {
            // add reference of "MyOPC"
            objOPC.opcList.Add(new MyOPCItem() { Tag = "MODBUS.Modbus.K1"});
            objOPC.opcList.Add(new MyOPCItem() { Tag = "MODBUS.Modbus.K2" });
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            objOPC.Connect("KEPware.KEPServerEx.V4", "DESKTOP-18047CQ");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            objOPC.readOPCItems();
            this.txtRead1.Text = objOPC.opcList[0].Value;
            this.txtRead2.Text = objOPC.opcList[1].Value;
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (this.txtWrite1.Text.Length>0)
            {
                objOPC.writeOPCItem(0, this.txtWrite1.Text.Trim());
            }
            if (this.txtWrite2.Text.Length>0)
            {
                objOPC.writeOPCItem(1, this.txtWrite2.Text.Trim());
            }
        }
    }
}
