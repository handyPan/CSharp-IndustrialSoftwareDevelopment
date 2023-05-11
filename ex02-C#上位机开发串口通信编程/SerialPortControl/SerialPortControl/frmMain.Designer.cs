namespace SerialPortControl
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
            this.cmb_serialPort = new System.Windows.Forms.ComboBox();
            this.btn_scan = new System.Windows.Forms.Button();
            this.btn_openSerialPort = new System.Windows.Forms.Button();
            this.btn_closeDevice1 = new System.Windows.Forms.Button();
            this.btn_openDevice1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_timerToTurnOff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_closeDevice2 = new System.Windows.Forms.Button();
            this.btn_openDevice2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_openDevice3 = new System.Windows.Forms.Button();
            this.btn_closeDevice3 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_device1CloseAfter = new System.Windows.Forms.Label();
            this.lbl_device1Status = new System.Windows.Forms.Label();
            this.lbl_device2Status = new System.Windows.Forms.Label();
            this.lbl_device3Status = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_serialPort
            // 
            this.cmb_serialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_serialPort.FormattingEnabled = true;
            this.cmb_serialPort.Location = new System.Drawing.Point(39, 38);
            this.cmb_serialPort.Name = "cmb_serialPort";
            this.cmb_serialPort.Size = new System.Drawing.Size(90, 20);
            this.cmb_serialPort.TabIndex = 0;
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(148, 38);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(75, 23);
            this.btn_scan.TabIndex = 1;
            this.btn_scan.Text = "Scan";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // btn_openSerialPort
            // 
            this.btn_openSerialPort.BackgroundImage = global::SerialPortControl.Properties.Resources.btn_dark;
            this.btn_openSerialPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_openSerialPort.Location = new System.Drawing.Point(369, 15);
            this.btn_openSerialPort.Name = "btn_openSerialPort";
            this.btn_openSerialPort.Size = new System.Drawing.Size(79, 39);
            this.btn_openSerialPort.TabIndex = 1;
            this.btn_openSerialPort.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_openSerialPort.UseVisualStyleBackColor = true;
            this.btn_openSerialPort.Click += new System.EventHandler(this.btn_openSerialPort_Click);
            this.btn_openSerialPort.MouseLeave += new System.EventHandler(this.btn_openSerialPort_MouseLeave);
            this.btn_openSerialPort.MouseHover += new System.EventHandler(this.btn_openSerialPort_MouseHover);
            // 
            // btn_closeDevice1
            // 
            this.btn_closeDevice1.Enabled = false;
            this.btn_closeDevice1.Location = new System.Drawing.Point(266, 20);
            this.btn_closeDevice1.Name = "btn_closeDevice1";
            this.btn_closeDevice1.Size = new System.Drawing.Size(184, 23);
            this.btn_closeDevice1.TabIndex = 1;
            this.btn_closeDevice1.Text = "Close";
            this.btn_closeDevice1.UseVisualStyleBackColor = true;
            this.btn_closeDevice1.Click += new System.EventHandler(this.btn_closeDevice1_Click);
            // 
            // btn_openDevice1
            // 
            this.btn_openDevice1.Location = new System.Drawing.Point(19, 20);
            this.btn_openDevice1.Name = "btn_openDevice1";
            this.btn_openDevice1.Size = new System.Drawing.Size(184, 23);
            this.btn_openDevice1.TabIndex = 1;
            this.btn_openDevice1.Text = "Open";
            this.btn_openDevice1.UseVisualStyleBackColor = true;
            this.btn_openDevice1.Click += new System.EventHandler(this.btn_openDevice1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_openSerialPort);
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turn ON/OFF";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_device1Status);
            this.groupBox2.Controls.Add(this.txt_timerToTurnOff);
            this.groupBox2.Controls.Add(this.lbl_device1CloseAfter);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_openDevice1);
            this.groupBox2.Controls.Add(this.btn_closeDevice1);
            this.groupBox2.Location = new System.Drawing.Point(20, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 91);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Device 1";
            // 
            // txt_timerToTurnOff
            // 
            this.txt_timerToTurnOff.Location = new System.Drawing.Point(166, 54);
            this.txt_timerToTurnOff.Name = "txt_timerToTurnOff";
            this.txt_timerToTurnOff.Size = new System.Drawing.Size(37, 21);
            this.txt_timerToTurnOff.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Timer to turn off (sec)";
            // 
            // btn_closeDevice2
            // 
            this.btn_closeDevice2.Enabled = false;
            this.btn_closeDevice2.Location = new System.Drawing.Point(264, 25);
            this.btn_closeDevice2.Name = "btn_closeDevice2";
            this.btn_closeDevice2.Size = new System.Drawing.Size(184, 23);
            this.btn_closeDevice2.TabIndex = 1;
            this.btn_closeDevice2.Text = "Close";
            this.btn_closeDevice2.UseVisualStyleBackColor = true;
            this.btn_closeDevice2.Click += new System.EventHandler(this.btn_closeDevice2_Click);
            // 
            // btn_openDevice2
            // 
            this.btn_openDevice2.Location = new System.Drawing.Point(19, 25);
            this.btn_openDevice2.Name = "btn_openDevice2";
            this.btn_openDevice2.Size = new System.Drawing.Size(184, 23);
            this.btn_openDevice2.TabIndex = 1;
            this.btn_openDevice2.Text = "Open";
            this.btn_openDevice2.UseVisualStyleBackColor = true;
            this.btn_openDevice2.Click += new System.EventHandler(this.btn_openDevice2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_device2Status);
            this.groupBox3.Controls.Add(this.btn_openDevice2);
            this.groupBox3.Controls.Add(this.btn_closeDevice2);
            this.groupBox3.Location = new System.Drawing.Point(20, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(471, 65);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Device 2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_device3Status);
            this.groupBox4.Controls.Add(this.btn_openDevice3);
            this.groupBox4.Controls.Add(this.btn_closeDevice3);
            this.groupBox4.Location = new System.Drawing.Point(20, 281);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(471, 65);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Device 3";
            // 
            // btn_openDevice3
            // 
            this.btn_openDevice3.Location = new System.Drawing.Point(19, 25);
            this.btn_openDevice3.Name = "btn_openDevice3";
            this.btn_openDevice3.Size = new System.Drawing.Size(184, 23);
            this.btn_openDevice3.TabIndex = 1;
            this.btn_openDevice3.Text = "Open";
            this.btn_openDevice3.UseVisualStyleBackColor = true;
            this.btn_openDevice3.Click += new System.EventHandler(this.btn_openDevice3_Click);
            // 
            // btn_closeDevice3
            // 
            this.btn_closeDevice3.Enabled = false;
            this.btn_closeDevice3.Location = new System.Drawing.Point(264, 25);
            this.btn_closeDevice3.Name = "btn_closeDevice3";
            this.btn_closeDevice3.Size = new System.Drawing.Size(184, 23);
            this.btn_closeDevice3.TabIndex = 1;
            this.btn_closeDevice3.Text = "Close";
            this.btn_closeDevice3.UseVisualStyleBackColor = true;
            this.btn_closeDevice3.Click += new System.EventHandler(this.btn_closeDevice3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_device1CloseAfter
            // 
            this.lbl_device1CloseAfter.AutoSize = true;
            this.lbl_device1CloseAfter.Location = new System.Drawing.Point(269, 55);
            this.lbl_device1CloseAfter.Name = "lbl_device1CloseAfter";
            this.lbl_device1CloseAfter.Size = new System.Drawing.Size(137, 12);
            this.lbl_device1CloseAfter.TabIndex = 2;
            this.lbl_device1CloseAfter.Text = "Device 1 closes after ";
            // 
            // lbl_device1Status
            // 
            this.lbl_device1Status.Location = new System.Drawing.Point(214, 20);
            this.lbl_device1Status.Name = "lbl_device1Status";
            this.lbl_device1Status.Size = new System.Drawing.Size(25, 25);
            this.lbl_device1Status.TabIndex = 4;
            this.lbl_device1Status.Text = "label3";
            // 
            // lbl_device2Status
            // 
            this.lbl_device2Status.Location = new System.Drawing.Point(214, 25);
            this.lbl_device2Status.Name = "lbl_device2Status";
            this.lbl_device2Status.Size = new System.Drawing.Size(25, 25);
            this.lbl_device2Status.TabIndex = 4;
            this.lbl_device2Status.Text = "label3";
            // 
            // lbl_device3Status
            // 
            this.lbl_device3Status.Location = new System.Drawing.Point(214, 23);
            this.lbl_device3Status.Name = "lbl_device3Status";
            this.lbl_device3Status.Size = new System.Drawing.Size(25, 25);
            this.lbl_device3Status.TabIndex = 4;
            this.lbl_device3Status.Text = "label3";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 365);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.cmb_serialPort);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Serial Port Control";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_serialPort;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.Button btn_openSerialPort;
        private System.Windows.Forms.Button btn_closeDevice1;
        private System.Windows.Forms.Button btn_openDevice1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_closeDevice2;
        private System.Windows.Forms.Button btn_openDevice2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_openDevice3;
        private System.Windows.Forms.Button btn_closeDevice3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_timerToTurnOff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_device1CloseAfter;
        private System.Windows.Forms.Label lbl_device1Status;
        private System.Windows.Forms.Label lbl_device2Status;
        private System.Windows.Forms.Label lbl_device3Status;
    }
}

