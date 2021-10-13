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

namespace 城市作业10遍
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("Student.xml");
            XmlNode XmlRoot = xml.DocumentElement;
            string countName = XmlRoot.Attributes["name"].Value;
            TreeNode treeRoot = new TreeNode(countName);
            foreach (XmlNode shengnode in xml.ChildNodes)
            {
                string shengname = shengnode.Attributes["name"].Value;
                TreeNode treepro = new TreeNode(shengname);
                foreach (XmlNode shinode in xml.ChildNodes)
                {
                    string shiname = shinode.InnerText;
                    TreeNode shipro = new TreeNode(shiname);
                    treepro.Nodes.Add(shipro);
                }
                treeRoot.Nodes.Add(treepro);
            }
            this.trShow.Nodes.Add(treeRoot);
        }
    }
}
