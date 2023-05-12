using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortCommunicate
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            // disable compiler checking conflicts of threads, not recommended
            // Control.CheckForIllegalCrossThreadCalls = false;


        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 20; i++)
            {
                cmb_sendPort.Items.Add("COM" + i.ToString());
                cmb_receivePort.Items.Add("COM" + i.ToString());
            }
            cmb_sendPort.Text = "COM5";
            cmb_receivePort.Text = "COM6";
            cmb_baudRate.Text = "4800";

            btn_closePort.Enabled = false;

            // event - serial port receives data, must be manually defined
            serPort_receive.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
        }

        // event - serial port receives data
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {   
            // receive mode is "char"
            if (!radio_receiveValue.Checked)
            {
                string str = serPort_receive.ReadExisting();
                // txt_receive.AppendText(str);
                if (txt_receive.InvokeRequired)
                {
                    Action<string> actionDelegate = delegate (string txt) { txt_receive.Text += txt; };
                    txt_receive.Invoke(actionDelegate, str);
                }
                else
                {
                    txt_receive.Text += str;
                }
            }
            else // receive mode is "value"
            {
                /*
                byte data;
                // force to convert (int) to (byte), then to uppercase 0x string
                data = (byte)serPort_receive.ReadByte();
                string str = Convert.ToString(data, 16).ToUpper();
                str = "0x" + (str.Length == 1 ? "0" + str : str) + " ";
                // txt_receive.AppendText("0x" + (str.Length == 1 ? "0" + str : str) + " ");
                if (txt_receive.InvokeRequired)
                {
                    Action<string> actionDelegate = delegate (string txt) { txt_receive.Text += txt; };
                    txt_receive.Invoke(actionDelegate, str);
                }
                else
                {
                    txt_receive.Text += str;
                }
                */
                byte[] data = new byte[serPort_receive.BytesToRead];
                serPort_receive.Read(data, 0, data.Length);
                foreach (byte myByte in data)
                {
                    string str = Convert.ToString(myByte, 16).ToUpper();
                    str = "0x" + (str.Length == 1 ? "0" + str : str) + " ";
                    if (txt_receive.InvokeRequired)
                    {
                        Action<string> actionDelegate = delegate (string txt) { txt_receive.Text += txt; };
                        txt_receive.Invoke(actionDelegate, str);
                    }
                    else
                    {
                        txt_receive.Text += str;
                    }
                }
            }
        }

        private void btn_closePort_Click(object sender, EventArgs e)
        {
            try
            {
                serPort_send.Close();
                serPort_receive.Close();
                btn_openPort.Enabled = true;
                btn_closePort.Enabled = false;

            }
            catch (Exception err)   // not needed as close port won't have error
            {

                throw;
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            byte[] sendData = new byte[1];
            if (serPort_send.IsOpen)
            {
                if (txt_send.Text != "")
                {   
                    // send mode is "char"
                    if (!radio_sendValue.Checked)
                    {
                        try
                        {
                            serPort_send.WriteLine(txt_send.Text);
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show($"Serial port: { serPort_send.PortName } write error", "Error");
                            serPort_send.Close();
                            btn_openPort.Enabled = true;
                            btn_closePort.Enabled = false;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < (txt_send.Text.Length - txt_send.Text.Length % 2) / 2; i++)
                        {
                            sendData[0] = Convert.ToByte(txt_send.Text.Substring(i * 2, 2), 16);
                            // send every 2 bytes continuously
                            // if input chars are 0AC0D, only send 0A, C0
                            serPort_send.Write(sendData, 0, 1); 
                        }
                        // the last sended is only 4 bits, convert it to a byte
                        if (txt_send.Text.Length % 2 != 0)
                        {
                            sendData[0] = Convert.ToByte(txt_send.Text.Substring(txt_send.Text.Length - 1, 1), 16);
                            serPort_send.Write(sendData, 0, 1);
                        }
                    }
                }
            }
        }

        private void btn_openPort_Click(object sender, EventArgs e)
        {
            try
            {
                serPort_send.PortName = cmb_sendPort.Text;
                serPort_receive.PortName = cmb_receivePort.Text;
                serPort_send.BaudRate = Convert.ToInt32(cmb_baudRate.Text, 10);
                serPort_receive.BaudRate = Convert.ToInt32(cmb_baudRate.Text, 10);
                // support Chinese characters
                serPort_send.Encoding = Encoding.GetEncoding("GB2312");
                serPort_receive.Encoding = Encoding.GetEncoding("GB2312");
                serPort_send.Open();
                serPort_receive.Open();
                btn_openPort.Enabled = false;
                btn_closePort.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Port error, please check the serial ports.", "Error");
            }
        }

        private void txt_receive_TextChanged(object sender, EventArgs e)
        {   
            // scroll bar move to the bottom
            txt_receive.ScrollToCaret();
        }
    }
}
