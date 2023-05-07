using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDownApp
{
    public partial class frmMain : Form
    {
        int cnt;
        int remainingTime;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            for (int i=1;i<=30;i++)
            {
                cmb_specifiedTime.Items.Add(i.ToString() + " secs");
            }
            cmb_specifiedTime.Text = "5 secs";
            btn_Start.Enabled = true;
            lbl_remainingTime.Text = "";
        }

        private void tmr_interval_Tick(object sender, EventArgs e)
        {
            cnt++;
            lbl_remainingTime.Text = (remainingTime - cnt).ToString() + " secs";
            progBar_completedTime.Value = cnt;
            if (cnt == remainingTime)
            {
                tmr_interval.Stop();
                System.Media.SystemSounds.Asterisk.Play();
                btn_Start.Enabled = false;
                btn_Start.Text = "Start";
                cmb_specifiedTime.Enabled = true;
                MessageBox.Show("Time is up!", "Alert");
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            string str = cmb_specifiedTime.Text;
            remainingTime = Convert.ToInt16(str.Substring(0, 2));
            progBar_completedTime.Value = 0;
            if (btn_Start.Text == "Start")
            {
                
                progBar_completedTime.Maximum = remainingTime;
                btn_Start.Text = "Cancel";
                cmb_specifiedTime.Enabled = false;
                tmr_interval.Start();
            }
            else
            {
                cnt = 0;
                progBar_completedTime.Maximum = 0;
                btn_Start.Text = "Start";
                cmb_specifiedTime.Enabled = true;
                lbl_remainingTime.Text = "0 secs";
                tmr_interval.Stop();
            }
        }

        private void cmb_specifiedTime_DropDownClosed(object sender, EventArgs e)
        {
            cnt = 0;
            if (cmb_specifiedTime.Text != "")
            {
                btn_Start.Enabled = true;
            }
        }
    }
}
