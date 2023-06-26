namespace WaveformDrawer
{
    partial class frmSetting
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
            this.cmb_serialPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_drawingStep = new System.Windows.Forms.ComboBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial Port";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_serialPort
            // 
            this.cmb_serialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_serialPort.FormattingEnabled = true;
            this.cmb_serialPort.Location = new System.Drawing.Point(112, 14);
            this.cmb_serialPort.Name = "cmb_serialPort";
            this.cmb_serialPort.Size = new System.Drawing.Size(91, 20);
            this.cmb_serialPort.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Drawing Step";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_drawingStep
            // 
            this.cmb_drawingStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_drawingStep.FormattingEnabled = true;
            this.cmb_drawingStep.Location = new System.Drawing.Point(112, 44);
            this.cmb_drawingStep.Name = "cmb_drawingStep";
            this.cmb_drawingStep.Size = new System.Drawing.Size(91, 20);
            this.cmb_drawingStep.TabIndex = 1;
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(15, 73);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(188, 23);
            this.btn_apply.TabIndex = 2;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 109);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.cmb_drawingStep);
            this.Controls.Add(this.cmb_serialPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSetting";
            this.Text = "Setting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSetting_FormClosed);
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_serialPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_drawingStep;
        private System.Windows.Forms.Button btn_apply;
        private System.IO.Ports.SerialPort serialPort1;
    }
}