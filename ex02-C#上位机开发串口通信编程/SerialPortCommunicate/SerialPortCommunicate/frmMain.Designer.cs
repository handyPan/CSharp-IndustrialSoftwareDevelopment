namespace SerialPortCommunicate
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_sendPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_baudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radio_sendValue = new System.Windows.Forms.RadioButton();
            this.radio_sendChar = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radio_receiveValue = new System.Windows.Forms.RadioButton();
            this.radio_receiveChar = new System.Windows.Forms.RadioButton();
            this.btn_openPort = new System.Windows.Forms.Button();
            this.btn_closePort = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_receive = new System.Windows.Forms.TextBox();
            this.txt_send = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.serPort_send = new System.IO.Ports.SerialPort(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_receivePort = new System.Windows.Forms.ComboBox();
            this.serPort_receive = new System.IO.Ports.SerialPort(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Send Port";
            // 
            // cmb_sendPort
            // 
            this.cmb_sendPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sendPort.FormattingEnabled = true;
            this.cmb_sendPort.Location = new System.Drawing.Point(132, 57);
            this.cmb_sendPort.Name = "cmb_sendPort";
            this.cmb_sendPort.Size = new System.Drawing.Size(139, 20);
            this.cmb_sendPort.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Baud Rate";
            // 
            // cmb_baudRate
            // 
            this.cmb_baudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_baudRate.FormattingEnabled = true;
            this.cmb_baudRate.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "115200"});
            this.cmb_baudRate.Location = new System.Drawing.Point(104, 101);
            this.cmb_baudRate.Name = "cmb_baudRate";
            this.cmb_baudRate.Size = new System.Drawing.Size(139, 20);
            this.cmb_baudRate.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Send Mode";
            // 
            // radio_sendValue
            // 
            this.radio_sendValue.AutoSize = true;
            this.radio_sendValue.Checked = true;
            this.radio_sendValue.Location = new System.Drawing.Point(3, 3);
            this.radio_sendValue.Name = "radio_sendValue";
            this.radio_sendValue.Size = new System.Drawing.Size(53, 16);
            this.radio_sendValue.TabIndex = 2;
            this.radio_sendValue.TabStop = true;
            this.radio_sendValue.Text = "Value";
            this.radio_sendValue.UseVisualStyleBackColor = true;
            // 
            // radio_sendChar
            // 
            this.radio_sendChar.AutoSize = true;
            this.radio_sendChar.Location = new System.Drawing.Point(89, 3);
            this.radio_sendChar.Name = "radio_sendChar";
            this.radio_sendChar.Size = new System.Drawing.Size(47, 16);
            this.radio_sendChar.TabIndex = 2;
            this.radio_sendChar.Text = "Char";
            this.radio_sendChar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radio_sendValue);
            this.panel1.Controls.Add(this.radio_sendChar);
            this.panel1.Location = new System.Drawing.Point(104, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 22);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Receive Mode";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radio_receiveValue);
            this.panel2.Controls.Add(this.radio_receiveChar);
            this.panel2.Location = new System.Drawing.Point(104, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 22);
            this.panel2.TabIndex = 3;
            // 
            // radio_receiveValue
            // 
            this.radio_receiveValue.AutoSize = true;
            this.radio_receiveValue.Checked = true;
            this.radio_receiveValue.Location = new System.Drawing.Point(3, 3);
            this.radio_receiveValue.Name = "radio_receiveValue";
            this.radio_receiveValue.Size = new System.Drawing.Size(53, 16);
            this.radio_receiveValue.TabIndex = 2;
            this.radio_receiveValue.TabStop = true;
            this.radio_receiveValue.Text = "Value";
            this.radio_receiveValue.UseVisualStyleBackColor = true;
            // 
            // radio_receiveChar
            // 
            this.radio_receiveChar.AutoSize = true;
            this.radio_receiveChar.Location = new System.Drawing.Point(89, 3);
            this.radio_receiveChar.Name = "radio_receiveChar";
            this.radio_receiveChar.Size = new System.Drawing.Size(47, 16);
            this.radio_receiveChar.TabIndex = 2;
            this.radio_receiveChar.Text = "Char";
            this.radio_receiveChar.UseVisualStyleBackColor = true;
            // 
            // btn_openPort
            // 
            this.btn_openPort.Location = new System.Drawing.Point(15, 228);
            this.btn_openPort.Name = "btn_openPort";
            this.btn_openPort.Size = new System.Drawing.Size(95, 23);
            this.btn_openPort.TabIndex = 4;
            this.btn_openPort.Text = "Open Port";
            this.btn_openPort.UseVisualStyleBackColor = true;
            this.btn_openPort.Click += new System.EventHandler(this.btn_openPort_Click);
            // 
            // btn_closePort
            // 
            this.btn_closePort.Location = new System.Drawing.Point(148, 228);
            this.btn_closePort.Name = "btn_closePort";
            this.btn_closePort.Size = new System.Drawing.Size(95, 23);
            this.btn_closePort.TabIndex = 4;
            this.btn_closePort.Text = "Close Port";
            this.btn_closePort.UseVisualStyleBackColor = true;
            this.btn_closePort.Click += new System.EventHandler(this.btn_closePort_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_closePort);
            this.groupBox1.Controls.Add(this.btn_openPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_receivePort);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmb_baudRate);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(28, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 268);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // txt_receive
            // 
            this.txt_receive.Location = new System.Drawing.Point(292, 42);
            this.txt_receive.Multiline = true;
            this.txt_receive.Name = "txt_receive";
            this.txt_receive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_receive.Size = new System.Drawing.Size(325, 262);
            this.txt_receive.TabIndex = 6;
            this.txt_receive.TextChanged += new System.EventHandler(this.txt_receive_TextChanged);
            // 
            // txt_send
            // 
            this.txt_send.Location = new System.Drawing.Point(28, 310);
            this.txt_send.Multiline = true;
            this.txt_send.Name = "txt_send";
            this.txt_send.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_send.Size = new System.Drawing.Size(480, 38);
            this.txt_send.TabIndex = 6;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(524, 311);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(93, 37);
            this.btn_send.TabIndex = 7;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Receive Port";
            // 
            // cmb_receivePort
            // 
            this.cmb_receivePort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_receivePort.FormattingEnabled = true;
            this.cmb_receivePort.Location = new System.Drawing.Point(104, 61);
            this.cmb_receivePort.Name = "cmb_receivePort";
            this.cmb_receivePort.Size = new System.Drawing.Size(139, 20);
            this.cmb_receivePort.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 387);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_send);
            this.Controls.Add(this.txt_receive);
            this.Controls.Add(this.cmb_sendPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Serial Port Communicate";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_sendPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_baudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radio_sendValue;
        private System.Windows.Forms.RadioButton radio_sendChar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radio_receiveValue;
        private System.Windows.Forms.RadioButton radio_receiveChar;
        private System.Windows.Forms.Button btn_openPort;
        private System.Windows.Forms.Button btn_closePort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_receive;
        private System.Windows.Forms.TextBox txt_send;
        private System.Windows.Forms.Button btn_send;
        private System.IO.Ports.SerialPort serPort_send;
        private System.Windows.Forms.ComboBox cmb_receivePort;
        private System.Windows.Forms.Label label5;
        private System.IO.Ports.SerialPort serPort_receive;
    }
}

