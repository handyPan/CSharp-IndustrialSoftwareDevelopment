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

namespace SendDataWithValidation
{
    public partial class frmDebug : Form
    {
        private SerialPort sendPort, receivePort;

        public frmDebug()
        {
            InitializeComponent();
        }

        public void setPortsLabels(string receivePort, string sendPort)
        {
            lbl_receivePort.Text = receivePort;
            lbl_sendPort.Text = sendPort;
        }

        public void setPorts(SerialPort receivePort, SerialPort sendPort)
        {
            setPortsLabels(receivePort.PortName, sendPort.PortName);
            this.receivePort = receivePort;
            this.sendPort = sendPort;
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

        private void frmDebug_Load(object sender, EventArgs e)
        {
            // initialize the ports
            lbl_receivePort.Text = "";
            lbl_sendPort.Text = "";
            // draw device status lights
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 24, 24);
            lbl_device1Status.Text = "";
            lbl_device1Status.Region = new Region(path);
            lbl_device1Status.BackColor = Color.DarkGray;
            lbl_device2Status.Text = "";
            lbl_device2Status.Region = new Region(path);
            lbl_device2Status.BackColor = Color.DarkGray;
            lbl_device3Status.Text = "";
            lbl_device3Status.Region = new Region(path);
            lbl_device3Status.BackColor = Color.DarkGray;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string reply = cmb_replyCode.Text;
            if (reply != "")
            {
                reply = reply.Substring(0, 4);
                switch (reply)
                {
                    case "0x01":
                        setReceiveSendRecord("Sent: 0x01 - Device 1 ON");
                        break;
                    case "0x11":
                        setReceiveSendRecord("Sent: 0x11 - Device 1 OFF");
                        break;
                    case "0x02":
                        setReceiveSendRecord("Sent: 0x02 - Device 2 ON");
                        break;
                    case "0x12":
                        setReceiveSendRecord("Sent: 0x12 - Device 2 OFF");
                        break;
                    case "0x03":
                        setReceiveSendRecord("Sent: 0x03 - Device 3 ON");
                        break;
                    case "0x13":
                        setReceiveSendRecord("Sent: 0x13 - Device 3 OFF");
                        break;
                    case "0x04":
                        setReceiveSendRecord("Sent: 0x04 - All Devices ON");
                        break;
                    case "0x14":
                        setReceiveSendRecord("Sent: 0x14 - All Devices OFF");
                        break;
                    default:
                        break;
                }
                byte replyCode = Convert.ToByte(reply, 16);
                sendDataToSerialPort(sendPort, replyCode);
            }
            
        }

        public void setReceiveSendRecord(string msg)
        {
            string str = $"{msg}";
            if (txt_receiveSendRecords.InvokeRequired)
            {
                Action<string> actionDelegate = delegate (string txt) {
                    txt_receiveSendRecords.AppendText(txt);
                    txt_receiveSendRecords.AppendText(Environment.NewLine);
                };
                txt_receiveSendRecords.Invoke(actionDelegate, str);
            }
            else
            {
                txt_receiveSendRecords.AppendText(str);
                txt_receiveSendRecords.AppendText(Environment.NewLine);
            }
        }

        public void setDeviceStatusForMainForm(string code)
        {
            switch (code)
            {
                case "0x01":
                    lbl_device1Status.BackColor = Color.DarkGreen;
                    break;
                case "0x11":
                    lbl_device1Status.BackColor = Color.DarkGray;
                    break;
                case "0x02":
                    lbl_device2Status.BackColor = Color.DarkGreen;
                    break;
                case "0x12":
                    lbl_device2Status.BackColor = Color.DarkGray;
                    break;
                case "0x03":
                    lbl_device3Status.BackColor = Color.DarkGreen;
                    break;
                case "0x13":
                    lbl_device3Status.BackColor = Color.DarkGray;
                    break;
                case "0x04":
                    lbl_device1Status.BackColor = Color.DarkGreen;
                    lbl_device2Status.BackColor = Color.DarkGreen;
                    lbl_device3Status.BackColor = Color.DarkGreen;
                    break;
                case "0x14":
                    lbl_device1Status.BackColor = Color.DarkGray;
                    lbl_device2Status.BackColor = Color.DarkGray;
                    lbl_device3Status.BackColor = Color.DarkGray;
                    break;
                default:
                    break;
            }
        }
    }
}
