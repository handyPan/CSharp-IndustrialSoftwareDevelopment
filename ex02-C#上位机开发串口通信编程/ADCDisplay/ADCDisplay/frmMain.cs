using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCDisplay
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// create data.ini to store the software configuration
        /// </summary>
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(
            string section, 
            string key, 
            string val, 
            string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(
            string section,
            string key, 
            string def,
            StringBuilder retVal,
            int size,
            string filePath);
        string configurationFileName = System.AppDomain.CurrentDomain.BaseDirectory + "data.ini";
        StringBuilder temp = new StringBuilder(255);    //read the variables in data.ini
        string configuredSendPort, configuredReceivePort;

        frmDebug fDebug = new frmDebug();
        ProgressBar[] getProgressBarArr()
        {
            return new ProgressBar[]
            {
                progressBar1, progressBar2, progressBar3, progressBar4,
                progressBar5, progressBar6, progressBar7, progressBar8,
                progressBar9, progressBar10
            };
        }
        Label[] getAdcResultValueArr()
        {
            return new Label[]
            {
                lbl_adcResultValue1, lbl_adcResultValue2, lbl_adcResultValue3, lbl_adcResultValue4,
                lbl_adcResultValue5, lbl_adcResultValue6, lbl_adcResultValue7, lbl_adcResultValue8,
                lbl_adcResultValue9, lbl_adcResultValue10
            };
        }

        public frmMain()
        {
            InitializeComponent();
            serPort_receive.DataReceived += new SerialDataReceivedEventHandler(SerialPortDataReceived);
            this.Size = new Size(368, 136);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(frmMain_formClosing);
        }

        private void frmMain_formClosing(object sender, FormClosingEventArgs e)
        {
            WritePrivateProfileString("PortData", "SendPort", cmb_sendPort.Text, configurationFileName);
            WritePrivateProfileString("PortData", "ReceivePort", cmb_receivePort.Text, configurationFileName);
        }

        private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {   // read bytes from receive serial port
            /* version 1 - read 1 byte to display on 1 progressbar
            byte dataReceived = (byte)(serPort_receive.ReadByte());
            if (progressBar1.InvokeRequired)
            {
                Action<byte> actionDelegate = delegate (byte adcResult)
                {
                    progressBar1.Value = adcResult;
                };
                progressBar1.Invoke(actionDelegate, dataReceived);
            }
            if (lbl_adcResultValue1.InvokeRequired)
            {
                Action<byte> actionDelegate = delegate (byte adcResult)
                {
                    lbl_adcResultValue1.Text = Convert.ToInt32(adcResult).ToString();
                    int locationX = lbl_adcResultMin.Location.X +
                            (int)((lbl_adcResultMax.Location.X - lbl_adcResultMin.Location.X) *
                            Convert.ToInt32(lbl_adcResultValue1.Text) / Convert.ToInt32(lbl_adcResultMax.Text));
                    int locationY = lbl_adcResultValue1.Location.Y;
                    lbl_adcResultValue1.Location = new Point(locationX, locationY);
                };
                lbl_adcResultValue1.Invoke(actionDelegate, dataReceived);
            }
            fDebug.setAdcResultValueLabel(lbl_adcResultValue1.Text);
            */
            // version 2 - read all bytes to display on 10 progressbars
            ProgressBar[] myProgressBar = getProgressBarArr();
            Label[] myAdcResultValue = getAdcResultValueArr();
            byte[] dataReceived = new byte[serPort_receive.BytesToRead];
            serPort_receive.Read(dataReceived, 0, dataReceived.Length);
            foreach (byte myData in dataReceived)
            {
                for (int i = 1; i < 10; i++)
                {
                    // myProgressBar[10 - i].Value = myProgressBar[10 - i - 1].Value;
                    // myAdcResultValue[10 - i].Text = myAdcResultValue[10 - i - 1].Text;
                    if (myProgressBar[10 - i].InvokeRequired)
                    {
                        Action<int> actionDelegate = delegate (int adcResult)
                        {
                            myProgressBar[10 - i].Value = adcResult;
                        };
                        myProgressBar[10 - i].Invoke(actionDelegate, myProgressBar[10 - i - 1].Value);
                    }
                    if (myAdcResultValue[10 - i].InvokeRequired)
                    {
                        Action<string> actionDelegate = delegate (string adcResult)
                        {
                            myAdcResultValue[10 - i].Text = adcResult;
                            int locationX = lbl_adcResultMin.Location.X +
                                    (int)((lbl_adcResultMax.Location.X - lbl_adcResultMin.Location.X) *
                                    Convert.ToInt32(adcResult) / Convert.ToInt32(lbl_adcResultMax.Text));
                            int locationY = myAdcResultValue[10 - i].Location.Y;
                            myAdcResultValue[10 - i].Location = new Point(locationX, locationY);
                        };
                        Console.WriteLine($"myAdcResultValue[10 - i - 1].Text = {myAdcResultValue[10 - i - 1].Text}");
                        myAdcResultValue[10 - i].Invoke(actionDelegate, myAdcResultValue[10 - i - 1].Text);
                    }
                }
                // progressBar1.Value = (int)myData;
                if (progressBar1.InvokeRequired)
                {
                    Action<byte> actionDelegate = delegate (byte adcResult)
                    {
                        progressBar1.Value = adcResult;
                    };
                    progressBar1.Invoke(actionDelegate, myData);
                }
                // lbl_adcResultValue1
                if (lbl_adcResultValue1.InvokeRequired)
                {
                    Action<byte> actionDelegate = delegate (byte adcResult)
                    {
                        lbl_adcResultValue1.Text = Convert.ToInt32(adcResult).ToString();
                        int locationX = lbl_adcResultMin.Location.X +
                                (int)((lbl_adcResultMax.Location.X - lbl_adcResultMin.Location.X) *
                                Convert.ToInt32(lbl_adcResultValue1.Text) / Convert.ToInt32(lbl_adcResultMax.Text));
                        int locationY = lbl_adcResultValue1.Location.Y;
                        lbl_adcResultValue1.Location = new Point(locationX, locationY);
                    };
                    lbl_adcResultValue1.Invoke(actionDelegate, myData);
                }
            }
            fDebug.setAdcResultValueLabel(lbl_adcResultValue1.Text);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Label[] myAdcResultValue = getAdcResultValueArr();
            foreach (Label lbl in myAdcResultValue)
            {
                lbl.Text = "0";
            }
            searchAndAddSerialPortToComboBox(serPort_send, cmb_sendPort);
            searchAndAddSerialPortToComboBox(serPort_receive, cmb_receivePort);
            // read the data.ini configurations
            GetPrivateProfileString("PortData", "SendPort", "COM1", temp, 256, configurationFileName);
            cmb_sendPort.Text = temp.ToString();
            GetPrivateProfileString("PortData", "ReceivePort", "COM2", temp, 256, configurationFileName);
            cmb_receivePort.Text = temp.ToString();
            fDebug.Show();
        }

        private void searchAndAddSerialPortToComboBox(SerialPort myPort, ComboBox myBox)
        {
            string[] availablePortList = new string[20]; // set maximum to 20, if more, the efficiency will be low
            string buffer;
            int portNum = 0;
            myBox.Items.Clear();
            for (int i = 1; i < 20; i++)
            {
                try
                {
                    buffer = "COM" + i.ToString();
                    myPort.PortName = buffer;
                    myPort.Open();                      // if this fails, the lines below won't be executed
                    availablePortList[portNum] = buffer;
                    portNum++;
                    myBox.Items.Add(buffer);            // open successfully, add to the combo box
                    myPort.Close();
                }
                catch (Exception)
                {
                    // MessageBox.Show($"Fail to open COM {i.ToString()}", "Error");
                }
            }
        }

        private void btn_turnOnOffSerialPort_Click(object sender, EventArgs e)
        {
            if (cmb_sendPort.Text == "" | cmb_receivePort.Text == "")
            {
                MessageBox.Show("Please configure the serial ports.", "Error");
                return;
            }
            if (cmb_sendPort.Text == cmb_receivePort.Text)
            {
                MessageBox.Show("Send and receive ports can't be the same.", "Error");
                return;
            }
            if (btn_turnOnOffSerialPort.Text == "Turn ON")
            {   
                if (!serPort_send.IsOpen)
                {
                    serPort_send.PortName = cmb_sendPort.Text;
                    serPort_send.Open();
                    configuredSendPort = cmb_sendPort.Text;
                    serPort_receive.PortName = cmb_receivePort.Text;
                    serPort_receive.Open();
                    configuredReceivePort = cmb_receivePort.Text;
                    cmb_sendPort.Enabled = false;
                    cmb_receivePort.Enabled = false;
                    btn_turnOnOffSerialPort.Text = "Turn OFF";
                    this.Size = new Size(368, 476);
                    fDebug.setPorts(serPort_send, serPort_receive);
                    fDebug.enableTrackBar(true);
                }
            }
            else
            {   
                if (serPort_send.IsOpen)
                {
                    serPort_send.Close();
                    serPort_receive.Close();
                    cmb_sendPort.Enabled = true;
                    cmb_receivePort.Enabled = true;
                    btn_turnOnOffSerialPort.Text = "Turn ON";
                    this.Size = new Size(368, 136);
                    fDebug.enableTrackBar(false);
                }
            }
        }
    }
}
