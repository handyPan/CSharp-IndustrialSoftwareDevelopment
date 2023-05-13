namespace ADCDisplay
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbar_adcResult = new System.Windows.Forms.TrackBar();
            this.lbl_adcResultValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_adcResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADC Result";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbar_adcResult
            // 
            this.tbar_adcResult.AutoSize = false;
            this.tbar_adcResult.Enabled = false;
            this.tbar_adcResult.Location = new System.Drawing.Point(84, 12);
            this.tbar_adcResult.Name = "tbar_adcResult";
            this.tbar_adcResult.Size = new System.Drawing.Size(171, 23);
            this.tbar_adcResult.TabIndex = 1;
            this.tbar_adcResult.Scroll += new System.EventHandler(this.tbar_adcResult_Scroll);
            // 
            // lbl_adcResultValue
            // 
            this.lbl_adcResultValue.Location = new System.Drawing.Point(261, 12);
            this.lbl_adcResultValue.Name = "lbl_adcResultValue";
            this.lbl_adcResultValue.Size = new System.Drawing.Size(66, 23);
            this.lbl_adcResultValue.TabIndex = 0;
            this.lbl_adcResultValue.Text = "ADC Result";
            this.lbl_adcResultValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 51);
            this.Controls.Add(this.tbar_adcResult);
            this.Controls.Add(this.lbl_adcResultValue);
            this.Controls.Add(this.label1);
            this.Name = "frmDebug";
            this.Text = "frmDebug";
            this.Load += new System.EventHandler(this.frmDebug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbar_adcResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbar_adcResult;
        private System.Windows.Forms.Label lbl_adcResultValue;
    }
}