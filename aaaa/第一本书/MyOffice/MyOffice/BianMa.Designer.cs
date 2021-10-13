namespace MyOffice
{
    partial class FrmCade
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
            this.BtnQuXxiao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tetDay = new System.Windows.Forms.TextBox();
            this.tetWenTi = new System.Windows.Forms.TextBox();
            this.tetHang = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTiJiao = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnQuXxiao
            // 
            this.BtnQuXxiao.Location = new System.Drawing.Point(316, 422);
            this.BtnQuXxiao.Name = "BtnQuXxiao";
            this.BtnQuXxiao.Size = new System.Drawing.Size(75, 23);
            this.BtnQuXxiao.TabIndex = 5;
            this.BtnQuXxiao.Text = "取消";
            this.BtnQuXxiao.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tetDay);
            this.groupBox1.Controls.Add(this.tetWenTi);
            this.groupBox1.Controls.Add(this.tetHang);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(34, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 369);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "填写工作指标";
            // 
            // tetDay
            // 
            this.tetDay.Location = new System.Drawing.Point(186, 263);
            this.tetDay.Name = "tetDay";
            this.tetDay.Size = new System.Drawing.Size(171, 25);
            this.tetDay.TabIndex = 5;
            // 
            // tetWenTi
            // 
            this.tetWenTi.Location = new System.Drawing.Point(186, 157);
            this.tetWenTi.Name = "tetWenTi";
            this.tetWenTi.Size = new System.Drawing.Size(171, 25);
            this.tetWenTi.TabIndex = 4;
            // 
            // tetHang
            // 
            this.tetHang.Location = new System.Drawing.Point(186, 52);
            this.tetHang.Name = "tetHang";
            this.tetHang.Size = new System.Drawing.Size(171, 25);
            this.tetHang.TabIndex = 3;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl.Location = new System.Drawing.Point(26, 263);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(112, 27);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "所需工作日";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(46, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "遗留问题";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "有效编码行数";
            // 
            // btnTiJiao
            // 
            this.btnTiJiao.Location = new System.Drawing.Point(97, 422);
            this.btnTiJiao.Name = "btnTiJiao";
            this.btnTiJiao.Size = new System.Drawing.Size(75, 23);
            this.btnTiJiao.TabIndex = 4;
            this.btnTiJiao.Text = "提交";
            this.btnTiJiao.UseVisualStyleBackColor = true;
            this.btnTiJiao.Click += new System.EventHandler(this.btnTiJiao_Click);
            // 
            // FrmCade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 478);
            this.Controls.Add(this.BtnQuXxiao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTiJiao);
            this.Name = "FrmCade";
            this.Text = "编码";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnQuXxiao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tetDay;
        private System.Windows.Forms.TextBox tetWenTi;
        private System.Windows.Forms.TextBox tetHang;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTiJiao;

    }
}