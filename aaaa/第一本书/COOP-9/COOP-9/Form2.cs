using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COOP_9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TreeNode node = new TreeNode();
            node.Tag = @"E:\";
            node.Text = "E盘";
            this.TvShow.Nodes.Add(node);
        }

        public void BidTv(TreeNode node)
        {
            string path = node.Tag.ToString();
            DirectoryInfo di = new DirectoryInfo(path);
            //根据路径获取该文件夹下的全部子文件夹
            DirectoryInfo[] dis = di.GetDirectories();
            //生成Treeview子节点，放入到上面的父节点里
            this.TvShow.SelectedNode.Nodes.Clear();
            foreach (DirectoryInfo d in dis)
            {
                TreeNode n = new TreeNode();
                n.Text = d.Name;
                n.Tag = d.FullName;
                node.Nodes.Add(n);
            }

            //处理子文件
            FileInfo[] fis = di.GetFiles();
            this.lvShow.Items.Clear();
            foreach (FileInfo f in fis)
            {
                ListViewItem item = new ListViewItem(f.Name);
                item.SubItems.Add((f.Length / 1024).ToString());
                item.SubItems.Add(string.IsNullOrEmpty(f.Extension)?"":f.Extension.Substring(1));
                item.SubItems.Add(f.FullName);
                this.lvShow.Items.Add(item);
            }
        }

        private void TvShow_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //获取被点中的节点
            TreeNode node = this.TvShow.SelectedNode;
            this.BidTv(node);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lvShow.SelectedItems.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("是否删除?","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }
            File.Delete(this.lvShow.SelectedItems[0].SubItems[3].Text);
            MessageBox.Show("删除成功");
            this.BidTv(this.TvShow.SelectedNode);
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lvShow.SelectedItems.Count == 0)
            {
                return;
            }
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string source = this.lvShow.SelectedItems[0].SubItems[3].Text;
                string dest = fbd.SelectedPath + @"\" + this.lvShow.SelectedItems[0].Text;
                File.Copy(source, dest);
                MessageBox.Show("复制成功");
            }
        }


    }
}
