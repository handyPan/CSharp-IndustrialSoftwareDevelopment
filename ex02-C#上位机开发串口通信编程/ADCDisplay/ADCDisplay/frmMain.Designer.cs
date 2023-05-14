namespace ADCDisplay
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_turnOnOffSerialPort = new System.Windows.Forms.Button();
            this.cmb_sendPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.serPort_send = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_receivePort = new System.Windows.Forms.ComboBox();
            this.serPort_receive = new System.IO.Ports.SerialPort(this.components);
            this.lbl_adcResultMin = new System.Windows.Forms.Label();
            this.lbl_adcResultMax = new System.Windows.Forms.Label();
            this.lbl_adcResultValue1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_adcResultValue2 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_adcResultValue3 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_adcResultValue4 = new System.Windows.Forms.Label();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_adcResultValue5 = new System.Windows.Forms.Label();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbl_adcResultValue6 = new System.Windows.Forms.Label();
            this.progressBar7 = new System.Windows.Forms.ProgressBar();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lbl_adcResultValue7 = new System.Windows.Forms.Label();
            this.progressBar8 = new System.Windows.Forms.ProgressBar();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lbl_adcResultValue8 = new System.Windows.Forms.Label();
            this.progressBar9 = new System.Windows.Forms.ProgressBar();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.lbl_adcResultValue9 = new System.Windows.Forms.Label();
            this.progressBar10 = new System.Windows.Forms.ProgressBar();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lbl_adcResultValue10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_turnOnOffSerialPort);
            this.groupBox1.Controls.Add(this.cmb_receivePort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_sendPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port Configuration";
            // 
            // btn_turnOnOffSerialPort
            // 
            this.btn_turnOnOffSerialPort.Location = new System.Drawing.Point(243, 26);
            this.btn_turnOnOffSerialPort.Name = "btn_turnOnOffSerialPort";
            this.btn_turnOnOffSerialPort.Size = new System.Drawing.Size(75, 23);
            this.btn_turnOnOffSerialPort.TabIndex = 2;
            this.btn_turnOnOffSerialPort.Text = "Turn ON";
            this.btn_turnOnOffSerialPort.UseVisualStyleBackColor = true;
            this.btn_turnOnOffSerialPort.Click += new System.EventHandler(this.btn_turnOnOffSerialPort_Click);
            // 
            // cmb_sendPort
            // 
            this.cmb_sendPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sendPort.FormattingEnabled = true;
            this.cmb_sendPort.Location = new System.Drawing.Point(41, 28);
            this.cmb_sendPort.Name = "cmb_sendPort";
            this.cmb_sendPort.Size = new System.Drawing.Size(67, 20);
            this.cmb_sendPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Send";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_adcResultValue10);
            this.groupBox2.Controls.Add(this.lbl_adcResultValue9);
            this.groupBox2.Controls.Add(this.lbl_adcResultValue8);
            this.groupBox2.Controls.Add(this.lbl_adcResultValue7);
            this.groupBox2.Controls.Add(this.lbl_adcResultValue6);
            this.groupBox2.Controls.Add(this.lbl_adcResultValue5);
            this.groupBox2.Controls.Add(this.lbl_adcResultValue4);
            this.groupBox2.Controls.Add(this.lbl_adcResultValue3);
            this.groupBox2.Controls.Add(this.lbl_adcResultValue2);
            this.groupBox2.Controls.Add(this.lbl_adcResultValue1);
            this.groupBox2.Controls.Add(this.label38);
            this.groupBox2.Controls.Add(this.label34);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label37);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbl_adcResultMax);
            this.groupBox2.Controls.Add(this.label36);
            this.groupBox2.Controls.Add(this.label32);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbl_adcResultMin);
            this.groupBox2.Controls.Add(this.progressBar10);
            this.groupBox2.Controls.Add(this.progressBar9);
            this.groupBox2.Controls.Add(this.progressBar8);
            this.groupBox2.Controls.Add(this.progressBar7);
            this.groupBox2.Controls.Add(this.progressBar6);
            this.groupBox2.Controls.Add(this.progressBar5);
            this.groupBox2.Controls.Add(this.progressBar4);
            this.groupBox2.Controls.Add(this.progressBar3);
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(13, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 329);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ADC Result";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(49, 28);
            this.progressBar1.Maximum = 255;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(244, 13);
            this.progressBar1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(112, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Receive";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_receivePort
            // 
            this.cmb_receivePort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_receivePort.FormattingEnabled = true;
            this.cmb_receivePort.Location = new System.Drawing.Point(170, 28);
            this.cmb_receivePort.Name = "cmb_receivePort";
            this.cmb_receivePort.Size = new System.Drawing.Size(67, 20);
            this.cmb_receivePort.TabIndex = 1;
            // 
            // lbl_adcResultMin
            // 
            this.lbl_adcResultMin.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adcResultMin.Location = new System.Drawing.Point(36, 28);
            this.lbl_adcResultMin.Name = "lbl_adcResultMin";
            this.lbl_adcResultMin.Size = new System.Drawing.Size(13, 13);
            this.lbl_adcResultMin.TabIndex = 1;
            this.lbl_adcResultMin.Text = "0";
            this.lbl_adcResultMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_adcResultMax
            // 
            this.lbl_adcResultMax.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adcResultMax.Location = new System.Drawing.Point(293, 28);
            this.lbl_adcResultMax.Name = "lbl_adcResultMax";
            this.lbl_adcResultMax.Size = new System.Drawing.Size(23, 13);
            this.lbl_adcResultMax.TabIndex = 1;
            this.lbl_adcResultMax.Text = "255";
            this.lbl_adcResultMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_adcResultValue1
            // 
            this.lbl_adcResultValue1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adcResultValue1.ForeColor = System.Drawing.Color.Red;
            this.lbl_adcResultValue1.Location = new System.Drawing.Point(49, 43);
            this.lbl_adcResultValue1.Name = "lbl_adcResultValue1";
            this.lbl_adcResultValue1.Size = new System.Drawing.Size(23, 13);
            this.lbl_adcResultValue1.TabIndex = 1;
            this.lbl_adcResultValue1.Text = "255";
            this.lbl_adcResultValue1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(10, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(49, 58);
            this.progressBar2.Maximum = 255;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(244, 13);
            this.progressBar2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(36, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(293, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "255";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(10, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "2";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_adcResultValue2
            // 
            this.lbl_adcResultValue2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adcResultValue2.ForeColor = System.Drawing.Color.Red;
            this.lbl_adcResultValue2.Location = new System.Drawing.Point(49, 73);
            this.lbl_adcResultValue2.Name = "lbl_adcResultValue2";
            this.lbl_adcResultValue2.Size = new System.Drawing.Size(23, 13);
            this.lbl_adcResultValue2.TabIndex = 1;
            this.lbl_adcResultValue2.Text = "255";
            this.lbl_adcResultValue2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(49, 88);
            this.progressBar3.Maximum = 255;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(244, 13);
            this.progressBar3.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(36, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "0";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(293, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "255";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(10, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "3";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_adcResultValue3
            // 
            this.lbl_adcResultValue3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adcResultValue3.ForeColor = System.Drawing.Color.Red;
            this.lbl_adcResultValue3.Location = new System.Drawing.Point(49, 103);
            this.lbl_adcResultValue3.Name = "lbl_adcResultValue3";
            this.lbl_adcResultValue3.Size = new System.Drawing.Size(23, 13);
            this.lbl_adcResultValue3.TabIndex = 1;
            this.lbl_adcResultValue3.Text = "255";
            this.lbl_adcResultValue3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(49, 118);
            this.progressBar4.Maximum = 255;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(244, 13);
            this.progressBar4.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(36, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "0";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(293, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "255";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(10, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "4";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_adcResultValue4
            // 
            this.lbl_adcResultValue4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adcResultValue4.ForeColor = System.Drawing.Color.Red;
            this.lbl_adcResultValue4.Location = new System.Drawing.Point(49, 133);
            this.lbl_adcResultValue4.Name = "lbl_adcResultValue4";
            this.lbl_adcResultValue4.Size = new System.Drawing.Size(23, 13);
            this.lbl_adcResultValue4.TabIndex = 1;
            this.lbl_adcResultValue4.Text = "255";
            this.lbl_adcResultValue4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(49, 148);
            this.progressBar5.Maximum = 255;
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(244, 13);
            this.progressBar5.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(36, 148);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "0";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(293, 148);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "255";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(10, 148);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "5";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_adcResultValue5
            // 
            this.lbl_adcResultValue5.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adcResultValue5.ForeColor = System.Drawing.Color.Red;
            this.lbl_adcResultValue5.Location = new System.Drawing.Point(49, 163);
            this.lbl_adcResultValue5.Name = "lbl_adcResultValue5";
            this.lbl_adcResultValue5.Size = new System.Drawing.Size(23, 13);
            this.lbl_adcResultValue5.TabIndex = 1;
            this.lbl_adcResultValue5.Text = "255";
            this.lbl_adcResultValue5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar6
            // 
            this.progressBar6.Location = new System.Drawing.Point(49, 178);
            this.progressBar6.Maximum = 255;
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(244, 13);
            this.progressBar6.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(36, 178);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "0";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(293, 178);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "255";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(10, 178);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(23, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "6";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_adcResultValue6
            // 
            this.lbl_adcResultValue6.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adcResultValue6.ForeColor = System.Drawing.Color.Red;
            this.lbl_adcResultValue6.Location = new System.Drawing.Point(49, 193);
            this.lbl_adcResultValue6.Name = "lbl_adcResultValue6";
            this.lbl_adcResultValue6.Size = new System.Drawing.Size(23, 13);
            this.lbl_adcResultValue6.TabIndex = 1;
            this.lbl_adcResultValue6.Text = "255";
            this.lbl_adcResultValue6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar7
            // 
            this.progressBar7.Location = new System.Drawing.Point(49, 208);
            this.progressBar7.Maximum = 255;
            this.progressBar7.Name = "progressBar7";
            this.progressBar7.Size = new System.Drawing.Size(244, 13);
            this.progressBar7.TabIndex = 0;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(36, 208);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(13, 13);
            this.label24.TabIndex = 1;
            this.label24.Text = "0";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(293, 208);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(23, 13);
            this.label25.TabIndex = 1;
            this.label25.Text = "255";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Location = new System.Drawing.Point(10, 208);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(23, 13);
            this.label26.TabIndex = 1;
            this.label26.Text = "7";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_adcResultValue7
            // 
            this.lbl_adcResultValue7.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adcResultValue7.ForeColor = System.Drawing.Color.Red;
            this.lbl_adcResultValue7.Location = new System.Drawing.Point(49, 223);
            this.lbl_adcResultValue7.Name = "lbl_adcResultValue7";
            this.lbl_adcResultValue7.Size = new System.Drawing.Size(23, 13);
            this.lbl_adcResultValue7.TabIndex = 1;
            this.lbl_adcResultValue7.Text = "255";
            this.lbl_adcResultValue7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar8
            // 
            this.progressBar8.Location = new System.Drawing.Point(49, 238);
            this.progressBar8.Maximum = 255;
            this.progressBar8.Name = "progressBar8";
            this.progressBar8.Size = new System.Drawing.Size(244, 13);
            this.progressBar8.TabIndex = 0;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(36, 238);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(13, 13);
            this.label28.TabIndex = 1;
            this.label28.Text = "0";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Location = new System.Drawing.Point(293, 238);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(23, 13);
            this.label29.TabIndex = 1;
            this.label29.Text = "255";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Location = new System.Drawing.Point(10, 238);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(23, 13);
            this.label30.TabIndex = 1;
            this.label30.Text = "8";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_adcResultValue8
            // 
            this.lbl_adcResultValue8.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adcResultValue8.ForeColor = System.Drawing.Color.Red;
            this.lbl_adcResultValue8.Location = new System.Drawing.Point(49, 253);
            this.lbl_adcResultValue8.Name = "lbl_adcResultValue8";
            this.lbl_adcResultValue8.Size = new System.Drawing.Size(23, 13);
            this.lbl_adcResultValue8.TabIndex = 1;
            this.lbl_adcResultValue8.Text = "255";
            this.lbl_adcResultValue8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar9
            // 
            this.progressBar9.Location = new System.Drawing.Point(49, 268);
            this.progressBar9.Maximum = 255;
            this.progressBar9.Name = "progressBar9";
            this.progressBar9.Size = new System.Drawing.Size(244, 13);
            this.progressBar9.TabIndex = 0;
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Location = new System.Drawing.Point(36, 268);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(13, 13);
            this.label32.TabIndex = 1;
            this.label32.Text = "0";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Location = new System.Drawing.Point(293, 268);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(23, 13);
            this.label33.TabIndex = 1;
            this.label33.Text = "255";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Location = new System.Drawing.Point(10, 268);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(23, 13);
            this.label34.TabIndex = 1;
            this.label34.Text = "9";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_adcResultValue9
            // 
            this.lbl_adcResultValue9.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adcResultValue9.ForeColor = System.Drawing.Color.Red;
            this.lbl_adcResultValue9.Location = new System.Drawing.Point(49, 283);
            this.lbl_adcResultValue9.Name = "lbl_adcResultValue9";
            this.lbl_adcResultValue9.Size = new System.Drawing.Size(23, 13);
            this.lbl_adcResultValue9.TabIndex = 1;
            this.lbl_adcResultValue9.Text = "255";
            this.lbl_adcResultValue9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar10
            // 
            this.progressBar10.Location = new System.Drawing.Point(49, 298);
            this.progressBar10.Maximum = 255;
            this.progressBar10.Name = "progressBar10";
            this.progressBar10.Size = new System.Drawing.Size(244, 13);
            this.progressBar10.TabIndex = 0;
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Location = new System.Drawing.Point(36, 298);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(13, 13);
            this.label36.TabIndex = 1;
            this.label36.Text = "0";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Location = new System.Drawing.Point(293, 298);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(23, 13);
            this.label37.TabIndex = 1;
            this.label37.Text = "255";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Location = new System.Drawing.Point(10, 298);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(23, 13);
            this.label38.TabIndex = 1;
            this.label38.Text = "10";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_adcResultValue10
            // 
            this.lbl_adcResultValue10.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adcResultValue10.ForeColor = System.Drawing.Color.Red;
            this.lbl_adcResultValue10.Location = new System.Drawing.Point(49, 313);
            this.lbl_adcResultValue10.Name = "lbl_adcResultValue10";
            this.lbl_adcResultValue10.Size = new System.Drawing.Size(23, 13);
            this.lbl_adcResultValue10.TabIndex = 1;
            this.lbl_adcResultValue10.Text = "255";
            this.lbl_adcResultValue10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 439);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "ADC Display";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_turnOnOffSerialPort;
        private System.Windows.Forms.ComboBox cmb_sendPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.IO.Ports.SerialPort serPort_send;
        private System.Windows.Forms.ComboBox cmb_receivePort;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serPort_receive;
        private System.Windows.Forms.Label lbl_adcResultValue1;
        private System.Windows.Forms.Label lbl_adcResultMax;
        private System.Windows.Forms.Label lbl_adcResultMin;
        private System.Windows.Forms.Label lbl_adcResultValue10;
        private System.Windows.Forms.Label lbl_adcResultValue9;
        private System.Windows.Forms.Label lbl_adcResultValue8;
        private System.Windows.Forms.Label lbl_adcResultValue7;
        private System.Windows.Forms.Label lbl_adcResultValue6;
        private System.Windows.Forms.Label lbl_adcResultValue5;
        private System.Windows.Forms.Label lbl_adcResultValue4;
        private System.Windows.Forms.Label lbl_adcResultValue3;
        private System.Windows.Forms.Label lbl_adcResultValue2;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar10;
        private System.Windows.Forms.ProgressBar progressBar9;
        private System.Windows.Forms.ProgressBar progressBar8;
        private System.Windows.Forms.ProgressBar progressBar7;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}

