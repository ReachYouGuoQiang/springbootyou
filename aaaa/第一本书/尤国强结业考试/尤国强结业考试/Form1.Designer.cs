namespace 尤国强结业考试
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
            this.components = new System.ComponentModel.Container();
            this.Lvshow = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Names = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打招呼ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lvshow
            // 
            this.Lvshow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Names,
            this.Age,
            this.Sex});
            this.Lvshow.ContextMenuStrip = this.contextMenuStrip1;
            this.Lvshow.FullRowSelect = true;
            this.Lvshow.GridLines = true;
            this.Lvshow.Location = new System.Drawing.Point(12, 12);
            this.Lvshow.MultiSelect = false;
            this.Lvshow.Name = "Lvshow";
            this.Lvshow.Size = new System.Drawing.Size(691, 592);
            this.Lvshow.TabIndex = 0;
            this.Lvshow.UseCompatibleStateImageBehavior = false;
            this.Lvshow.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "工号";
            this.ID.Width = 153;
            // 
            // Names
            // 
            this.Names.Text = "姓名";
            this.Names.Width = 167;
            // 
            // Age
            // 
            this.Age.Text = "年龄";
            this.Age.Width = 186;
            // 
            // Sex
            // 
            this.Sex.Text = "性别";
            this.Sex.Width = 174;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打招呼ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 50);
            // 
            // 打招呼ToolStripMenuItem
            // 
            this.打招呼ToolStripMenuItem.Name = "打招呼ToolStripMenuItem";
            this.打招呼ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.打招呼ToolStripMenuItem.Text = "打招呼";
            this.打招呼ToolStripMenuItem.Click += new System.EventHandler(this.打招呼ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 616);
            this.Controls.Add(this.Lvshow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Lvshow;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Names;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.ColumnHeader Sex;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 打招呼ToolStripMenuItem;
    }
}

