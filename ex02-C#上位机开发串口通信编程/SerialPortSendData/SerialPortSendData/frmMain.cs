using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortSendData
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string str;
            for (int i=0;i<256;i++)
            {
                str = i.ToString("x").ToUpper(); // convert to string in 0x system
                if (str.Length == 1)
                {
                    str = "0" + str; // align data, ex 0x0A, 0x 1B
                    cmb_Data.Items.Add("0x" + str);
                }
            }
            cmb_Data.Text = "0x00";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = cmb_Data.Text;
            string extractedData = data.Substring(2, 2);
            byte[] buffer = new byte[1];    // one byte is enough
            buffer[0] = Convert.ToByte(extractedData, 16);
            try
            {
                serialPort1.Open();
                serialPort1.Write(buffer, 0, 1);
                serialPort1.Close();
                MessageBox.Show(extractedData + " write to port: " + serialPort1.PortName);
            }
            catch (Exception err)
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
                // MessageBox.Show(err.ToString(), "");
                MessageBox.Show("Can't open port: " + serialPort1.PortName, "Error");
            }
        }
    }
}
