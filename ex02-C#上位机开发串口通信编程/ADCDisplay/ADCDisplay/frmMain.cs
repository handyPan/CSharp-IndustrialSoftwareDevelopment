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

namespace ADCDisplay
{
    public partial class frmMain : Form
    {
        frmDebug fDebug = new frmDebug();

        public frmMain()
        {
            InitializeComponent();
            serPort_receive.DataReceived += new SerialDataReceivedEventHandler(SerialPortDataReceived);
            this.Size = new Size(368, 136);
        }

        private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte dataReceived = (byte)(serPort_receive.ReadByte());
            if (progressBar1.InvokeRequired)
            {
                Action<byte> actionDelegate = delegate (byte adcResult)
                {
                    progressBar1.Value = adcResult;
                };
                progressBar1.Invoke(actionDelegate, dataReceived);
            }
            if (lbl_adcResultValue.InvokeRequired)
            {
                Action<byte> actionDelegate = delegate (byte adcResult)
                {
                    lbl_adcResultValue.Text = Convert.ToInt32(adcResult).ToString();
                    int locationX = lbl_adcResultMin.Location.X +
                            (int)((lbl_adcResultMax.Location.X - lbl_adcResultMin.Location.X) *
                            Convert.ToInt32(lbl_adcResultValue.Text) / Convert.ToInt32(lbl_adcResultMax.Text));
                    int locationY = lbl_adcResultValue.Location.Y;
                    lbl_adcResultValue.Location = new Point(locationX, locationY);
                };
                lbl_adcResultValue.Invoke(actionDelegate, dataReceived);
            }
            fDebug.setAdcResultValueLabel(lbl_adcResultValue.Text);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lbl_adcResultValue.Text = "";
            searchAndAddSerialPortToComboBox(serPort_send, cmb_sendPort);
            searchAndAddSerialPortToComboBox(serPort_receive, cmb_receivePort);
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
                    serPort_receive.PortName = cmb_receivePort.Text;
                    serPort_receive.Open();
                    cmb_sendPort.Enabled = false;
                    cmb_receivePort.Enabled = false;
                    btn_turnOnOffSerialPort.Text = "Turn OFF";
                    this.Size = new Size(368, 217);
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
