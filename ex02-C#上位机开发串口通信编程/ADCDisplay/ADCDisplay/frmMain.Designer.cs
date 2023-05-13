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
            this.lbl_adcResultValue = new System.Windows.Forms.Label();
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
            this.groupBox2.Controls.Add(this.lbl_adcResultValue);
            this.groupBox2.Controls.Add(this.lbl_adcResultMax);
            this.groupBox2.Controls.Add(this.lbl_adcResultMin);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(13, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 63);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ADC Result";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 26);
            this.progressBar1.Maximum = 255;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(311, 13);
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
            this.lbl_adcResultMin.Location = new System.Drawing.Point(6, 41);
            this.lbl_adcResultMin.Name = "lbl_adcResultMin";
            this.lbl_adcResultMin.Size = new System.Drawing.Size(13, 15);
            this.lbl_adcResultMin.TabIndex = 1;
            this.lbl_adcResultMin.Text = "0";
            this.lbl_adcResultMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_adcResultMax
            // 
            this.lbl_adcResultMax.Location = new System.Drawing.Point(293, 41);
            this.lbl_adcResultMax.Name = "lbl_adcResultMax";
            this.lbl_adcResultMax.Size = new System.Drawing.Size(23, 15);
            this.lbl_adcResultMax.TabIndex = 1;
            this.lbl_adcResultMax.Text = "255";
            this.lbl_adcResultMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_adcResultValue
            // 
            this.lbl_adcResultValue.Location = new System.Drawing.Point(198, 41);
            this.lbl_adcResultValue.Name = "lbl_adcResultValue";
            this.lbl_adcResultValue.Size = new System.Drawing.Size(23, 15);
            this.lbl_adcResultValue.TabIndex = 1;
            this.lbl_adcResultValue.Text = "255";
            this.lbl_adcResultValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 178);
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
        private System.Windows.Forms.Label lbl_adcResultValue;
        private System.Windows.Forms.Label lbl_adcResultMax;
        private System.Windows.Forms.Label lbl_adcResultMin;
    }
}

