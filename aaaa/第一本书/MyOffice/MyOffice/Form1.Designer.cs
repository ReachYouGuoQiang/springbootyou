namespace MyOffice
{
    partial class frmshow
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
            this.lvSHow = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Names = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PingJia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvSHow
            // 
            this.lvSHow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Names,
            this.Age,
            this.PingJia,
            this.Count});
            this.lvSHow.FullRowSelect = true;
            this.lvSHow.GridLines = true;
            this.lvSHow.Location = new System.Drawing.Point(12, 12);
            this.lvSHow.MultiSelect = false;
            this.lvSHow.Name = "lvSHow";
            this.lvSHow.Size = new System.Drawing.Size(755, 402);
            this.lvSHow.TabIndex = 0;
            this.lvSHow.UseCompatibleStateImageBehavior = false;
            this.lvSHow.View = System.Windows.Forms.View.Details;
            this.lvSHow.DoubleClick += new System.EventHandler(this.lvSHow_DoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "工号";
            this.ID.Width = 150;
            // 
            // Names
            // 
            this.Names.Text = "姓名";
            this.Names.Width = 150;
            // 
            // Age
            // 
            this.Age.Text = "年龄";
            this.Age.Width = 150;
            // 
            // PingJia
            // 
            this.PingJia.Text = "评价";
            this.PingJia.Width = 150;
            // 
            // Count
            // 
            this.Count.Text = "年度评分";
            this.Count.Width = 150;
            // 
            // frmshow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 426);
            this.Controls.Add(this.lvSHow);
            this.Name = "frmshow";
            this.Text = "查看评分";
            this.Load += new System.EventHandler(this.FrmShow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvSHow;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Names;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.ColumnHeader PingJia;
        private System.Windows.Forms.ColumnHeader Count;
    }
}

