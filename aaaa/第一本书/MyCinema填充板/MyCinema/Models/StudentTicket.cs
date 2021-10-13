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
    //学生票类
    class StudentTicket : Ticket
    {
        /// <summary>
        /// 折扣
        /// </summary>
        public int Discount { get; set; }

        public StudentTicket() { }
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
            //现电影票价=电影票原价*折扣价/10(为什么/10 如果不/10则不是打折了 而是以折扣的倍数去相乘会更贵)
            this.Price = this.ScheduleItem.Movie.Price * Discount / 10;
        }

        /// <summary>
        /// 打印电影票
        /// </summary>
        public override void Print()
        {
            //创建一个变量来接收电影票的信息
            string fileName = this.ScheduleItem.Time.Replace(":", "-") + "" + this.Seat.SeatNum + "txt";
            //创建文件流 去寻找他如果找到了则覆盖
            FileStream fs = new FileStream(fileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("*********************");
            sw.WriteLine("          青年影院");
            sw.WriteLine("------------------");
            sw.WriteLine("电影名：\t{0}", this.ScheduleItem.Movie.MovieName);
            sw.WriteLine("时间：\t{0}", this.ScheduleItem.Time);
            sw.WriteLine("座位号：\t{0}", this.Seat.SeatNum);
            sw.WriteLine("价格：\t{0}", this.Price.ToString());
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
