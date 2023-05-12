namespace SendDataWithValidation
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
            this.btn_turnOnOffSerialPort = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_receivePort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_device1SendValidate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_device1Status = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_device2Status = new System.Windows.Forms.Label();
            this.btn_device2SendValidate = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_device3Status = new System.Windows.Forms.Label();
            this.btn_device3SendValidate = new System.Windows.Forms.Button();
            this.serPort_send = new System.IO.Ports.SerialPort(this.components);
            this.serPort_receive = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Send";
            // 
            // cmb_sendPort
            // 
            this.cmb_sendPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sendPort.FormattingEnabled = true;
            this.cmb_sendPort.Location = new System.Drawing.Point(61, 26);
            this.cmb_sendPort.Name = "cmb_sendPort";
            this.cmb_sendPort.Size = new System.Drawing.Size(64, 20);
            this.cmb_sendPort.TabIndex = 1;
            // 
            // btn_turnOnOffSerialPort
            // 
            this.btn_turnOnOffSerialPort.Location = new System.Drawing.Point(313, 43);
            this.btn_turnOnOffSerialPort.Name = "btn_turnOnOffSerialPort";
            this.btn_turnOnOffSerialPort.Size = new System.Drawing.Size(75, 23);
            this.btn_turnOnOffSerialPort.TabIndex = 2;
            this.btn_turnOnOffSerialPort.Text = "Turn ON";
            this.btn_turnOnOffSerialPort.UseVisualStyleBackColor = true;
            this.btn_turnOnOffSerialPort.Click += new System.EventHandler(this.btn_turnOnOffSerialPort_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_receivePort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_sendPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 66);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port Configuration";
            // 
            // cmb_receivePort
            // 
            this.cmb_receivePort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_receivePort.FormattingEnabled = true;
            this.cmb_receivePort.Location = new System.Drawing.Point(198, 26);
            this.cmb_receivePort.Name = "cmb_receivePort";
            this.cmb_receivePort.Size = new System.Drawing.Size(64, 20);
            this.cmb_receivePort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Receive";
            // 
            // btn_device1SendValidate
            // 
            this.btn_device1SendValidate.Location = new System.Drawing.Point(28, 26);
            this.btn_device1SendValidate.Name = "btn_device1SendValidate";
            this.btn_device1SendValidate.Size = new System.Drawing.Size(282, 23);
            this.btn_device1SendValidate.TabIndex = 2;
            this.btn_device1SendValidate.Tag = "1";
            this.btn_device1SendValidate.Text = "Send Data and Validate";
            this.btn_device1SendValidate.UseVisualStyleBackColor = true;
            this.btn_device1SendValidate.Click += new System.EventHandler(this.btn_deviceSendValidate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_device1Status);
            this.groupBox2.Controls.Add(this.btn_device1SendValidate);
            this.groupBox2.Location = new System.Drawing.Point(36, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 66);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Device 1";
            // 
            // lbl_device1Status
            // 
            this.lbl_device1Status.Location = new System.Drawing.Point(328, 26);
            this.lbl_device1Status.Name = "lbl_device1Status";
            this.lbl_device1Status.Size = new System.Drawing.Size(24, 24);
            this.lbl_device1Status.TabIndex = 3;
            this.lbl_device1Status.Text = "label2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_device2Status);
            this.groupBox3.Controls.Add(this.btn_device2SendValidate);
            this.groupBox3.Location = new System.Drawing.Point(36, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 66);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Device 2";
            // 
            // lbl_device2Status
            // 
            this.lbl_device2Status.Location = new System.Drawing.Point(328, 26);
            this.lbl_device2Status.Name = "lbl_device2Status";
            this.lbl_device2Status.Size = new System.Drawing.Size(24, 24);
            this.lbl_device2Status.TabIndex = 3;
            this.lbl_device2Status.Text = "label3";
            // 
            // btn_device2SendValidate
            // 
            this.btn_device2SendValidate.Location = new System.Drawing.Point(28, 26);
            this.btn_device2SendValidate.Name = "btn_device2SendValidate";
            this.btn_device2SendValidate.Size = new System.Drawing.Size(282, 23);
            this.btn_device2SendValidate.TabIndex = 2;
            this.btn_device2SendValidate.Tag = "2";
            this.btn_device2SendValidate.Text = "Send Data and Validate";
            this.btn_device2SendValidate.UseVisualStyleBackColor = true;
            this.btn_device2SendValidate.Click += new System.EventHandler(this.btn_deviceSendValidate_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_device3Status);
            this.groupBox4.Controls.Add(this.btn_device3SendValidate);
            this.groupBox4.Location = new System.Drawing.Point(36, 282);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(378, 66);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Device 3";
            // 
            // lbl_device3Status
            // 
            this.lbl_device3Status.Location = new System.Drawing.Point(328, 26);
            this.lbl_device3Status.Name = "lbl_device3Status";
            this.lbl_device3Status.Size = new System.Drawing.Size(24, 24);
            this.lbl_device3Status.TabIndex = 3;
            this.lbl_device3Status.Text = "label4";
            // 
            // btn_device3SendValidate
            // 
            this.btn_device3SendValidate.Location = new System.Drawing.Point(28, 26);
            this.btn_device3SendValidate.Name = "btn_device3SendValidate";
            this.btn_device3SendValidate.Size = new System.Drawing.Size(282, 23);
            this.btn_device3SendValidate.TabIndex = 2;
            this.btn_device3SendValidate.Tag = "3";
            this.btn_device3SendValidate.Text = "Send Data and Validate";
            this.btn_device3SendValidate.UseVisualStyleBackColor = true;
            this.btn_device3SendValidate.Click += new System.EventHandler(this.btn_deviceSendValidate_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 368);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_turnOnOffSerialPort);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Send Data with Validation";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_sendPort;
        private System.Windows.Forms.Button btn_turnOnOffSerialPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_device1SendValidate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_device1Status;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_device2Status;
        private System.Windows.Forms.Button btn_device2SendValidate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_device3Status;
        private System.Windows.Forms.Button btn_device3SendValidate;
        private System.IO.Ports.SerialPort serPort_send;
        private System.IO.Ports.SerialPort serPort_receive;
        private System.Windows.Forms.ComboBox cmb_receivePort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

