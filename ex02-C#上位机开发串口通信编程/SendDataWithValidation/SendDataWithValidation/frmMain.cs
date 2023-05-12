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
    public partial class frmMain : Form
    {
        byte deviceTag = 0;
        byte[] dataToSend = new byte[] { 0x01, 0x02, 0x03 };
        frmDebug fDebug = new frmDebug();

        public frmMain()
        {
            InitializeComponent();
            serPort_receive.DataReceived += new SerialDataReceivedEventHandler(SerialPortDataReceived);
        }

        // interrupt for the serial port data receive, should be manually created
        private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // compare with the original sent data
            // byte dataReceived = (byte)(~serPort_send.ReadByte());
            byte dataReceived = (byte)(serPort_receive.ReadByte());
            timer1.Stop();
            // set the device status by the reply code
            switch (dataReceived)
            {
                case 0x01:
                    lbl_device1Status.BackColor = Color.DarkGreen;
                    fDebug.setDeviceStatusForMainForm("0x01");
                    fDebug.setReceiveSendRecord("Received: 0x01 - Turn ON Device 1");
                    break;
                case 0x11:
                    lbl_device1Status.BackColor = Color.DarkGray;
                    fDebug.setDeviceStatusForMainForm("0x11");
                    fDebug.setReceiveSendRecord("Received: 0x11 - Turn OFF Device 1");
                    break;
                case 0x02:
                    lbl_device2Status.BackColor = Color.DarkGreen;
                    fDebug.setDeviceStatusForMainForm("0x02");
                    fDebug.setReceiveSendRecord("Received: 0x02 - Turn ON Device 2");
                    break;
                case 0x12:
                    lbl_device2Status.BackColor = Color.DarkGray;
                    fDebug.setDeviceStatusForMainForm("0x12");
                    fDebug.setReceiveSendRecord("Received: 0x12 - Turn OFF Device 2");
                    break;
                case 0x03:
                    lbl_device3Status.BackColor = Color.DarkGreen;
                    fDebug.setDeviceStatusForMainForm("0x03");
                    fDebug.setReceiveSendRecord("Received: 0x03 - Turn ON Device 3");
                    break;
                case 0x13:
                    lbl_device3Status.BackColor = Color.DarkGray;
                    fDebug.setDeviceStatusForMainForm("0x13");
                    fDebug.setReceiveSendRecord("Received: 0x13 - Turn OFF Device 3");
                    break;
                case 0x04:
                    lbl_device1Status.BackColor = Color.DarkGreen;
                    lbl_device2Status.BackColor = Color.DarkGreen;
                    lbl_device3Status.BackColor = Color.DarkGreen;
                    fDebug.setDeviceStatusForMainForm("0x04");
                    fDebug.setReceiveSendRecord("Received: 0x04 - Turn ON All Devices");
                    break;
                case 0x14:
                    lbl_device1Status.BackColor = Color.DarkGray;
                    lbl_device2Status.BackColor = Color.DarkGray;
                    lbl_device3Status.BackColor = Color.DarkGray;
                    fDebug.setDeviceStatusForMainForm("0x14");
                    fDebug.setReceiveSendRecord("Received: 0x14 - Turn OFF All Devices");
                    break;
                default:
                    break;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // initialize serial port list
            searchAndAddSerialPortToComboBox(serPort_send, cmb_sendPort);
            searchAndAddSerialPortToComboBox(serPort_receive, cmb_receivePort);
            // initialize buttons status
            btn_device1SendValidate.Enabled = false;
            btn_device2SendValidate.Enabled = false;
            btn_device3SendValidate.Enabled = false;
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
            // show debug form
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

        private void btn_deviceSendValidate_Click(object sender, EventArgs e)
        {
            Button myButton = (Button)sender;
            deviceTag = Convert.ToByte(myButton.Tag);
            sendDataToSerialPort(serPort_send, dataToSend[deviceTag - 1]);
        }

        private void sendDataToSerialPort(SerialPort myPort, byte myData)
        {
            byte[] dataToWrite = new byte[] { myData };
            if (serPort_send.IsOpen)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            string str = $"Device { deviceTag.ToString() } data validation overtime, please check.";
            timer1.Stop();
            MessageBox.Show(str, "Error");
        }

        private void btn_turnOnOffSerialPort_Click_1(object sender, EventArgs e)
        {   
            // determine whether the configuration is correct
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
            // try to turn ON or OFF ports
            if (btn_turnOnOffSerialPort.Text == "Turn ON")
            {
                // try to turn ON ports
                try
                {
                    serPort_send.PortName = cmb_sendPort.Text;
                    serPort_send.Open();
                    serPort_receive.PortName = cmb_receivePort.Text;
                    serPort_receive.Open();
                    btn_turnOnOffSerialPort.Text = "Turn OFF";
                    btn_device1SendValidate.Enabled = true;
                    btn_device2SendValidate.Enabled = true;
                    btn_device3SendValidate.Enabled = true;
                    fDebug.setPorts(serPort_receive, serPort_send);
                }
                catch (Exception err)
                {
                    serPort_send.Close();
                    serPort_receive.Close();
                    fDebug.setPortsLabels("", "");
                    MessageBox.Show(err.Message, "Error");
                    MessageBox.Show($"Fail to turn ON {serPort_send.PortName} and {serPort_receive.PortName}", "Error");
                }
            }
            else
            {
                // try to turn OFF ports
                try
                {
                    serPort_send.Close();
                    serPort_receive.Close();
                    fDebug.setPortsLabels("", "");
                    btn_turnOnOffSerialPort.Text = "Turn ON";
                    btn_device1SendValidate.Enabled = false;
                    btn_device2SendValidate.Enabled = false;
                    btn_device3SendValidate.Enabled = false;
                }
                catch
                {
                    MessageBox.Show($"Fail to turn OFF {serPort_send.PortName} and {serPort_receive.PortName}", "Error");
                }
            }
        }

        
    }
}
