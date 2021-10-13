using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCinema
{
    public partial class FrmMain : Form
    {
        // 影院类
        Cinema cinema;
        // 集合的key
        string key = null;
        // 座位Label
        Dictionary<string, Label> labels = new Dictionary<string, Label>();

        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            cinema = new Cinema();

            this.lblActor.Text = "";
            this.lblDirector.Text = "";
            this.lblMovieName.Text = "";
            this.lblPrice.Text = "";
            this.lblTime.Text = "";
            this.lblType.Text = "";
            this.lblCalcPrice.Text = "";
            this.cmbDisCount.Enabled = false;
            this.txtCustomer.Enabled = false;

            this.InitSeats(7,5,this.tpCinema);
        }

        /// <summary>
        /// 初始化树形菜单：把放映计划展示到左侧TreeView中
        /// </summary>
        private void InitTreeView()
        {
            this.tvMovies.BeginUpdate();
            this.tvMovies.Nodes.Clear();

            string moveName = "";
            TreeNode movieNode = null;
            foreach (ScheduleItem Item in cinema.Schedule.Items.Values)
            {
                if (moveName != Item.Movie.MovieName)
                {
                    movieNode = new TreeNode(Item.Movie.MovieName);
                    this.tvMovies.Nodes.Add(movieNode);
                }
                TreeNode timeNode = new TreeNode(Item.Time);
                movieNode.Nodes.Add(timeNode);
                moveName = Item.Movie.MovieName;
            }
        }

        /// <summary>
        /// 获取新放映列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiNew_Click(object sender, EventArgs e)
        {
            // 调用加载xml数据的方法
            cinema.Schedule.LoadItems();
            //cinema.SoldTickets.Clear();
            // 初始化树形菜单
            this.InitTreeView();
        }

        /// <summary>
        /// 点击树形菜单后事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvMovies_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = tvMovies.SelectedNode;
            if(node == null)
            {
                return;
            }
            if(node.Level != 1)
            {
                return;
            }
            key = node.Text;

            //将详细信息显示
            this.lblMovieName.Text = cinema.Schedule.Items[key].Movie.MovieName;
            //
            this.lblDirector.Text = cinema.Schedule.Items[key].Movie.Director;
            this.lblActor.Text = cinema.Schedule.Items[key].Movie.Actor;
            this.lblPrice.Text = cinema.Schedule.Items[key].Movie.Price.ToString();
            this.lblTime.Text = cinema.Schedule.Items[key].Time;
            this.lblType.Text = cinema.Schedule.Items[key].Movie.MovieType.ToString();
            this.picMovie.Image = Image.FromFile(cinema.Schedule.Items[key].Movie.Poster);
            this.lblCalcPrice.Text = "";

            // 清空座位
            this.ClearSeat();
            // 遍历该场电影的座位销售情况：该场次已售电影票的座位颜色变为红色
            foreach (Ticket ticket in cinema.SoldTickets)
            {
                foreach (Seat seat in cinema.Seats.Values)
                {
                    if (ticket.ScheduleItem.Time == key && ticket.Seat.SeatNum == seat.SeatNum)
                    {
                        seat.Color = Color.Red;
                    }
                }                
            }

            // 更新座位信息
            this.UpdateSeat();

        }

        /// <summary>
        /// 清空座位：把全部座位变回原来的颜色
        /// </summary>
        private void ClearSeat()
        {
            foreach (Seat seat in cinema.Seats.Values)
            {
                seat.Color = Color.Yellow;
            }
        }

        /// <summary>
        /// 更新座位状态：把已被购买的票的座位对应的Label改成座位的颜色
        /// </summary>
        private void UpdateSeat()
        {
            foreach (string key in cinema.Seats.Keys)
            {
                labels[key].BackColor = cinema.Seats[key].Color;
            }
        }

        /// <summary>
        /// 选择增票
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoFree_CheckedChanged(object sender, EventArgs e)
        {
            this.txtCustomer.Enabled = true;
            this.cmbDisCount.Enabled = false;
            this.cmbDisCount.Text = "";
            // 设置优惠价
            this.lblCalcPrice.Text = "0";
        }

        /// <summary>
        /// 选择学生票
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoStudent_CheckedChanged(object sender, EventArgs e)
        {
            this.txtCustomer.Enabled = false;
            this.txtCustomer.Text = "";
            this.cmbDisCount.Enabled = true;
            this.cmbDisCount.Text = "7";
            // 根据当前选中的电影，设置“优惠价”
            if(this.lblPrice.Text != "")
            {
                int price = int.Parse(this.lblPrice.Text);
                int discount = int.Parse(this.cmbDisCount.Text);
                this.lblCalcPrice.Text = (price * discount / 10).ToString();
            }
        }

        /// <summary>
        /// 选择普通漂
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoNormal_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbDisCount.Enabled = false;
            this.txtCustomer.Text = "";
            this.txtCustomer.Enabled = false;
            this.cmbDisCount.Text = "";
            this.lblCalcPrice.Text = "";
        }

        /// <summary>
        /// 选择“不同折扣”下拉列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbDisCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            //根据当前选中的电影，设置“优惠价”
            if (this.lblPrice.Text != "")
            {
                int price = int.Parse(this.lblPrice.Text);
                int discount = int.Parse(this.cmbDisCount.Text);
                this.lblCalcPrice.Text = (price * discount / 10).ToString();
            }
        }

        /// <summary>
        /// 初始化放映厅座位
        /// 此方法随不要学员自己写，但是要理解代码含义，比如改变几行几列，改变间距
        /// </summary>
        /// <param name="seatRow">行数</param>
        /// <param name="seatLine">列数</param>
        /// <param name="tb"></param>
        private void InitSeats(int seatRow, int seatLine, TabPage tb)
        {
            Label label;
            Seat seat;
            for (int i = 0; i < seatRow; i++ )
            {
                for (int j = 0; j < seatLine; j++ )
                {
                    label = new Label();
                    //设置背景颜色
                    label.BackColor = Color.Yellow;
                    //设置字体
                    label.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    //设置尺寸
                    label.AutoSize = false;
                    label.Size = new System.Drawing.Size(50, 25);
                    //设置座位号
                    label.Text = (j + 1).ToString() + "-" + (i + 1).ToString();
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    //设置位置
                    label.Location = new Point(60 + (i * 90), 60 + (j * 60));

                    // 绑定事件
                    label.Click += new System.EventHandler(lblSeat_Click);

                    tb.Controls.Add(label);
                    labels.Add(label.Text, label);
                    //实例化一个座位
                    seat = new Seat((j+1).ToString() + "-" + (i+1).ToString(), Color.Yellow);
                    //保存的座位集合
                    cinema.Seats.Add(seat.SeatNum, seat);
                }
            }
        }

        /// <summary>
        /// 座位标签的单击事件
        /// 此方法不要学员自己完成，但是需要理解此方法的意思和逻辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblSeat_Click(object sender,EventArgs e)
        { 
            if(String.IsNullOrEmpty(this.lblMovieName.Text))
            {
                MessageBox.Show("您还没有选择电影！","提示");
                return;
            }
            
            try
            {
                string seatNum = ((Label)sender).Text.ToString();
                string customerName = this.txtCustomer.Text.ToString();
                int discount = 0;
                string type = "";
                if (this.rdoStudent.Checked)
                {
                    type = "student";
                    if (this.cmbDisCount.Text == null)
                    {
                        MessageBox.Show("请输入这口！", "提示");
                        return;
                    }
                    else
                    {
                        discount = int.Parse(this.cmbDisCount.Text);
                    }
                }
                else if(this.rdoFree.Checked)
                {
                    if (String.IsNullOrEmpty(this.txtCustomer.Text))
                    {
                        MessageBox.Show("请输入赠票者姓名!", "提示");
                        return;
                    }
                    else
                    {
                        type = "free";
                    }
                }

                // 调用工具类创建票
                Ticket newTicket = TicketUtil.CreateTicket(cinema.Schedule.Items[key],cinema.Seats[seatNum], discount, customerName, type);
                if (cinema.Seats[seatNum].Color == Color.Yellow)
                {
                    DialogResult result = MessageBox.Show("是否购买?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        cinema.Seats[seatNum].Color = Color.Red;
                        UpdateSeat();
                        newTicket.CalcPrice();
                        cinema.SoldTickets.Add(newTicket);
                        lblCalcPrice.Text = newTicket.Price.ToString();
                        newTicket.Print();
                    }
                    else if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                else
                {
                    //显示当前售出票的信息
                    foreach (Ticket t in cinema.SoldTickets)
                    {
                        if(t.Seat.SeatNum == seatNum)
                        {
                            t.Show();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 点击继续销售
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiMovies_Click(object sender, EventArgs e)
        {
            //判断放映列表是否为空
            if (cinema.Schedule.Items.Count == 0)
            {
                cinema.Schedule.LoadItems();
            }
            InitTreeView();
            cinema.Load();
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            cinema.Save();
            this.Dispose();
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSave_Click(object sender, EventArgs e)
        {
            cinema.Save();
        }

        /// <summary>
        /// 关闭窗体事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult close;
            close = MessageBox.Show("是否保存当前销售状态?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (close == DialogResult.Yes)
            {
                //退出时保存Cinema对象
                cinema.Save();
            }
        }
        
    }
}
