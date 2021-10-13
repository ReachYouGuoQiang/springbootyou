using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCinema
{
    //创建这个之后就可以直接继承 如果不加前面代码需要多加十多行
    [Serializable]
    //赠票类
    class FreeTicket : Ticket
    {
        /// <summary>
        /// 赠送者姓名
        /// </summary>
        public string CustomerName { get; set; }

        public FreeTicket() { }

        public FreeTicket(ScheduleItem scheduleItem, Seat seat, string customerName)
            : base(scheduleItem, seat)
        {
            this.CustomerName = customerName;
        }

        /// <summary>
        /// 计算票价
        /// </summary>
        public override void CalcPrice()
        {
            //赠票无须价格免费
            this.Price = 0;
        }

        /// <summary>
        /// 打印售票信息
        /// </summary>
        public override void Print()
        {
            //创建一个变量来存放 电影的放映计划
            string fileName = this.ScheduleItem.Time.Replace(":", "-") + "" + this.Seat.SeatNum + "txt";
            //去根据名字找如果存在则他会被覆盖
            FileStream fs = new FileStream(fileName,FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("**************************");
            sw.WriteLine("      青年影院（增票）");
            sw.WriteLine("---------------------");
            sw.WriteLine("电影名：\t{0}",this.ScheduleItem.Movie.MovieName);
            sw.WriteLine("时间：\t{0}",this,ScheduleItem.Time);
            sw.WriteLine("座位号：\t{0}",this.Seat.SeatNum);
            sw.WriteLine("姓名：\t{0}",this.CustomerName);
            sw.Close();
            fs.Close();
        }

        /// <summary>
        /// 显示当前售出票信息
        /// </summary>
        public override void Show()
        {
            MessageBox.Show("已售出!\n\n 赠送者：" + this.CustomerName);
        }
    }
}
