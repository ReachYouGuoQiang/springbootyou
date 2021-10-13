using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region 窗体的加载事件
        private void Form1_Load(object sender, EventArgs e)
        {
            //加载xml文件
            XmlDocument xml = new XmlDocument();
            xml.Load("ChengShi.xml");
            //获取根节点
            XmlNode XmlRoot = xml.DocumentElement;
            string countryName = XmlRoot.Attributes["name"].Value;
            //生成TreeView节点
            TreeNode treeRoot = new TreeNode(countryName);
            //把TreeNode放入TreeView中
            foreach (XmlNode shengnode in xml.ChildNodes)
            {
                //获取省节点的name属性
                string proName = shengnode.Attributes["name"].Value;
                //生成TreeView里的省节点
                TreeNode treepro = new TreeNode(proName);
                foreach (XmlNode shinode in shengnode.ChildNodes)
                {
                    //获取市节点里的内容
                    string shiname = shinode.InnerText;
                    TreeNode shi = new TreeNode(shiname);
                    //添加到省里节点
                    treepro.Nodes.Add(shi);
                }
                //把生成的省节点放入上面生成的国家节点里
                treeRoot.Nodes.Add(treepro);
            }
            this.trshow.Nodes.Add(treeRoot);
            //展开
            this.trshow.ExpandAll();
        }
        #endregion

        #region 添加根节点
        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.tetNode.Text;
            TreeNode node = new TreeNode(name);
            this.trshow.Nodes.Add(node);
            //判断文本框是否有值
            if (this.tetNode.Text != null)
            {
                this.tetNode.Clear();
            }
        }
        #endregion

        #region 添加子节点
        private void button2_Click(object sender, EventArgs e)
        {
            string name = this.tetNode.Text;
            TreeNode node = new TreeNode(name);
            //SelectedNode选择的节点
            this.trshow.SelectedNode.Nodes.Add(node);
            if (this.tetNode.Text != null)
            {
                this.tetNode.Clear();
            }
        }
        #endregion

        #region 删除的点击事件
        private void 删除记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.trshow.SelectedNode.Remove();
        }
        #endregion

        #region 清空的点击事件
        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.trshow.SelectedNode.Nodes.Clear();
        }
        #endregion
    }
}
