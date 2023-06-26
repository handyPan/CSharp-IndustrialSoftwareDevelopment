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

namespace WaveformDrawer
{
    public partial class frmSetting : Form
    {
        
        public const int maxDrawingStep = 33;
        public const int minDrawingStep = 1;
        public string portName;
        public int drawingStep = 4;

        public frmSetting()
        {
            InitializeComponent();
            searchAndAddSerialPortToComboBox(serialPort1, cmb_serialPort);
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {   
            if (cmb_serialPort.Items.Count == 0)
            {
                MessageBox.Show("No serial port available", "Error");
                Close();
            }

            if (portName != null)
            {
                cmb_serialPort.Text = portName;
                if (!cmb_serialPort.Items.Contains(portName))
                {
                    cmb_serialPort.Items.Add(portName);
                }
            }

            for (int i=1;i< maxDrawingStep; i++)
            {
                cmb_drawingStep.Items.Add(i.ToString());
            }
            //cmb_drawingStep.SelectedIndex = 0;
            cmb_drawingStep.Text = drawingStep.ToString();
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

        private void btn_apply_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            //portName = cmb_serialPort.Text;
            //drawingStep = Convert.ToInt16(cmb_drawingStep.Text);
        }

        public void updatePortNameAndDrawingStep()
        {
            portName = cmb_serialPort.Text.ToString();
            drawingStep = Convert.ToInt16(cmb_drawingStep.Text);
        }
    }
}
