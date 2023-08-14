namespace WaveformDrawerWithSerialPortSendData
{
    partial class Setting
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
            this.btnClosePort = new System.Windows.Forms.Button();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.btnDrawWaveform = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radBtnRecChar = new System.Windows.Forms.RadioButton();
            this.radBtnRecValue = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radBtnSendChar = new System.Windows.Forms.RadioButton();
            this.radBtnSendValue = new System.Windows.Forms.RadioButton();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbReceivePort = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSendPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataSent = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDataReceived = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSendData = new System.Windows.Forms.Button();
            this.serPortSend = new System.IO.Ports.SerialPort(this.components);
            this.serPortReceive = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClosePort);
            this.groupBox1.Controls.Add(this.btnOpenPort);
            this.groupBox1.Controls.Add(this.btnDrawWaveform);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.cmbBaudRate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbReceivePort);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbSendPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // btnClosePort
            // 
            this.btnClosePort.Location = new System.Drawing.Point(27, 290);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.Size = new System.Drawing.Size(226, 24);
            this.btnClosePort.TabIndex = 3;
            this.btnClosePort.Text = "Close Port";
            this.btnClosePort.UseVisualStyleBackColor = true;
            this.btnClosePort.Click += new System.EventHandler(this.btnClosePort_Click);
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(27, 251);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(226, 24);
            this.btnOpenPort.TabIndex = 3;
            this.btnOpenPort.Text = "Open Port";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // btnDrawWaveform
            // 
            this.btnDrawWaveform.Location = new System.Drawing.Point(27, 212);
            this.btnDrawWaveform.Name = "btnDrawWaveform";
            this.btnDrawWaveform.Size = new System.Drawing.Size(226, 24);
            this.btnDrawWaveform.TabIndex = 3;
            this.btnDrawWaveform.Text = "Draw Waveform";
            this.btnDrawWaveform.UseVisualStyleBackColor = true;
            this.btnDrawWaveform.Click += new System.EventHandler(this.btnDrawWaveform_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radBtnRecChar);
            this.panel2.Controls.Add(this.radBtnRecValue);
            this.panel2.Location = new System.Drawing.Point(132, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 24);
            this.panel2.TabIndex = 2;
            // 
            // radBtnRecChar
            // 
            this.radBtnRecChar.Location = new System.Drawing.Point(63, 3);
            this.radBtnRecChar.Name = "radBtnRecChar";
            this.radBtnRecChar.Size = new System.Drawing.Size(55, 20);
            this.radBtnRecChar.TabIndex = 0;
            this.radBtnRecChar.TabStop = true;
            this.radBtnRecChar.Text = "Char";
            this.radBtnRecChar.UseVisualStyleBackColor = true;
            // 
            // radBtnRecValue
            // 
            this.radBtnRecValue.Location = new System.Drawing.Point(2, 3);
            this.radBtnRecValue.Name = "radBtnRecValue";
            this.radBtnRecValue.Size = new System.Drawing.Size(55, 20);
            this.radBtnRecValue.TabIndex = 0;
            this.radBtnRecValue.TabStop = true;
            this.radBtnRecValue.Text = "Value";
            this.radBtnRecValue.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radBtnSendChar);
            this.panel1.Controls.Add(this.radBtnSendValue);
            this.panel1.Location = new System.Drawing.Point(132, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 24);
            this.panel1.TabIndex = 2;
            // 
            // radBtnSendChar
            // 
            this.radBtnSendChar.Location = new System.Drawing.Point(63, 3);
            this.radBtnSendChar.Name = "radBtnSendChar";
            this.radBtnSendChar.Size = new System.Drawing.Size(55, 20);
            this.radBtnSendChar.TabIndex = 0;
            this.radBtnSendChar.TabStop = true;
            this.radBtnSendChar.Text = "Char";
            this.radBtnSendChar.UseVisualStyleBackColor = true;
            // 
            // radBtnSendValue
            // 
            this.radBtnSendValue.Location = new System.Drawing.Point(2, 3);
            this.radBtnSendValue.Name = "radBtnSendValue";
            this.radBtnSendValue.Size = new System.Drawing.Size(55, 20);
            this.radBtnSendValue.TabIndex = 0;
            this.radBtnSendValue.TabStop = true;
            this.radBtnSendValue.Text = "Value";
            this.radBtnSendValue.UseVisualStyleBackColor = true;
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Location = new System.Drawing.Point(131, 98);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(121, 20);
            this.cmbBaudRate.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(25, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Receive Mode";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(25, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Send Mode";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Baud Rate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbReceivePort
            // 
            this.cmbReceivePort.DropDownHeight = 108;
            this.cmbReceivePort.FormattingEnabled = true;
            this.cmbReceivePort.IntegralHeight = false;
            this.cmbReceivePort.Location = new System.Drawing.Point(131, 62);
            this.cmbReceivePort.Name = "cmbReceivePort";
            this.cmbReceivePort.Size = new System.Drawing.Size(121, 20);
            this.cmbReceivePort.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(25, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Receive Port";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSendPort
            // 
            this.cmbSendPort.DropDownHeight = 108;
            this.cmbSendPort.FormattingEnabled = true;
            this.cmbSendPort.IntegralHeight = false;
            this.cmbSendPort.Location = new System.Drawing.Point(131, 26);
            this.cmbSendPort.Name = "cmbSendPort";
            this.cmbSendPort.Size = new System.Drawing.Size(121, 20);
            this.cmbSendPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Send Port";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDataSent
            // 
            this.txtDataSent.Location = new System.Drawing.Point(17, 26);
            this.txtDataSent.Multiline = true;
            this.txtDataSent.Name = "txtDataSent";
            this.txtDataSent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDataSent.Size = new System.Drawing.Size(177, 45);
            this.txtDataSent.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDataReceived);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnSendData);
            this.groupBox2.Controls.Add(this.txtDataSent);
            this.groupBox2.Location = new System.Drawing.Point(328, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 333);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // txtDataReceived
            // 
            this.txtDataReceived.Location = new System.Drawing.Point(17, 112);
            this.txtDataReceived.Multiline = true;
            this.txtDataReceived.Name = "txtDataReceived";
            this.txtDataReceived.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDataReceived.Size = new System.Drawing.Size(243, 202);
            this.txtDataReceived.TabIndex = 6;
            this.txtDataReceived.TextChanged += new System.EventHandler(this.txtDataReceived_TextChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(15, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Received";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(200, 26);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(60, 45);
            this.btnSendData.TabIndex = 4;
            this.btnSendData.Text = "Send";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // serPortReceive
            // 
            this.serPortReceive.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serPortReceive_DataReceived);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 359);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Setting";
            this.Text = "Serial Port Send Data";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSendPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radBtnSendValue;
        private System.Windows.Forms.RadioButton radBtnSendChar;
        private System.Windows.Forms.Button btnClosePort;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.Button btnDrawWaveform;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radBtnRecChar;
        private System.Windows.Forms.RadioButton radBtnRecValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbReceivePort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDataSent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDataReceived;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSendData;
        private System.IO.Ports.SerialPort serPortSend;
        private System.IO.Ports.SerialPort serPortReceive;
    }
}

