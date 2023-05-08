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
                }
                catch (Exception)
                {

                    throw;
                }
                btn_openSerialPort.Text = "Open Serial Port";
            }
            else
            {
                try
                {
                    serialPort1.PortName = cmb_serialPort.Text;
                    serialPort1.Open();
                    btn_openSerialPort.Text = "Close Serial Port";
                }
                catch (Exception)
                {

                    MessageBox.Show("Fail to open serial port", "Error");
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            searchAndAddSerialPortToComboBox(serialPort1, cmb_serialPort);
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
            writeByteToSerialPort(deviceOpen1);
        }

        private void btn_closeDevice1_Click(object sender, EventArgs e)
        {
            writeByteToSerialPort(deviceClose1);
        }

        private void btn_openDevice2_Click(object sender, EventArgs e)
        {
            writeByteToSerialPort(deviceOpen2);
        }

        private void btn_closeDevice2_Click(object sender, EventArgs e)
        {
            writeByteToSerialPort(deviceClose2);
        }

        private void btn_openDevice3_Click(object sender, EventArgs e)
        {
            writeByteToSerialPort(deviceOpen3);
        }

        private void btn_closeDevice3_Click(object sender, EventArgs e)
        {
            writeByteToSerialPort(deviceClose3);
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
    }
}
