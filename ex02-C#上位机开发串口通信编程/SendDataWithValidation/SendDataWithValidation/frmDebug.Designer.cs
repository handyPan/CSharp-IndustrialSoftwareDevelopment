namespace SendDataWithValidation
{
    partial class frmDebug
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
            this.txt_receiveSendRecords = new System.Windows.Forms.TextBox();
            this.cmb_replyCode = new System.Windows.Forms.ComboBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_sendPort = new System.Windows.Forms.Label();
            this.lbl_receivePort = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_device3Status = new System.Windows.Forms.Label();
            this.lbl_device2Status = new System.Windows.Forms.Label();
            this.lbl_device1Status = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serPort_send = new System.IO.Ports.SerialPort(this.components);
            this.serPort_receive = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_receiveSendRecords
            // 
            this.txt_receiveSendRecords.Location = new System.Drawing.Point(14, 44);
            this.txt_receiveSendRecords.Multiline = true;
            this.txt_receiveSendRecords.Name = "txt_receiveSendRecords";
            this.txt_receiveSendRecords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_receiveSendRecords.Size = new System.Drawing.Size(320, 129);
            this.txt_receiveSendRecords.TabIndex = 0;
            // 
            // cmb_replyCode
            // 
            this.cmb_replyCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_replyCode.FormattingEnabled = true;
            this.cmb_replyCode.Items.AddRange(new object[] {
            "0x01 - Device 1 ON",
            "0x11 - Device 1 OFF",
            "0x02 - Device 2 ON",
            "0x12 - Device 2 OFF",
            "0x03 - Device 3 ON",
            "0x13 - Device 3 OFF",
            "0x04 - All Devices ON",
            "0x14 - All Devices OFF"});
            this.cmb_replyCode.Location = new System.Drawing.Point(14, 23);
            this.cmb_replyCode.Name = "cmb_replyCode";
            this.cmb_replyCode.Size = new System.Drawing.Size(226, 20);
            this.cmb_replyCode.TabIndex = 2;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(259, 20);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 3;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbl_sendPort);
            this.groupBox1.Controls.Add(this.lbl_receivePort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_receiveSendRecords);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 190);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Received/Sent Data";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(157, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Send Port:";
            // 
            // lbl_sendPort
            // 
            this.lbl_sendPort.Location = new System.Drawing.Point(231, 21);
            this.lbl_sendPort.Name = "lbl_sendPort";
            this.lbl_sendPort.Size = new System.Drawing.Size(55, 20);
            this.lbl_sendPort.TabIndex = 1;
            this.lbl_sendPort.Text = "Port";
            // 
            // lbl_receivePort
            // 
            this.lbl_receivePort.Location = new System.Drawing.Point(103, 21);
            this.lbl_receivePort.Name = "lbl_receivePort";
            this.lbl_receivePort.Size = new System.Drawing.Size(55, 20);
            this.lbl_receivePort.TabIndex = 1;
            this.lbl_receivePort.Text = "Port";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Receive Port:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_send);
            this.groupBox2.Controls.Add(this.cmb_replyCode);
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 57);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reply Code";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_device3Status);
            this.groupBox3.Controls.Add(this.lbl_device2Status);
            this.groupBox3.Controls.Add(this.lbl_device1Status);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 60);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Device Status";
            // 
            // lbl_device3Status
            // 
            this.lbl_device3Status.Location = new System.Drawing.Point(311, 22);
            this.lbl_device3Status.Name = "lbl_device3Status";
            this.lbl_device3Status.Size = new System.Drawing.Size(24, 24);
            this.lbl_device3Status.TabIndex = 0;
            this.lbl_device3Status.Text = "Device 1";
            // 
            // lbl_device2Status
            // 
            this.lbl_device2Status.Location = new System.Drawing.Point(194, 22);
            this.lbl_device2Status.Name = "lbl_device2Status";
            this.lbl_device2Status.Size = new System.Drawing.Size(24, 24);
            this.lbl_device2Status.TabIndex = 0;
            this.lbl_device2Status.Text = "Device 1";
            // 
            // lbl_device1Status
            // 
            this.lbl_device1Status.Location = new System.Drawing.Point(71, 22);
            this.lbl_device1Status.Name = "lbl_device1Status";
            this.lbl_device1Status.Size = new System.Drawing.Size(24, 24);
            this.lbl_device1Status.TabIndex = 0;
            this.lbl_device1Status.Text = "Device 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Device 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Device 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device 1";
            // 
            // frmDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 370);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmDebug";
            this.Text = "frmDebug";
            this.Load += new System.EventHandler(this.frmDebug_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_receiveSendRecords;
        private System.Windows.Forms.ComboBox cmb_replyCode;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_device3Status;
        private System.Windows.Forms.Label lbl_device2Status;
        private System.Windows.Forms.Label lbl_device1Status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serPort_send;
        private System.IO.Ports.SerialPort serPort_receive;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_sendPort;
        private System.Windows.Forms.Label lbl_receivePort;
        private System.Windows.Forms.Label label2;
    }
}