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

namespace SerialPortControl
{
    public partial class frmMain : Form
    {
        // device 1
        const byte deviceOpen1 = 0x01;
        const byte deviceClose1 = 0x81;
        // device 2
        const byte deviceOpen2 = 0x02;
        const byte deviceClose2 = 0x82;
        // device 3
        const byte deviceOpen3 = 0x03;
        const byte deviceClose3 = 0x83;
        // Serial Port write buffer
        byte[] serialPortDataBuffer = new byte[1];

        bool btnOpenSerialPortState;

        // configured timer1 value
        int timer1ConfiguredSec;
        // timer ticked seconds
        int timer1TickedSec;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btn_openSerialPort_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                    // close devices if turned ON
                    if (lbl_device1Status.BackColor == Color.DarkGreen)
                    {
                        timer1.Stop();
                        btn_openDevice1.Enabled = true;
                        btn_closeDevice1.Enabled = false;
                        lbl_device1Status.BackColor = Color.DarkGray;
                        lbl_device1CloseAfter.Text = "";
                        timer1TickedSec = 0;
                        writeByteToSerialPort(deviceClose1);
                    }
                    if (lbl_device2Status.BackColor == Color.DarkGreen)
                    {
                        btn_openDevice2.Enabled = true;
                        btn_closeDevice2.Enabled = false;
                        writeByteToSerialPort(deviceClose2);
                        lbl_device2Status.BackColor = Color.DarkGray;
                    }
                    if (lbl_device3Status.BackColor == Color.DarkGreen)
                    {
                        btn_openDevice3.Enabled = true;
                        btn_closeDevice3.Enabled = false;
                        writeByteToSerialPort(deviceClose3);
                        lbl_device3Status.BackColor = Color.DarkGray;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                // btn_openSerialPort.Text = "Open Serial Port";
                btn_openSerialPort.BackgroundImage = Properties.Resources.btn_dark;
                btnOpenSerialPortState = false;
            }
            else
            {
                try
                {
                    serialPort1.PortName = cmb_serialPort.Text;
                    serialPort1.Open();
                    // btn_openSerialPort.Text = "Close Serial Port";
                    btn_openSerialPort.BackgroundImage = Properties.Resources.btn_green;
                    btnOpenSerialPortState = true;
                }
                catch (Exception)
                {

                    MessageBox.Show("Fail to open serial port", "Error");
                }
            }
        }

        private void btn_openSerialPort_MouseLeave(object sender, EventArgs e)
        {
            if (btnOpenSerialPortState)
            {
                btn_openSerialPort.BackgroundImage = Properties.Resources.btn_green;
            }
            else
            {
                btn_openSerialPort.BackgroundImage = Properties.Resources.btn_dark;
            }
        }

        private void btn_openSerialPort_MouseHover(object sender, EventArgs e)
        {
            btn_openSerialPort.BackgroundImage = Properties.Resources.btn_lightgreen;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {   
            // initialize serial port list
            searchAndAddSerialPortToComboBox(serialPort1, cmb_serialPort);
            // draw device status lights
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 22, 22);
            lbl_device1Status.Text = "";
            lbl_device1Status.Region = new Region(path);
            lbl_device1Status.BackColor = Color.DarkGray;
            lbl_device1CloseAfter.Text = "";
            lbl_device2Status.Text = "";
            lbl_device2Status.Region = new Region(path);
            lbl_device2Status.BackColor = Color.DarkGray;
            lbl_device3Status.Text = "";
            lbl_device3Status.Region = new Region(path);
            lbl_device3Status.BackColor = Color.DarkGray;
        }

        private void searchAndAddSerialPortToComboBox(SerialPort myPort, ComboBox myBox)
        {
            string[] availablePortList = new string[20]; // set maximum to 20, if more, the efficiency will be low
            string buffer;
            int portNum = 0;
            myBox.Items.Clear();
            for (int i = 1; i< 20; i++)
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
            if (availablePortList.Length > 0)
            {
                myBox.Text = availablePortList[0];
            }
        }

        private void btn_openDevice1_Click(object sender, EventArgs e)
        {   
            if (!btnOpenSerialPortState)
            {
                MessageBox.Show("Open the serial port to proceed.");
                return;
            }

            if (txt_timerToTurnOff.Text == "")
            {
                MessageBox.Show("The timer value can't be empty.");
                return;
            }

            // try parsing the input timer value
            try
            {
                if (int.TryParse(txt_timerToTurnOff.Text, out timer1ConfiguredSec))
                {
                    if (timer1ConfiguredSec > 0)
                    {
                        timer1.Start();
                        btn_openDevice1.Enabled = false;
                        btn_closeDevice1.Enabled = true;
                        lbl_device1Status.BackColor = Color.DarkGreen;
                    }
                    else
                    {
                        MessageBox.Show("The timer value should be larger than 0.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("The timer value should be an integer.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("The timer value should be an integer.");
                return;
            }
        }

        private void btn_closeDevice1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            writeByteToSerialPort(deviceClose1);
            btn_openDevice1.Enabled = true;
            btn_closeDevice1.Enabled = false;
            lbl_device1Status.BackColor = Color.DarkGray;
            lbl_device1CloseAfter.Text = "";
            timer1TickedSec = 0;
        }

        private void btn_openDevice2_Click(object sender, EventArgs e)
        {
            if (!btnOpenSerialPortState)
            {
                MessageBox.Show("Open the serial port to proceed.");
                return;
            }
            writeByteToSerialPort(deviceOpen2);
            btn_openDevice2.Enabled = false;
            lbl_device2Status.BackColor = Color.DarkGreen;
            btn_closeDevice2.Enabled = true;
        }

        private void btn_closeDevice2_Click(object sender, EventArgs e)
        {
            writeByteToSerialPort(deviceClose2);
            btn_openDevice2.Enabled = true;
            btn_closeDevice2.Enabled = false;
            lbl_device2Status.BackColor = Color.DarkGray;
        }

        private void btn_openDevice3_Click(object sender, EventArgs e)
        {
            if (!btnOpenSerialPortState)
            {
                MessageBox.Show("Open the serial port to proceed.");
                return;
            }
            writeByteToSerialPort(deviceOpen3);
            btn_openDevice3.Enabled = false;
            lbl_device3Status.BackColor = Color.DarkGreen;
            btn_closeDevice3.Enabled = true;
        }

        private void btn_closeDevice3_Click(object sender, EventArgs e)
        {
            writeByteToSerialPort(deviceClose3);
            btn_openDevice3.Enabled = true;
            btn_closeDevice3.Enabled = false;
            lbl_device3Status.BackColor = Color.DarkGray;
        }

        private void writeByteToSerialPort(byte data)   
        {
            byte[] buffer = new byte[2] { 0x00, data };
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write(buffer, 0, 2);
                }
                catch (Exception)
                {
                    MessageBox.Show("Fail to write data to serial port", "Error");
                }
            }
        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            searchAndAddSerialPortToComboBox(serialPort1, cmb_serialPort);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1TickedSec++;
            lbl_device1CloseAfter.Text = $"Device 1 closes after {timer1ConfiguredSec - timer1TickedSec} seconds.";
            // close device 1 if remaining time is 0
            if (timer1ConfiguredSec == timer1TickedSec)
            {
                timer1.Stop();
                writeByteToSerialPort(deviceClose1);
                btn_openDevice1.Enabled = true;
                lbl_device1Status.BackColor = Color.DarkGray;
                lbl_device1CloseAfter.Text = "";
                timer1TickedSec = 0;
            }
        }
    }
}
