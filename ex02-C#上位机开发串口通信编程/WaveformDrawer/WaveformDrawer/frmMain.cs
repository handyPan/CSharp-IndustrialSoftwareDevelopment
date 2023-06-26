using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaveformDrawer
{   
    public partial class frmMain : Form
    {
        private const int Unit_Length = 32;
        private const int Y_Max = 512;
        private const int Start_Print = 32;
        private Pen Table_Pen = new Pen(Color.FromArgb(0x00, 0x40, 0x30));
        private Pen Line_Pen = new Pen(Color.FromArgb(0x00, 0xFF, 0x00));

        public string portName;
        public int drawingStep = 4;
        private int lastCountAdded;
        private List<byte> dataList = new List<byte>();
        private bool keyShift, keySet, keyExit, keyOpen, keyClose, keyStepUp, keyStepDown;


        frmSetting fSetting = new frmSetting();

        public frmMain()
        {
            SetStyle(
                ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint,
                true
            );
            UpdateStyles();

            InitializeComponent();
            updateStatusBar("N/A", "N/A", drawingStep, "Initialization completed");
            

            fSetting.FormClosing += new FormClosingEventHandler(this.fSetting_FormClosing);
            fSetting.TopMost = true;
        }

        private void updateStatusBar(string portName, string portStatus, int drawingStep, string msg)
        {
            toolStripStatusLabel1.Text = $"COM Setting: {portName}";
            toolStripStatusLabel3.Text = $"COM Status: {portStatus}";
            toolStripStatusLabel5.Text = $"Drawingstep Setting: {drawingStep}";
            toolStripStatusLabel7.Text = $"Message: {msg}!";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            int height = Height - ClientRectangle.Height + statusStrip1.Height + statusStrip2.Height;
            int borderWeight = Width - ClientRectangle.Width;
            Rectangle rect = Screen.GetWorkingArea(this);
            this.Size = new Size(
                rect.Width - (rect.Width - borderWeight) % Unit_Length, 
                height + Y_Max + Start_Print + Unit_Length
            );

            fSetting.ShowDialog();
        }

        private void fSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            fSetting.updatePortNameAndDrawingStep();

            if (fSetting.portName != "")
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    updateStatusBar(serialPort1.PortName, "OFF", drawingStep, $"{serialPort1.PortName} closed");
                }

                serialPort1.PortName = fSetting.portName;
                drawingStep = fSetting.drawingStep;

                try
                {
                    serialPort1.Open();
                    MessageBox.Show($"{serialPort1.PortName} opened to receive data", "Info");
                    updateStatusBar(serialPort1.PortName, "ON", drawingStep, $"{serialPort1.PortName} opened");
                }
                catch (Exception)
                {
                    MessageBox.Show($"Fail to open {serialPort1.PortName}", "Error");
                    updateStatusBar(serialPort1.PortName, "OFF", drawingStep, $"Fail to open {serialPort1.PortName}");
                }

                Invalidate();
            }
            else
            {
                MessageBox.Show($"Serial Port number can't be empty.");
            }
            
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            String str = "";
            GraphicsPath gp = new GraphicsPath();
            e.Graphics.FillRectangle(Brushes.Black, e.Graphics.ClipBounds);
            // draw Y
            for (int i = 0; i <= ClientRectangle.Width / Unit_Length; i++)
            {
                e.Graphics.DrawLine(
                    Table_Pen, 
                    Start_Print + i * Unit_Length, 
                    Start_Print, 
                    Start_Print + i * Unit_Length, 
                    Start_Print + Y_Max
                );
            }
            // draw X
            for (int i = 0; i <= ClientRectangle.Height / Unit_Length; i++)
            {
                e.Graphics.DrawLine(
                    Table_Pen, 
                    Start_Print, 
                    i * Unit_Length, 
                    ClientRectangle.Width, 
                    i * Unit_Length
                );
                str = ((16 - i) * 16).ToString("x");
                str = "0x" + (str.Length == 1 ? "0" + str.ToUpper() : str.ToUpper());
                if (i == 0) str = "0xFF";
                if (i == 17) break;
                gp.AddString(
                    str, 
                    Font.FontFamily, 
                    (int)FontStyle.Regular, 
                    14, 
                    new RectangleF(0, Start_Print + i * Unit_Length - 8, 400, 50),
                    null
                );
            }
            e.Graphics.DrawPath(Pens.Green, gp);
            if (dataList.Count - 1 >= (ClientRectangle.Width - Start_Print) / drawingStep)
            {
                dataList.RemoveRange(
                    0, 
                    dataList.Count - (this.ClientRectangle.Width - Start_Print) / drawingStep - 1);
            }
            for (int i = 0; i < dataList.Count - 1; i++)
            {
                e.Graphics.DrawLine(
                    Line_Pen, 
                    Start_Print + i * drawingStep, 
                    17 * Unit_Length - dataList[i] * 2, 
                    Start_Print + (i + 1) * drawingStep, 
                    17 * Unit_Length - dataList[i + 1] * 2);
            }
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (keyShift)
            {
                if (keySet)
                {
                    fSetting.portName = serialPort1.PortName;
                    fSetting.drawingStep = drawingStep;
                    fSetting.ShowDialog();

                    Invalidate();   // redraw
                    keySet = false;
                }
                else
                {
                    if (keyOpen)
                    {
                        try
                        {
                            serialPort1.Open();
                            MessageBox.Show($"{serialPort1.PortName} opened to receive data", "Info");
                            updateStatusBar(serialPort1.PortName, "ON", drawingStep, $"{serialPort1.PortName} opened");
                            // DataList.Clear();
                        }
                        catch (System.Exception)
                        {
                            MessageBox.Show($"Fail to open {serialPort1.PortName}", "Error");
                        }
                        keyOpen = false;
                    }
                    else
                    {
                        if (keyClose)
                        {
                            if (serialPort1.IsOpen)
                            {
                                serialPort1.Close();
                                MessageBox.Show($"{serialPort1.PortName} closed", "Info");
                                updateStatusBar(serialPort1.PortName, "OFF", drawingStep, $"{serialPort1.PortName} closed");
                            }
                            keyClose = false;
                        }
                        else
                        {
                            if (keyExit)
                            {
                                Close();
                                keyExit = false;
                            }
                            else
                            {
                                if (keyStepUp)
                                {
                                    if (drawingStep != frmSetting.maxDrawingStep)
                                        drawingStep++;
                                    updateStatusBar(serialPort1.PortName, "ON", drawingStep, $"Drawingstep increased to {drawingStep}");
                                    Invalidate();
                                    keyStepUp = false;
                                }
                                else
                                {
                                    if (keyStepDown)
                                    {
                                        if (drawingStep != frmSetting.minDrawingStep)
                                            drawingStep--;
                                        updateStatusBar(serialPort1.PortName, "ON", drawingStep, $"Drawingstep decreased to {drawingStep}");
                                        Invalidate();
                                        keyStepDown = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                keyClose = false;
                keyOpen = false;
                keySet = false;
                keyExit = false;
                keyStepUp = false;
                keyStepDown = false;
            }
            keyShift = false;
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift)
                keyShift = true;
            switch (e.KeyCode)
            {
                case Keys.S:
                    keySet = true;
                    break;
                case Keys.E:
                    keyExit = true;
                    break;
                case Keys.O:
                    keyOpen = true;
                    break;
                case Keys.C:
                    keyClose = true;
                    break;
                case Keys.Up:
                    keyStepUp = true;
                    break;
                case Keys.Down:
                    keyStepDown = true;
                    break;
                default:
                    break;
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                byte[] data = new byte[serialPort1.BytesToRead];// buffer to read bytes received at serial port 1
                serialPort1.Read(data, 0, data.Length);
                lastCountAdded = data.Length;
                for (int i = 0; i < data.Length; i++)
                {
                    dataList.Add(data[i]);
                }
                Invalidate();
            }
            catch (System.Exception) { }
        }

        
    }
}
