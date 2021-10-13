namespace _2020._12._07_test
{
    partial class FrmMain
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
            this.lvShowEmployee = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSayHi = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvShowEmployee
            // 
            this.lvShowEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvShowEmployee.ContextMenuStrip = this.ctmsMenu;
            this.lvShowEmployee.FullRowSelect = true;
            this.lvShowEmployee.Location = new System.Drawing.Point(12, 12);
            this.lvShowEmployee.MultiSelect = false;
            this.lvShowEmployee.Name = "lvShowEmployee";
            this.lvShowEmployee.Size = new System.Drawing.Size(428, 349);
            this.lvShowEmployee.TabIndex = 1;
            this.lvShowEmployee.UseCompatibleStateImageBehavior = false;
            this.lvShowEmployee.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "工号";
            this.columnHeader1.Width = 95;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "姓名";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "年龄";
            this.columnHeader3.Width = 104;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "性别";
            this.columnHeader4.Width = 112;
            // 
            // ctmsMenu
            // 
            this.ctmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSayHi});
            this.ctmsMenu.Name = "ctmsMenu";
            this.ctmsMenu.Size = new System.Drawing.Size(113, 26);
            // 
            // tsmiSayHi
            // 
            this.tsmiSayHi.Name = "tsmiSayHi";
            this.tsmiSayHi.Size = new System.Drawing.Size(112, 22);
            this.tsmiSayHi.Text = "打招呼";
            this.tsmiSayHi.Click += new System.EventHandler(this.tsmiSayHi_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 373);
            this.Controls.Add(this.lvShowEmployee);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ctmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvShowEmployee;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip ctmsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiSayHi;
    }
}

