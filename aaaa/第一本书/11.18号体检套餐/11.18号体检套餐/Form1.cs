using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._18号体检套餐
{
    public partial class Form1 : Form
    {
        //定义几个检查项目
        HealthCheckItem height, weight, sight, hearing, liverFun, ekg, bWaves, bloodPressure, bloodTest;
        //定义一个系统默认检查套餐"入学套餐"
        HealthCheckSet setA;
        //保存所有套餐中的项目
        List<HealthCheckItem> Allitems = new List<HealthCheckItem>();
        //保存套餐中的体验项目
        List<HealthCheckItem> items = new List<HealthCheckItem>();
        //使用字典保存套餐集合
        public Dictionary<string, HealthCheckSet> HealthSet = new Dictionary<string, HealthCheckSet>();
        public Form1()
        {
            InitializeComponent();
        }

        #region 初始化项目
        private void InItItems()
        {
            HealthCheckItem choice = new HealthCheckItem("请选择",-1,"请选择");
            height = new HealthCheckItem("身高", 5, "检验身高");
            weight = new HealthCheckItem("体重", 5, "检验体重");
            sight = new HealthCheckItem("视力", 5, "检验视力");
            hearing = new HealthCheckItem("听力", 5, "用于检查听力");
            liverFun = new HealthCheckItem("肝功能", 5, "用于检查肝功能");
            bWaves = new HealthCheckItem("B超", 5, "用于检查B超");
            ekg = new HealthCheckItem("心电图", 5, "用于检查心电图");
            bloodPressure = new HealthCheckItem("血压", 5, "用于检查血压");
            bloodTest = new HealthCheckItem("血常规", 5, "用于检查血常规");
            Allitems.Add(choice);
            Allitems.Add(height);
            Allitems.Add(weight);
            Allitems.Add(sight);
            Allitems.Add(hearing);
            Allitems.Add(liverFun);
            Allitems.Add(height);
            Allitems.Add(bWaves);
            Allitems.Add(ekg);
            Allitems.Add(bloodPressure);
            Allitems.Add(bloodTest);
            //绑定下拉框的数据                                                                          (将东西全部丢进这里)
            this.cboItem.DataSource = new BindingList<HealthCheckItem>(Allitems);
            //展示给用户看的数据
            this.cboItem.DisplayMember = "ItemName";
        }
        #endregion

        #region 窗体的加载事件
        private void Form1_Load(object sender, EventArgs e)
        {
            this.lblName.Text = "";
            this.lblPrice.Text = "";
            this.btnAddItem.Enabled = false;
            this.btnDelete.Enabled = false;
            //初始化数据并且绑定到cboitems里
            InItItems();
            //生成一个套餐的对象
            InitSets();
            //插入一个请选择
            InitHealthSetList();
        }
        #endregion

        #region 生成一个套餐对象学生
        private void InitSets()
        {
            //创建一个对象用来存套餐里的项目
            items = new List<HealthCheckItem>();
            items.Add(height);
            items.Add(weight);
            items.Add(sight);
            //将入学套餐加入
            setA = new HealthCheckSet(items,"入学检验");
            setA.CalPrice();

            this.HealthSet.Add("入学检验", setA);
        }
        #endregion

        #region 插入请选择的代码
        private void InitHealthSetList()
        {
            this.cboList.Items.Clear();
            this.cboList.Items.Add("请选择");
            foreach (string key in this.HealthSet.Keys)
            {
                this.cboList.Items.Add(key);
            }
            this.cboList.SelectedIndex = 0;
        }
        #endregion
        
        #region 删除的点击事件
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Name = this.cboList.Text;
            if (this.dgvList.SelectedRows.Count==0)
            {
                MessageBox.Show("没有删除选项","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                return;
            }
            //获取索引
            int index = this.dgvList.SelectedRows[0].Index;
            //根据索引从套餐中删除
            //字典里的【名字】.的全部集合.里删除(获得的索引)
            this.HealthSet[Name].items.RemoveAt(index);
            //删除后重新计算价格
            this.HealthSet[Name].CalPrice();
            //更新dgv
            UpdateSet(HealthSet[Name]);
            this.lblName.Text = this.HealthSet[Name].SetName;
            this.lblPrice.Text = HealthSet[Name].Price.ToString();
            MessageBox.Show("删除成功");
        }
        #endregion

        #region 更新套餐
        private void UpdateSet(HealthCheckSet set)
        {
            this.dgvList.DataSource = new BindingList<HealthCheckItem>(set.items);
        }
        #endregion

        #region 当文本框发生改变时的变化
        private void cboList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //获得下拉框的值
            string setName = this.cboList.Text;
            if (setName == "请选择")
            {
                //重新绑定一下dgv
                this.dgvList.DataSource = new BindingList<HealthCheckItem>();
                //把lbl赋值空
                this.lblName.Text = "";
                this.lblPrice.Text = "";
                //删除按钮禁用
                this.btnDelete.Enabled = false;
                return;
            }
            //如果不进if则把获得的集合的值给lbl
            this.lblName.Text = this.HealthSet[setName].SetName;
            this.lblPrice.Text = this.HealthSet[setName].Price.ToString();

            UpdateSet(HealthSet[setName]);
            this.btnDelete.Enabled = true;
        }
        #endregion

        #region 项目文本框发生改变时触发的事件
        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = this.cboItem.Text;
            if (name == "请选择")
            {
                this.btnAddItem.Enabled = false;
            }
            else
            {
                this.btnAddItem.Enabled = true;
            }
        }
        #endregion

        #region 添加项目的点击事件
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //输入判断
            if (this.cboItem.SelectedIndex == 0)
            {
                MessageBox.Show("请选择一个项目");
                return;
            }
            //获得套餐的值
            string setName = this.cboList.Text;
            if (setName == "请选择")
            {
                MessageBox.Show("请选择套餐");
                return;
            }
            int index = this.cboItem.SelectedIndex;
            if (!this.HealthSet[setName].items.Contains(Allitems[index]))
            {
                //添加检查项
                this.HealthSet[setName].items.Add(Allitems[index]);
                //重新计算价格
                this.HealthSet[setName].CalPrice();
                //调用updateset的方法重新绑定
                UpdateSet(this.HealthSet[setName]);
                //根据获得的值放到lbl里
                this.lblName.Text = this.HealthSet[setName].SetName;
                this.lblPrice.Text = this.HealthSet[setName].Price.ToString();
                MessageBox.Show("添加成功", "提示");
            }
            else
            {
                MessageBox.Show("该项目已经存在");
            }
        }
        #endregion

        #region 添加套餐的点击事件
        private void btnAddSet_Click(object sender, EventArgs e)
        {
            string setName = this.txtSetName.Text.Trim();
            if (string.IsNullOrEmpty(setName))
            {
                MessageBox.Show("请输入套餐名称");
                return;
            }
            HealthCheckSet hcs = new HealthCheckSet();
            hcs.CalPrice();

            this.HealthSet.Add(setName,hcs);
            this.InitHealthSetList();
            this.cboList.SelectedIndex = this.HealthSet.Count;
            MessageBox.Show("添加成","提示");
        }
        #endregion
    }
}
