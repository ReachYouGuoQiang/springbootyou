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
    //继承父类Ticket保存特殊的赠票信息 
    class FreeTicket : Ticket
    {
        /// <summary>
        /// 获得赠票者的名称
        /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        /// 获的构造函数(赠票信息)
        /// </summary>
        public FreeTicket() { }
        /// <summary>
        /// 获得有参构造函数(赠票信息)
        /// </summary>
        /// <param name="scheduleItem"></param>
        /// <param name="seat"></param>
        /// <param name="customerName"></param>
        public FreeTicket(ScheduleItem scheduleItem, Seat seat, string customerName): base(scheduleItem, seat)
        {
            this.CustomerName = customerName;
        }

        /// <summary>
        /// 计算票价
        /// </summary>
        public override void CalcPrice()
        {
            this.Price = 0;
        }

        /// <summary>
        /// 打印售票信息
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
            MessageBox.Show("已售出!\n\n 赠送者：" + this.CustomerName);
        }
    }
}
