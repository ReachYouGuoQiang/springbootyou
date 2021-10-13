using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 套餐练习11._16
{
    public partial class Form1 : Form
    {
        //定义几个检查项目
        HealthCheckItem height, weight, sight, hearing, liverFun, ekg, bWaves, bloodPressure, bloodTest;
        //定义1个系统默认检查套餐“入学体检”
        HealthCheckSet setA;
        //保存所有的体检项目
        List<HealthCheckItem> AllItems = new List<HealthCheckItem>();
        //保存套餐中的体检项目
        List<HealthCheckItem> items = new List<HealthCheckItem>();
        //使用字典保存套餐集合
        public Dictionary<string, HealthCheckSet> HealthSet = new Dictionary<string, HealthCheckSet>();
        public Form1()
        {
            InitializeComponent();
        }

        #region 检查初始化项目
        /// <summary>
        /// 创建所有检查项目，并保存在AllItems集合中
        /// </summary>
        private void InitItems()
        {
            //创建Item对象并保存到集合中 --注意如果使用List<T> 必须与下拉列表中的索引一致
            HealthCheckItem choice = new HealthCheckItem("请选择", -1, "请选择");
            height = new HealthCheckItem("身高", 5, "用于检查身高.");
            weight = new HealthCheckItem("体重", 5, "用于检查体重.");
            sight = new HealthCheckItem("视力", 10, "用于检查视力.");
            hearing = new HealthCheckItem("听力", 10, "用于检查听力.");
            liverFun = new HealthCheckItem("肝功能", 50, "用于检查肝功能.");
            bWaves = new HealthCheckItem("B超", 30, "用于检查B超.");
            ekg = new HealthCheckItem("心电图", 50, "用于检查心电图.");
            bloodPressure = new HealthCheckItem("血压", 20, "用于检查血压.");
            bloodTest = new HealthCheckItem("血常规", 20, "用于检查血常规.");
            AllItems.Add(choice);
            AllItems.Add(height);
            AllItems.Add(weight);
            AllItems.Add(sight);
            AllItems.Add(hearing);
            AllItems.Add(liverFun);
            AllItems.Add(bWaves);
            AllItems.Add(ekg);
            AllItems.Add(bloodPressure);
            AllItems.Add(bloodTest);

            this.cboItems.DataSource = new BindingList<HealthCheckItem>(this.AllItems);
            this.cboItems.DisplayMember = "ItemName";
        }
        #endregion

        #region 窗体的加载事件
        private void Form1_Load(object sender, EventArgs e)
        {
            this.lblName.Text = "";
            this.lblPrice.Text = "";
            this.btTian.Enabled = false;
            this.btDe.Enabled = false;

            this.InitItems();
            this.InitSets();
            this.InitHealthSetList();
            ////初始化并且绑定cbo
            //InitItems();
            ////套餐的初始化并且计算总价
            //InitSets();
            ////绑定下拉框
            //BidCbo();
        }
        #endregion

        #region 绑定dgv的代码
        public void BidDgv()
        {
            this.dgvShow.DataSource = new BindingList<HealthCheckSet>();
        }
        #endregion

        #region 初始化套餐
        /// <summary>
        /// 生成默认套餐数据
        /// </summary>
        private void InitSets()
        {
            //创建1种默认套餐对象
            items = new List<HealthCheckItem>();
            items.Add(height);
            items.Add(weight);
            items.Add(liverFun);

            setA = new HealthCheckSet(items, "入学体检");
            setA.CalcPrice();

            this.HealthSet.Add("入学体检", setA);
        }
        #endregion

        #region 绑定下拉套餐矿
        private void InitHealthSetList()
        {
            this.cboLieBiao.Items.Clear();
            this.cboLieBiao.Items.Add("请选择");
            foreach (string key in this.HealthSet.Keys)
            {
                this.cboLieBiao.Items.Add(key);
            }
            this.cboLieBiao.SelectedIndex = 0;
        }
        #endregion

        #region 删除的套餐
        private void btDe_Click(object sender, EventArgs e)
        {
            string setName = this.cboLieBiao.Text;
            if (this.dgvShow.SelectedRows.Count == 0)
            {
                MessageBox.Show("没有选择删除项。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 获取选中检查项目的索引
            int index = this.dgvShow.SelectedRows[0].Index;
            // 从套餐中删除该项目
            this.HealthSet[setName].items.RemoveAt(index);
            // 删除后重新计算价格
            this.HealthSet[setName].CalcPrice();
            // 更新DataGridView
            UpdateSet(HealthSet[setName]);
            // 重新设置标签的值
            this.lblName.Text = HealthSet[setName].SetName;
            this.lblPrice.Text = HealthSet[setName].Price.ToString();
            MessageBox.Show("删除成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        


    }
}
