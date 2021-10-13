namespace 计算机
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
            this.tetnum2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cboop = new System.Windows.Forms.ComboBox();
            this.lblshow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tetNum1
            // 
            this.tetNum1.Location = new System.Drawing.Point(12, 153);
            this.tetNum1.Name = "tetNum1";
            this.tetNum1.Size = new System.Drawing.Size(100, 25);
            this.tetNum1.TabIndex = 0;
            // 
            // tetnum2
            // 
            this.tetnum2.Location = new System.Drawing.Point(199, 153);
            this.tetnum2.Name = "tetnum2";
            this.tetnum2.Size = new System.Drawing.Size(100, 25);
            this.tetnum2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboop
            // 
            this.cboop.FormattingEnabled = true;
            this.cboop.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cboop.Location = new System.Drawing.Point(129, 154);
            this.cboop.Name = "cboop";
            this.cboop.Size = new System.Drawing.Size(51, 23);
            this.cboop.TabIndex = 3;
            // 
            // lblshow
            // 
            this.lblshow.AutoSize = true;
            this.lblshow.Location = new System.Drawing.Point(129, 259);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(55, 15);
            this.lblshow.TabIndex = 4;
            this.lblshow.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 393);
            this.Controls.Add(this.lblshow);
            this.Controls.Add(this.cboop);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tetnum2);
            this.Controls.Add(this.tetNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tetNum1;
        private System.Windows.Forms.TextBox tetnum2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboop;
        private System.Windows.Forms.Label lblshow;
    }
}

