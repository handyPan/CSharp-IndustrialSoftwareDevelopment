namespace EncodingConversion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_convertGb2312ToUtf8 = new System.Windows.Forms.Button();
            this.txt_utf8Dst = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_gb2312Src = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_convertUtf8ToGb2312 = new System.Windows.Forms.Button();
            this.txt_gb2312Dst = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_utf8Src = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_convertGb2312ToUtf8);
            this.groupBox1.Controls.Add(this.txt_utf8Dst);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_gb2312Src);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GB2312->UTF8";
            // 
            // btn_convertGb2312ToUtf8
            // 
            this.btn_convertGb2312ToUtf8.Location = new System.Drawing.Point(55, 238);
            this.btn_convertGb2312ToUtf8.Name = "btn_convertGb2312ToUtf8";
            this.btn_convertGb2312ToUtf8.Size = new System.Drawing.Size(298, 23);
            this.btn_convertGb2312ToUtf8.TabIndex = 2;
            this.btn_convertGb2312ToUtf8.Text = "Convert";
            this.btn_convertGb2312ToUtf8.UseVisualStyleBackColor = true;
            this.btn_convertGb2312ToUtf8.Click += new System.EventHandler(this.btn_convertGb2312ToUtf8_Click);
            // 
            // txt_utf8Dst
            // 
            this.txt_utf8Dst.Location = new System.Drawing.Point(55, 129);
            this.txt_utf8Dst.Multiline = true;
            this.txt_utf8Dst.Name = "txt_utf8Dst";
            this.txt_utf8Dst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_utf8Dst.Size = new System.Drawing.Size(298, 102);
            this.txt_utf8Dst.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "UTF8";
            // 
            // txt_gb2312Src
            // 
            this.txt_gb2312Src.Location = new System.Drawing.Point(55, 21);
            this.txt_gb2312Src.Multiline = true;
            this.txt_gb2312Src.Name = "txt_gb2312Src";
            this.txt_gb2312Src.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_gb2312Src.Size = new System.Drawing.Size(298, 102);
            this.txt_gb2312Src.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "GB2312";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_convertUtf8ToGb2312);
            this.groupBox2.Controls.Add(this.txt_gb2312Dst);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_utf8Src);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(24, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 275);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UTF8->GB2312";
            // 
            // btn_convertUtf8ToGb2312
            // 
            this.btn_convertUtf8ToGb2312.Location = new System.Drawing.Point(55, 238);
            this.btn_convertUtf8ToGb2312.Name = "btn_convertUtf8ToGb2312";
            this.btn_convertUtf8ToGb2312.Size = new System.Drawing.Size(298, 23);
            this.btn_convertUtf8ToGb2312.TabIndex = 2;
            this.btn_convertUtf8ToGb2312.Text = "Convert";
            this.btn_convertUtf8ToGb2312.UseVisualStyleBackColor = true;
            this.btn_convertUtf8ToGb2312.Click += new System.EventHandler(this.btn_convertUtf8ToGb2312_Click);
            // 
            // txt_gb2312Dst
            // 
            this.txt_gb2312Dst.Location = new System.Drawing.Point(55, 129);
            this.txt_gb2312Dst.Multiline = true;
            this.txt_gb2312Dst.Name = "txt_gb2312Dst";
            this.txt_gb2312Dst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_gb2312Dst.Size = new System.Drawing.Size(298, 102);
            this.txt_gb2312Dst.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "GB2312";
            // 
            // txt_utf8Src
            // 
            this.txt_utf8Src.Location = new System.Drawing.Point(55, 21);
            this.txt_utf8Src.Multiline = true;
            this.txt_utf8Src.Name = "txt_utf8Src";
            this.txt_utf8Src.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_utf8Src.Size = new System.Drawing.Size(298, 102);
            this.txt_utf8Src.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "UTF8";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 579);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "UTF8 and GB2312 Conversion";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_convertGb2312ToUtf8;
        private System.Windows.Forms.TextBox txt_utf8Dst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_gb2312Src;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_convertUtf8ToGb2312;
        private System.Windows.Forms.TextBox txt_gb2312Dst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_utf8Src;
        private System.Windows.Forms.Label label4;
    }
}

