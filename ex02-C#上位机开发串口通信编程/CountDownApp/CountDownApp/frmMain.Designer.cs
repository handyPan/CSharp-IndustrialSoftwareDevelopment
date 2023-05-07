namespace CountDownApp
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
            this.cmb_specifiedTime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_remainingTime = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.progBar_completedTime = new System.Windows.Forms.ProgressBar();
            this.tmr_interval = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Specified";
            // 
            // cmb_specifiedTime
            // 
            this.cmb_specifiedTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_specifiedTime.FormattingEnabled = true;
            this.cmb_specifiedTime.Location = new System.Drawing.Point(121, 39);
            this.cmb_specifiedTime.Name = "cmb_specifiedTime";
            this.cmb_specifiedTime.Size = new System.Drawing.Size(121, 20);
            this.cmb_specifiedTime.TabIndex = 1;
            this.cmb_specifiedTime.DropDownClosed += new System.EventHandler(this.cmb_specifiedTime_DropDownClosed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Remaining";
            // 
            // lbl_remainingTime
            // 
            this.lbl_remainingTime.AutoSize = true;
            this.lbl_remainingTime.Location = new System.Drawing.Point(119, 85);
            this.lbl_remainingTime.Name = "lbl_remainingTime";
            this.lbl_remainingTime.Size = new System.Drawing.Size(41, 12);
            this.lbl_remainingTime.TabIndex = 0;
            this.lbl_remainingTime.Text = "0 secs";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(299, 35);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // progBar_completedTime
            // 
            this.progBar_completedTime.Location = new System.Drawing.Point(32, 133);
            this.progBar_completedTime.Name = "progBar_completedTime";
            this.progBar_completedTime.Size = new System.Drawing.Size(342, 23);
            this.progBar_completedTime.TabIndex = 3;
            // 
            // tmr_interval
            // 
            this.tmr_interval.Interval = 1000;
            this.tmr_interval.Tick += new System.EventHandler(this.tmr_interval_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 195);
            this.Controls.Add(this.progBar_completedTime);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.cmb_specifiedTime);
            this.Controls.Add(this.lbl_remainingTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Count Down App";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_specifiedTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_remainingTime;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.ProgressBar progBar_completedTime;
        private System.Windows.Forms.Timer tmr_interval;
    }
}

