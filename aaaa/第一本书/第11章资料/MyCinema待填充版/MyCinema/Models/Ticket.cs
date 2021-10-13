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
    //父类 保存电影票信息
    class Ticket
    {
        /// <summary>
        /// 放映场次 类型ScheduleItem
        /// </summary>
        public ScheduleItem ScheduleItem { get; set; }
        /// <summary>
        /// 所属座位 类型Seat
        /// </summary>
        public Seat Seat { get; set; }
        /// <summary>
        /// 票价 类型int(电影票信息类)
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// 无参的构造函数(电影票信息类)
        /// </summary>
        public Ticket(){ }
        /// <summary>
        /// 有参构造函数(电影票信息类)
        /// </summary>
        /// <param name="ScheduleItem"></param>
        /// <param name="Seat"></param>
        public Ticket(ScheduleItem ScheduleItem, Seat Seat)
        {
            this.ScheduleItem = ScheduleItem;
            this.Seat = Seat;
        }

        /// <summary>
        /// 计算票价
        /// </summary>
        public virtual void CalcPrice()
        {
            this.Price = this.ScheduleItem.Movie.Price;
        }
        /// <summary>
        /// 打印电影票
        /// </summary>
        public virtual void Print()
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

        public virtual void Show()
        {
            MessageBox.Show("已售出");
        }

    }
}
