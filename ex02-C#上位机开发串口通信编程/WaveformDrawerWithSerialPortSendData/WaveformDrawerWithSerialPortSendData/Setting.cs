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

namespace WaveformDrawerWithSerialPortSendData
{
    // delegates for Drawer.cs to use
    public delegate void ShowWindow();
    public delegate void HideWindow();
    public delegate void RefreshWindow();
    public delegate void OpenPort();
    public delegate void ClosePort();
    public delegate Point GetWindowPosition();
    public delegate int GetWindowWidth();

    public partial class Setting : Form
    {
        Drawer myDrawer;

        public Setting()
        {
            InitializeComponent();
            serPortReceive.Encoding = Encoding.GetEncoding("GB2312");                                  //串口接收编码
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 20; i++)
            {
                cmbSendPort.Items.Add("COM" + i.ToString());
                cmbReceivePort.Items.Add("COM" + i.ToString());
            }
            cmbSendPort.Text = "COM5";
            cmbReceivePort.Text = "COM6";
            cmbBaudRate.Text = "4800";

            btnClosePort.Enabled = false;
            btnSendData.Enabled = false;

            // event - serial port receives data, can be manually defined by below line
            // serPortReceive.DataReceived += new SerialDataReceivedEventHandler(portDataReceived);
            // above is shown in Setting.Designer.cs if to configure event in the "Properties" of serial port
        }

        // event - serial port receives data
        // private void portDataReceived(object sender, SerialDataReceivedEventArgs e)
        private void serPortReceive_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // receive mode is "char"
            if (!radBtnRecValue.Checked)
            {
                string str = serPortReceive.ReadExisting();
                if (txtDataReceived.InvokeRequired)
                {
                    Action<string> actionDelegate = delegate (string txt) {
                        txtDataReceived.Text += txt;
                    };
                    txtDataReceived.Invoke(actionDelegate, str);
                }
                else
                {
                    txtDataReceived.Text += str;
                }
            }
            else // receive mode is "value"
            {
                try
                {
                    byte[] data = new byte[serPortReceive.BytesToRead];
                    serPortReceive.Read(data, 0, data.Length);
                    if (myDrawer != null)
                    {
                        myDrawer.addData(data);
                    }
                    foreach (byte myByte in data)
                    {
                        string str = Convert.ToString(myByte, 16).ToUpper();
                        str = "0x" + (str.Length == 1 ? "0" + str : str) + " ";
                        if (txtDataReceived.InvokeRequired)
                        {
                            Action<string> actionDelegate = delegate (string txt) {
                                txtDataReceived.Text += txt;
                            };
                            txtDataReceived.Invoke(actionDelegate, str);
                        }
                        else
                        {
                            txtDataReceived.Text += str;
                        }
                    }
                }
                catch (System.Exception)
                {

                    throw;
                }
            }
        }

        // to be used by delegates 
        public void ShowMe()
        {
            this.Show();
        }

        public void HideMe()
        {
            this.Hide();
        }

        public void RefreshMe()
        {
            if (!serPortReceive.IsOpen)
            {
                btnOpenPort.Enabled = true;
                btnClosePort.Enabled = false;
                btnSendData.Enabled = false;
            }
            else
            {
                btnOpenPort.Enabled = false;
                btnClosePort.Enabled = true;
                btnSendData.Enabled = true;
            }
            this.Invalidate();
        }

        public void OpenPort()
        {
            try
            {
                if (!serPortSend.IsOpen) serPortSend.Open();
                if (!serPortReceive.IsOpen) serPortReceive.Open();
                MessageBox.Show("Receive serial port opened", "Message");
            }
            catch (System.Exception)
            {

                // throw;
                MessageBox.Show("Fail to open serial port for receiving data", "Error");
            }
        }

        public void ClosePort()
        {
            try
            {
                if (serPortSend.IsOpen) serPortSend.Close();
                if (serPortReceive.IsOpen) serPortReceive.Close();
                MessageBox.Show("Receive serial port closed", "Message");
            }
            catch (System.Exception)
            {

                // throw;
                MessageBox.Show("Fail to close serial port for receiving data", "Error");
            }
        }

        private Point GetMyPosition()
        {
            return this.Location;
        }

        private int GetMyWidth()
        {
            return this.Width;
        }

        private void CreateNewDrawer()
        {
            myDrawer = new Drawer();
            myDrawer.ShowSettingWindow = new ShowWindow(ShowMe);
            myDrawer.HideSettingWindow = new HideWindow(HideMe);
            myDrawer.RefreshSettingWindow = new RefreshWindow(RefreshMe);
            myDrawer.GetSettingWindowPosition = new GetWindowPosition(GetMyPosition);
            myDrawer.CloseSerialPort = new ClosePort(ClosePort);
            myDrawer.OpenSerialPort = new OpenPort(OpenPort);
            myDrawer.GetSettingWindowWidth = new GetWindowWidth(GetMyWidth);
            myDrawer.Show();//显示窗口
        }

        private void CreateDrawer()
        {
            this.Left = 0;
            CreateNewDrawer();
            Rectangle Rect = Screen.GetWorkingArea(this);
            // set drawer window width and position
            myDrawer.setDrawerForm(Rect.Width - this.Width, new Point(this.Width, this.Top));
        }
        
        private void btnDrawWaveform_Click(object sender, EventArgs e)
        {
            if (myDrawer == null)
            {
                CreateDrawer();
            }
            else
            {   
                // to avoid multiple creation of drawer 
                if (myDrawer.IsDisposed)
                {
                    CreateDrawer();
                }
            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (txtDataSent.Text == "")
            {
                MessageBox.Show("Data to send can't be empty!");
                return;
            }

            byte[] sendData = new byte[1];
            if (serPortSend.IsOpen)
            {
                if (txtDataSent.Text != "")
                {
                    // send mode is "char"
                    if (!radBtnSendValue.Checked)
                    {
                        try
                        {
                            serPortSend.WriteLine(txtDataSent.Text);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show($"Serial port: { serPortSend.PortName } write error", "Error");
                            serPortSend.Close();
                            btnOpenPort.Enabled = true;
                            btnClosePort.Enabled = false;
                            btnSendData.Enabled = false;
                        }
                    }
                    else
                    {
                        try
                        {
                            for (int i = 0; i < (txtDataSent.Text.Length - txtDataSent.Text.Length % 2) / 2; i++)
                            {
                                sendData[0] = Convert.ToByte(txtDataSent.Text.Substring(i * 2, 2), 16);
                                // send every 2 bytes continuously
                                // if input chars are 0AC0D, only send 0A, C0
                                serPortSend.Write(sendData, 0, 1);
                            }
                            // the last sended is only 4 bits, convert it to a byte
                            if (txtDataSent.Text.Length % 2 != 0)
                            {
                                sendData[0] = Convert.ToByte(txtDataSent.Text.Substring(txtDataSent.Text.Length - 1, 1), 16);
                                serPortSend.Write(sendData, 0, 1);
                            }
                        }
                        // if the user input has ilegal chars, it will be captured 
                        catch (Exception)
                        {
                            MessageBox.Show("Data conversion error, please input number.", "Error");
                        }
                    }
                }
            }
        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                serPortSend.PortName = cmbSendPort.Text;
                serPortReceive.PortName = cmbReceivePort.Text;
                serPortSend.BaudRate = Convert.ToInt32(cmbBaudRate.Text, 10);
                serPortReceive.BaudRate = Convert.ToInt32(cmbBaudRate.Text, 10);
                // support Chinese characters
                serPortSend.Encoding = Encoding.GetEncoding("GB2312");
                serPortReceive.Encoding = Encoding.GetEncoding("GB2312");
                if (!serPortSend.IsOpen) serPortSend.Open();
                if (!serPortReceive.IsOpen) serPortReceive.Open();
                btnOpenPort.Enabled = false;
                btnClosePort.Enabled = true;
                btnSendData.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Port error, please check the serial ports.", "Error");
            }
        }

        private void btnClosePort_Click(object sender, EventArgs e)
        {
            try
            {
                if (serPortSend.IsOpen) serPortSend.Close();
                if (serPortReceive.IsOpen) serPortReceive.Close();
                btnOpenPort.Enabled = true;
                btnClosePort.Enabled = false;
                btnSendData.Enabled = false;
            }
            catch (Exception)   // not needed as close port won't have error
            {
                throw;
            }
        }

        private void txtDataReceived_TextChanged(object sender, EventArgs e)
        {
            // scroll bar move to the bottom
            txtDataReceived.ScrollToCaret();
        }
    }
}
