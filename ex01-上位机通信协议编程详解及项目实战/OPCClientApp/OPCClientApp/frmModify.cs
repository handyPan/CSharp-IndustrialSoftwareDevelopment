using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPCClientApp
{
    public partial class frmModify : Form
    {
        public frmModify(string value)
        {
            InitializeComponent();
            this.txtInitial.Text = value;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string res = string.Empty;
            if (chkAsync.Checked)
            {
                res = this.txtModify.Text.Trim() + "|" + "1";
            }
            else
            {
                res = this.txtModify.Text.Trim() + "|" + "0";
            }
            this.Tag = res;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
