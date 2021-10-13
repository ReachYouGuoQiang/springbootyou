using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCheckSystem
{
    public partial class FrmMain : Form
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

        public FrmMain()
        {
            InitializeComponent();
        }

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

            this.cboItem.DataSource = new BindingList<HealthCheckItem>(this.AllItems);
            this.cboItem.DisplayMember = "ItemName";
        }

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

            this.HealthSet.Add("入学体检",setA);
        }

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

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.lblName.Text = "";
            this.lblPrice.Text = "";
            this.btnAddItem.Enabled = false;
            this.btnDelete.Enabled = false;

            this.InitItems();
            this.InitSets();
            this.InitHealthSetList();
        }

        /// <summary>
        /// 删除体检套餐中体检项目信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string setName = this.cboList.Text;
            if(this.dgvList.SelectedRows.Count == 0)
            {
                MessageBox.Show("没有选择删除项。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 获取选中检查项目的索引
            int index = this.dgvList.SelectedRows[0].Index;
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

        /// <summary>
        /// 套餐列表选中项改变时事件，加载选择的套餐中的体检项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string setName = this.cboList.Text;
            if(setName == "请选择")
            {
                this.dgvList.DataSource = new BindingList<HealthCheckItem>();
                this.lblName.Text = "";
                this.lblPrice.Text = "";
                this.btnDelete.Enabled = false;
                return;
            }
            this.lblName.Text = this.HealthSet[setName].SetName;
            this.lblPrice.Text = this.HealthSet[setName].Price.ToString();
            // setName：选中的套餐名   HealthSet：存放全部套餐的集合
            // HealthSet[setName]  根据key找Value   根据套餐名找套餐对象
            UpdateSet(HealthSet[setName]);
            this.btnDelete.Enabled = true;
        }

        /// <summary>
        /// 更新体检套餐中体检项目DataGridView
        /// </summary>
        /// <param name="set"></param>
        private void UpdateSet(HealthCheckSet set)
        {
            this.dgvList.DataSource = new BindingList<HealthCheckItem>(set.items);
        }

        /// <summary>
        /// 体检项目下拉列表选项更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemName = this.cboItem.Text;
            if (itemName == "请选择")
            {
                this.btnAddItem.Enabled = false;
            }
            else
            {
                this.btnAddItem.Enabled = true;
            }
        }

        /// <summary>
        /// 添加体检项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            // 输入判断
            if(this.cboItem.SelectedIndex == 0)
            {
                MessageBox.Show("请选择一个项目。");
                return;
            }
            string setName = this.cboList.Text;
            if(setName == "请选择")
            {
                MessageBox.Show("请选择套餐！");
                return;
            }

            // 添加操作
            int index = this.cboItem.SelectedIndex;
            if (!this.HealthSet[setName].items.Contains(AllItems[index]))
            {
                // 添加检查项
                this.HealthSet[setName].items.Add(AllItems[index]);
                // 重新计算价格
                this.HealthSet[setName].CalcPrice();
                // 更新DataGridView列表数据
                UpdateSet(this.HealthSet[setName]);
                this.lblName.Text = this.HealthSet[setName].SetName;
                this.lblPrice.Text = this.HealthSet[setName].Price.ToString();
                MessageBox.Show("添加成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("该项目存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// 添加套餐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddSet_Click(object sender, EventArgs e)
        {
            string setName = this.txtSetName.Text.Trim();
            if(string.IsNullOrEmpty(setName))
            {
                MessageBox.Show("请输入套餐名称!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            HealthCheckSet hcs = new HealthCheckSet();
            hcs.CalcPrice();

            this.HealthSet.Add(setName, hcs);

            this.InitHealthSetList();
            this.cboList.SelectedIndex = this.HealthSet.Count;
            MessageBox.Show("添加成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
