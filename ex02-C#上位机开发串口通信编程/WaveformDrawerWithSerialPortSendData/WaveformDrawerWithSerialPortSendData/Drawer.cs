using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaveformDrawerWithSerialPortSendData
{
    public partial class Drawer : Form
    {
        private const int Y_Max = 512;  // max value on Y axis
        private const int Unit_Length = 32; // grid cell size
        private const int Start_Print = 32; // offset of the start print point
        private const int Max_Step = 33;    // max drawing step
        private const int Min_Step = 1; // min drawing step
        private int Drawing_Step = 8;   // default drawing step

        private List<byte> dataList = new List<byte>(); // store data to draw
        private Pen gridPen = new Pen(Color.FromArgb(0x00, 0x00, 0x00));   // black for grid lines
        private Pen waveformPen = new Pen(Color.FromArgb(0xa0, 0x00, 0x00));    // red for waveform

        // delegates
        public ShowWindow ShowSettingWindow;
        public HideWindow HideSettingWindow;
        public RefreshWindow RefreshSettingWindow;
        public OpenPort OpenSerialPort;
        public ClosePort CloseSerialPort;
        public GetWindowPosition GetSettingWindowPosition;
        public GetWindowWidth GetSettingWindowWidth;

        // keys
        private bool keyShift, keyShowSetting, keyHideSetting, keyExit, keyOpenPort, keyClosePort, keyIncStep, keyDecStep;

        public Drawer()
        {   
            // avoid flashing by "Double Buffer"
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            InitializeComponent();
        }

        public void addData(byte[] data)
        {
            for (int i=0;i<data.Length;i++)
            {
                dataList.Add(data[i]);
            }
            Invalidate();   // refresh window
        }

        private void Drawer_Paint(object sender, PaintEventArgs e)
        {
            String str = "";
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            e.Graphics.FillRectangle(Brushes.White, e.Graphics.ClipBounds);

            // draw X axis
            for (int i = 0; i <= this.ClientRectangle.Width / Unit_Length; i++)
            {
                e.Graphics.DrawLine(gridPen,
                                    Start_Print + i * Unit_Length,
                                    Start_Print,
                                    Start_Print + i * Unit_Length,
                                    Start_Print + Y_Max);   // draw grid lines
                gp.AddString((i * (Unit_Length / Drawing_Step)).ToString(),
                                this.Font.FontFamily,
                                (int)FontStyle.Regular,
                                12,
                                new RectangleF(Start_Print + i * Unit_Length - 7,
                                                this.ClientRectangle.Height - Start_Print + 4,
                                                400,
                                                50),
                                null);  //add characters
            }

            // draw Y axis
            for (int i = 0; i <= this.ClientRectangle.Height / Unit_Length; i++)
            {
                e.Graphics.DrawLine(gridPen,
                                    Start_Print,
                                    (i + 1) * Unit_Length,
                                    this.ClientRectangle.Width,
                                    (i + 1) * Unit_Length);     // draw grid lines
                str = ((16 - i) * 16).ToString("X");
                str = "0x" + (str.Length == 1 ? "0" + str.ToUpper() : str.ToUpper());
                if (i == 0) str = "0xFF";
                if (i == 17) break;
                gp.AddString(
                    str,
                    this.Font.FontFamily,
                    (int)FontStyle.Regular,
                    14,
                    new RectangleF(
                        0,
                        Start_Print + i * Unit_Length - 8,
                        400,
                        50
                    ),
                    null
                );  //add characters
            }

            e.Graphics.DrawPath(Pens.Black, gp);    // draw characters
            //if data points number is more than the capacity on the grid area, delete the left points
            if (dataList.Count - 1 >= (this.ClientRectangle.Width - Start_Print) / Drawing_Step)
            {
                dataList.RemoveRange(
                    0, 
                    dataList.Count - (this.ClientRectangle.Width - Start_Print) / Drawing_Step - 1
                );
            }

            // draw the waveform by the data points
            for (int i = 0; i < dataList.Count - 1; i++)
            {
                e.Graphics.DrawLine(
                    waveformPen,
                    Start_Print + i * Drawing_Step,
                    17 * Unit_Length - dataList[i] * 2,
                    Start_Print + (i + 1) * Drawing_Step,
                    17 * Unit_Length - dataList[i + 1] * 2);
            }
        }

        // for the setting form to set the drawer form
        public void setDrawerForm(int width, Point Pt)
        {
            int height = this.ClientRectangle.Height;
            height = this.Height - height;
            int borderWeight = this.Width - this.ClientRectangle.Width;
            this.Size = new Size(width - (width - borderWeight) % Unit_Length, 
                                height + Y_Max + Start_Print + Unit_Length);
            this.Location = Pt;
        }

        private void Drawer_KeyUp(object sender, KeyEventArgs e)
        {
            if (keyShift)
            {
                if (keyShowSetting) // show settting window
                {
                    ShowSettingWindow();
                    Rectangle Rect = Screen.GetWorkingArea(this);
                    setDrawerForm(
                        Rect.Width - GetSettingWindowWidth(),
                        new Point(GetSettingWindowWidth(), GetSettingWindowPosition().Y)
                    ); // reduce main window size
                    keyShowSetting = false;
                }
                else
                {
                    if (keyOpenPort)
                    {
                        OpenSerialPort();   // open serial port of main window
                        keyOpenPort = false;
                    }
                    else
                    {
                        if (keyClosePort)
                        {
                            CloseSerialPort();  // close serial port of main window
                            keyClosePort = false;
                        }
                        else
                        {
                            if (keyExit)
                            {
                                keyExit = false;    // exit main window
                                Close();
                            }
                            else
                            {
                                if (keyIncStep)
                                {
                                    if (Drawing_Step < Max_Step) // increase drawing step
                                        Drawing_Step++;
                                    Invalidate();
                                    keyIncStep = false;
                                }
                                else
                                {
                                    if (keyDecStep)
                                    {
                                        if (Drawing_Step > Min_Step)    // decrease drawing step
                                            Drawing_Step--;
                                        Invalidate();
                                        keyDecStep = false;
                                    }
                                    else
                                    {
                                        if (keyHideSetting)
                                        {
                                            HideSettingWindow();    // hide setting window and increase main window size
                                            Rectangle Rect = Screen.GetWorkingArea(this);
                                            setDrawerForm(Rect.Width, new Point(0, GetSettingWindowPosition().Y));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                RefreshSettingWindow();
            }
            else    // if it's other keys, clear all the shortcut variables
            {
                keyClosePort = false;
                keyOpenPort = false;
                keyShowSetting = false;
                keyExit = false;
                keyIncStep = false;
                keyDecStep = false;
            }
            keyShift = false;   
        }

        private void Drawer_KeyDown(object sender, KeyEventArgs e)   // event when key is down
        {
            if (e.Shift)//  shift
                keyShift = true;    
            switch (e.KeyCode)      // other keys
            {
                case Keys.S:        // show setting window
                    keyShowSetting = true;
                    break;
                case Keys.E:        // exit main window
                    keyExit = true;
                    break;
                case Keys.O:        // open serial port
                    keyOpenPort = true;
                    break;
                case Keys.C:        // close serial port
                    keyClosePort = true;
                    break;
                case Keys.Up:       // increase drawing step
                    keyIncStep = true;
                    break;
                case Keys.H:        // hide setting window
                    keyHideSetting = true;
                    break;
                case Keys.Down:     // decrease drawing step
                    keyDecStep = true;
                    break;
                default:
                    break;
            }
        }

        private void Drawer_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShowSettingWindow();
        }
    }
}
