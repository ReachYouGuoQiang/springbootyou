namespace _11._16上午车辆管理
{
    partial class insert
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tetId = new System.Windows.Forms.TextBox();
            this.tetNames = new System.Windows.Forms.TextBox();
            this.tetPrice = new System.Windows.Forms.TextBox();
            this.cboYongTu = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "车牌号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "车辆名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "用途";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "价格";
            // 
            // tetId
            // 
            this.tetId.Location = new System.Drawing.Point(187, 57);
            this.tetId.Name = "tetId";
            this.tetId.Size = new System.Drawing.Size(156, 25);
            this.tetId.TabIndex = 4;
            // 
            // tetNames
            // 
            this.tetNames.Location = new System.Drawing.Point(187, 134);
            this.tetNames.Name = "tetNames";
            this.tetNames.Size = new System.Drawing.Size(156, 25);
            this.tetNames.TabIndex = 5;
            // 
            // tetPrice
            // 
            this.tetPrice.Location = new System.Drawing.Point(187, 288);
            this.tetPrice.Name = "tetPrice";
            this.tetPrice.Size = new System.Drawing.Size(156, 25);
            this.tetPrice.TabIndex = 6;
            // 
            // cboYongTu
            // 
            this.cboYongTu.FormattingEnabled = true;
            this.cboYongTu.Items.AddRange(new object[] {
            "客车",
            "货车"});
            this.cboYongTu.Location = new System.Drawing.Point(187, 211);
            this.cboYongTu.Name = "cboYongTu";
            this.cboYongTu.Size = new System.Drawing.Size(156, 23);
            this.cboYongTu.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 408);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboYongTu);
            this.Controls.Add(this.tetPrice);
            this.Controls.Add(this.tetNames);
            this.Controls.Add(this.tetId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "insert";
            this.Text = "insert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tetId;
        private System.Windows.Forms.TextBox tetNames;
        private System.Windows.Forms.TextBox tetPrice;
        private System.Windows.Forms.ComboBox cboYongTu;
        private System.Windows.Forms.Button button1;
    }
}