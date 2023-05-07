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
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 20; i++)
            {
                cmb_Port.Items.Add("COM" + i.ToString());
            }
            cmb_Port.Text = "COM5";
            cmb_baudRate.Text = "4800";

            btn_closePort.Enabled = false;

            // event - serial port receives data, must be manually defined
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
        }

        // event - serial port receives data
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {   
            // receive mode is "char"
            if (!radio_receiveValue.Checked)
            {
                string str = serialPort1.ReadExisting();
                txt_receive.AppendText(str);
            }
            else // receive mode is "value"
            {
                byte data;
                // force to convert (int) to (byte), then to uppercase 0x string
                data = (byte)serialPort1.ReadByte();
                string str = Convert.ToString(data, 16).ToUpper();
                txt_receive.AppendText("0x" + (str.Length == 1 ? "0" + str : str) + " ");
            }
            throw new NotImplementedException();
        }

        private void btn_closePort_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
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
            if (serialPort1.IsOpen)
            {
                if (txt_send.Text != "")
                {   
                    // send mode is "char"
                    if (!radio_sendValue.Checked)
                    {
                        try
                        {
                            serialPort1.WriteLine(txt_send.Text);
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show($"Serial port: { serialPort1.PortName } write error", "Error");
                            serialPort1.Close();
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
                            serialPort1.Write(sendData, 0, 1); 
                        }
                        // the last sended is only 4 bits, convert it to a byte
                        if (txt_send.Text.Length % 2 != 0)
                        {
                            sendData[0] = Convert.ToByte(txt_send.Text.Substring(txt_send.Text.Length - 1, 1), 16);
                            serialPort1.Write(sendData, 0, 1);
                        }
                    }
                }
            }
        }

        private void btn_openPort_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cmb_Port.Text;
                serialPort1.BaudRate = Convert.ToInt32(cmb_baudRate.Text, 10);
                serialPort1.Open();
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
