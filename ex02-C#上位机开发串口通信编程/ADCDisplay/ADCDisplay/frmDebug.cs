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
    public partial class frmDebug : Form
    {
        private SerialPort sendPort, receivePort;

        public frmDebug()
        {
            InitializeComponent();
        }

        private void frmDebug_Load(object sender, EventArgs e)
        {
            // configure the trackbar
            tbar_adcResult.Minimum = 0;
            tbar_adcResult.Maximum = 255;
            tbar_adcResult.Value = 5;
            tbar_adcResult.SmallChange = 5;
            tbar_adcResult.LargeChange = 20;
            tbar_adcResult.TickFrequency = 5;
            lbl_adcResultValue.Text = $"{tbar_adcResult.Value}/{tbar_adcResult.Maximum}";
        }

        public void setPorts(SerialPort sendPort, SerialPort receivePort)
        {
            this.sendPort = sendPort;
            this.receivePort = receivePort;
        }

        public void enableTrackBar(bool state)
        {
            tbar_adcResult.Enabled = state;
        }

        public void setAdcResultValueLabel(string res)
        {
            string adcResult = $"{res}/{tbar_adcResult.Maximum}";
            if (lbl_adcResultValue.InvokeRequired)
            {
                Action<string> actionDelegate = delegate (string str)
                {
                    lbl_adcResultValue.Text = str;
                };
                lbl_adcResultValue.Invoke(actionDelegate, adcResult);
            }
        }

        private void tbar_adcResult_Scroll(object sender, EventArgs e)
        {
            byte adcResult = Convert.ToByte(tbar_adcResult.Value);
            sendDataToSerialPort(sendPort, adcResult);
        }

        private void sendDataToSerialPort(SerialPort myPort, byte myData)
        {
            byte[] dataToWrite = new byte[] { myData };
            if (myPort.IsOpen)
            {
                try
                {
                    myPort.Write(dataToWrite, 0, 1);
                }
                catch
                {
                    MessageBox.Show($"Fail to write to { myPort.PortName }", "Error");
                }
            }
            else
            {
                MessageBox.Show("Fail to send, check the serial port configuration", "Error");
            }
        }
    }
}
