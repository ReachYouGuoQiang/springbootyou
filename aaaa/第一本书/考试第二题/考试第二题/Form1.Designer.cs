namespace 考试第二题
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tetNum1 = new System.Windows.Forms.TextBox();
            this.tetNum2 = new System.Windows.Forms.TextBox();
            this.cbosuan = new System.Windows.Forms.ComboBox();
            this.BtnSuan = new System.Windows.Forms.Button();
            this.lblSuan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tetNum1
            // 
            this.tetNum1.Location = new System.Drawing.Point(42, 151);
            this.tetNum1.Name = "tetNum1";
            this.tetNum1.Size = new System.Drawing.Size(81, 25);
            this.tetNum1.TabIndex = 0;
            // 
            // tetNum2
            // 
            this.tetNum2.Location = new System.Drawing.Point(199, 153);
            this.tetNum2.Name = "tetNum2";
            this.tetNum2.Size = new System.Drawing.Size(66, 25);
            this.tetNum2.TabIndex = 2;
            // 
            // cbosuan
            // 
            this.cbosuan.FormattingEnabled = true;
            this.cbosuan.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbosuan.Location = new System.Drawing.Point(140, 153);
            this.cbosuan.Name = "cbosuan";
            this.cbosuan.Size = new System.Drawing.Size(37, 23);
            this.cbosuan.TabIndex = 3;
            // 
            // BtnSuan
            // 
            this.BtnSuan.Location = new System.Drawing.Point(284, 153);
            this.BtnSuan.Name = "BtnSuan";
            this.BtnSuan.Size = new System.Drawing.Size(75, 23);
            this.BtnSuan.TabIndex = 4;
            this.BtnSuan.Text = "计算";
            this.BtnSuan.UseVisualStyleBackColor = true;
            this.BtnSuan.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSuan
            // 
            this.lblSuan.AutoSize = true;
            this.lblSuan.Location = new System.Drawing.Point(137, 246);
            this.lblSuan.Name = "lblSuan";
            this.lblSuan.Size = new System.Drawing.Size(55, 15);
            this.lblSuan.TabIndex = 5;
            this.lblSuan.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "计算结果";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 447);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSuan);
            this.Controls.Add(this.BtnSuan);
            this.Controls.Add(this.cbosuan);
            this.Controls.Add(this.tetNum2);
            this.Controls.Add(this.tetNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tetNum1;
        private System.Windows.Forms.TextBox tetNum2;
        private System.Windows.Forms.ComboBox cbosuan;
        private System.Windows.Forms.Button BtnSuan;
        private System.Windows.Forms.Label lblSuan;
        private System.Windows.Forms.Label label2;
    }
}

