using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csoop_c10_prac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 未租出车辆集合
        Dictionary<string, Vehicle> vehicles = new Dictionary<string, Vehicle>();
        // 已租出车辆集合
        Dictionary<string, Vehicle> rentVehicles = new Dictionary<string,Vehicle>();

        // 窗体加载事件
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Init();
            this.Bind1();
            this.Bind2();
        }

        // 数据初始化
        public void Init() 
        {
            Car c = new Car();
            c.LisenceNO = "苏C3104731";
            c.Name = "奥迪A6";
            c.Color = "黑色";
            c.RentDate = 3;
            c.DailyRent = 240;
            this.vehicles.Add(c.LisenceNO, c);
        }

        // 绑定listview1
        public void Bind1()
        {
            this.listView1.Items.Clear();
            foreach (Vehicle v in vehicles.Values)
            {
                ListViewItem item = new ListViewItem(v.LisenceNO);
                item.SubItems.Add(v.Name);
                item.SubItems.Add(v.Color);
                item.SubItems.Add(v.RentDate.ToString());
                item.SubItems.Add(v.DailyRent.ToString());
                if (v is Car)
                {
                    item.SubItems.Add("无");
                }
                else
                {
                    Truck t = (Truck)v;
                    item.SubItems.Add(t.Load.ToString());
                }
                this.listView1.Items.Add(item);
            }
        }

        // 绑定listview2
        public void Bind2()
        {
            this.listView2.Items.Clear();
            foreach (Vehicle v in rentVehicles.Values)
            {
                ListViewItem item = new ListViewItem(v.LisenceNO);
                item.SubItems.Add(v.Name);
                item.SubItems.Add(v.Color);
                item.SubItems.Add(v.RentDate.ToString());
                item.SubItems.Add(v.DailyRent.ToString());
                if (v is Car)
                {
                    item.SubItems.Add("无");
                }
                else
                {
                    Truck t = (Truck)v;
                    item.SubItems.Add(t.Load.ToString());
                }
                this.listView2.Items.Add(item);
            }
        }

        // 刷新listview1
        private void button1_Click(object sender, EventArgs e)
        {
            this.Bind1();
        }

        // 刷新listview2
        private void button5_Click(object sender, EventArgs e)
        {
            this.Bind2();
        }

        // 租车
        private void button2_Click(object sender, EventArgs e)
        {
            if (RentCar_IsEmpty())
            {
                return;
            }
            string name = this.txtUser.Text.Trim();
            string key = this.listView1.SelectedItems[0].SubItems[0].Text;
            this.vehicles[key].RentUser = name;
            this.rentVehicles.Add(this.vehicles[key].LisenceNO, this.vehicles[key]);
            this.vehicles.Remove(key);
            this.Bind1();
            this.Bind2();
            MessageBox.Show("已出租");
        }

        // 租车-非空验证
        public bool RentCar_IsEmpty() 
        {
            if (this.txtUser.Text.Trim() == "")
            {
                MessageBox.Show("请输入租车人姓名");
                return true;
            }
            if (this.listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择车辆");
                return true;
            }
            return false;
        }

        // 选择结算
        private void button4_Click(object sender, EventArgs e)
        {
            if (ReturnCar_IsEmpty())
            {
                return;
            }
            string days = this.txtDays.Text.Trim();
            if (!this.IsNumber(days, "租用天数"))
            {
                return;
            }
            string key = this.listView2.SelectedItems[0].SubItems[0].Text;
            rentVehicles[key].RentDate = int.Parse(this.txtDays.Text.Trim());
            double total = rentVehicles[key].CalcTotal();
            this.vehicles.Add(rentVehicles[key].LisenceNO, rentVehicles[key]);
            this.rentVehicles.Remove(key);
            this.Bind1();
            this.Bind2();
            MessageBox.Show("结算成功，总价是" + total.ToString() + "元");
        }

        // 选择结算-非空验证
        public bool ReturnCar_IsEmpty()
        {
            if (this.txtDays.Text.Trim() == "")
            {
                MessageBox.Show("请输入租车天数");
                return true;
            }
            if (this.listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择结算车辆");
                return true;
            }
            return false;
        }

        // 数字校验
        public bool IsNumber(string text, string position)
        {
            try
            {
                int temp = int.Parse(text);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show(position + "格式错误，请输入数字");
                return false;
            }
        }

        // 入库
        private void button6_Click(object sender, EventArgs e)
        {
            if (AddCar_IsEmpty())
            {
                return;
            }
            if (!this.IsUnique())
            {
                return;
            }
            Vehicle v = null;
            if (this.radioButton1.Checked == true)
            {
                v = new Car();
            }
            else
            {
                v = new Truck();
                if (!this.IsNumber(this.txtLoad.Text.Trim(), "卡车载重"))
                {
                    return;
                }
                (v as Truck).Load = int.Parse(this.txtLoad.Text.Trim());
            }
            v.LisenceNO = this.txtLisenceNo.Text.Trim();
            v.Name = this.txtName.Text.Trim();
            v.Color = this.txtColor.Text.Trim();
            if (!this.IsNumber(this.txtRentDate.Text.Trim(), "使用时间"))
            {
                return;
            }
            v.RentDate = int.Parse(this.txtRentDate.Text.Trim());
            if (!this.IsNumber(this.txtDailyRent.Text.Trim(), "日租金"))
	        {
                return;
	        }
            v.DailyRent = int.Parse(this.txtDailyRent.Text.Trim());
            this.vehicles.Add(v.LisenceNO, v);
            this.Bind1();
            this.Clear();
            this.radioButton1.Checked = true;
            MessageBox.Show("入库成功");
        }

        // 入库-非空验证
        public bool AddCar_IsEmpty()
        {
            if (this.radioButton1.Checked == false)
            {
                if (this.txtLoad.Text.Trim() == "")
                {
                    MessageBox.Show("请输入卡车载重");
                    return true;
                }
            }
            if (this.txtLisenceNo.Text.Trim() == "")
            {
                MessageBox.Show("请输入车牌号");
                return true;
            }
            if (this.txtLisenceNo.Text.Trim() == "")
            {
                MessageBox.Show("请输入车型");
                return true;
            }
            if (this.txtLisenceNo.Text.Trim() == "")
            {
                MessageBox.Show("请输入颜色");
                return true;
            }
            if (this.txtLisenceNo.Text.Trim() == "")
            {
                MessageBox.Show("请输入使用时间");
                return true;
            }
            if (this.txtLisenceNo.Text.Trim() == "")
            {
                MessageBox.Show("请输入每日租金");
                return true;
            }
            return false;
        }

        // 入库-唯一车牌号验证
        public bool IsUnique()
        {
            foreach (Vehicle vehicle in vehicles.Values)
            {
                if (vehicle.LisenceNO == this.txtLisenceNo.Text.Trim())
                {
                    MessageBox.Show("车辆已存在");
                    return false;
                }
            }
            foreach (Vehicle vehicle in rentVehicles.Values)
            {
                if (vehicle.LisenceNO == this.txtLisenceNo.Text.Trim())
                {
                    MessageBox.Show("车辆已存在");
                    return false;
                }
            }
            return true;
        }

        // 入库-清空文本框
        public void Clear()
        {
            this.txtLisenceNo.Text = "";
            this.txtName.Text = "";
            this.txtColor.Text = "";
            this.txtRentDate.Text = "";
            this.txtDailyRent.Text = "";
            this.txtLoad.Text = "";
        }

        // 轿车按钮选中状态改变事件
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Clear();
            if (this.radioButton1.Checked == true)
            {
                this.txtLoad.Enabled = false;
            }
            else
            {
                this.txtLoad.Enabled = true;
            }
        }

        // 退出
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
