using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCinema
{
    [Serializable]
    //继承父类Ticket保存特殊的学生票信息
    class StudentTicket : Ticket
    {
        /// <summary>
        /// 学生票折扣类型int
        /// </summary>
        public int Discount { get; set; }
        /// <summary>
        /// 无参构造函数(StudentTicket类)
        /// </summary>
        public StudentTicket() { }
        /// <summary>
        /// 有参构造函数继承父类的属性(StudentTicket类)
        /// </summary>
        /// <param name="scheduleItem"></param>
        /// <param name="seat"></param>
        /// <param name="discount"></param>
        public StudentTicket(ScheduleItem scheduleItem, Seat seat, int discount)
            : base(scheduleItem, seat)
        {
            this.Discount = discount;
        }

        /// <summary>
        /// 计算票价
        /// </summary>
        public override void CalcPrice()
        {
            this.Price = this.ScheduleItem.Movie.Price * Discount / 10;
        }

        /// <summary>
        /// 打印电影票
        /// </summary>
        public override void Print()
        {
            string fileName = this.ScheduleItem.Time.Replace(":", "-") + "" + this.Seat.SeatNum + ".txt";
            FileStream fs = new FileStream(fileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("*******************************");
            sw.WriteLine("      青鸟影院       ");
            sw.WriteLine("------------------------");
            sw.WriteLine("电影名：\t{0}", this.ScheduleItem.Movie.MovieName);
            sw.WriteLine("时间：\t{0}", this.ScheduleItem.Time);
            sw.WriteLine("座位号：\t{0}", this.Seat.SeatNum);
            sw.WriteLine("价格：\t{0}", this.Price.ToString());
            sw.WriteLine("*******************************");
            sw.Close();
            fs.Close();
        }

        /// <summary>
        /// 显示当前售出票信息
        /// </summary>
        public override void Show()
        {
            MessageBox.Show("已售出!\n\n " + this.Discount + "折学生票!");
        }
    }
}
