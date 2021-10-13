namespace MyOffice
{
    partial class FrmTest
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
            this.tetDay = new System.Windows.Forms.TextBox();
            this.tetWenTi = new System.Windows.Forms.TextBox();
            this.tetHang = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCe = new System.Windows.Forms.Label();
            this.btnTiJiao = new System.Windows.Forms.Button();
            this.BtnQuXxiao = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tetDay);
            this.groupBox1.Controls.Add(this.tetWenTi);
            this.groupBox1.Controls.Add(this.tetHang);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblCe);
            this.groupBox1.Location = new System.Drawing.Point(24, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 369);
            this.groupBox1.TabIndex = 0;
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
            this.label2.Location = new System.Drawing.Point(6, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "发现的Bug个数";
            // 
            // lblCe
            // 
            this.lblCe.AutoSize = true;
            this.lblCe.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCe.Location = new System.Drawing.Point(24, 51);
            this.lblCe.Name = "lblCe";
            this.lblCe.Size = new System.Drawing.Size(132, 27);
            this.lblCe.TabIndex = 0;
            this.lblCe.Text = "测试用例个数";
            // 
            // btnTiJiao
            // 
            this.btnTiJiao.Location = new System.Drawing.Point(87, 414);
            this.btnTiJiao.Name = "btnTiJiao";
            this.btnTiJiao.Size = new System.Drawing.Size(75, 23);
            this.btnTiJiao.TabIndex = 1;
            this.btnTiJiao.Text = "提交";
            this.btnTiJiao.UseVisualStyleBackColor = true;
            // 
            // BtnQuXxiao
            // 
            this.BtnQuXxiao.Location = new System.Drawing.Point(306, 414);
            this.BtnQuXxiao.Name = "BtnQuXxiao";
            this.BtnQuXxiao.Size = new System.Drawing.Size(75, 23);
            this.BtnQuXxiao.TabIndex = 2;
            this.BtnQuXxiao.Text = "取消";
            this.BtnQuXxiao.UseVisualStyleBackColor = true;
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 468);
            this.Controls.Add(this.BtnQuXxiao);
            this.Controls.Add(this.btnTiJiao);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTest";
            this.Text = "测试";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCe;
        private System.Windows.Forms.TextBox tetHang;
        private System.Windows.Forms.TextBox tetDay;
        private System.Windows.Forms.TextBox tetWenTi;
        private System.Windows.Forms.Button btnTiJiao;
        private System.Windows.Forms.Button BtnQuXxiao;
    }
}