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
    //普通的电影票
    class Ticket
    {
        /// <summary>
        /// 放映计划里有时间和电影
        /// </summary>
        public ScheduleItem ScheduleItem { get; set; }
        /// <summary>
        /// 座位号
        /// </summary>
        public Seat Seat { get; set; }
        /// <summary>
        /// 电影票的价格
        /// </summary>
        public int Price { get; set; }

        public Ticket(){ }

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
            //计算普通票的价格
            this.Price = this.ScheduleItem.Movie.Price;
        }
        /// <summary>
        /// 打印电影票
        /// </summary>
        public virtual void Print()
        {
            string fileName = this.ScheduleItem.Time.Replace(":", "-") + "" + this.Seat.SeatNum + "txt";
            FileStream fs = new FileStream(fileName,FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("*********************");
            sw.WriteLine("          青年影院");
            sw.WriteLine("------------------");
            sw.WriteLine("电影名：\t{0}",this.ScheduleItem.Movie.MovieName);
            sw.WriteLine("时间：\t{0}",this.ScheduleItem.Time);
            sw.WriteLine("座位号：\t{0}",this.Seat.SeatNum);
            sw.WriteLine("价格：\t{0}",this.Price.ToString());
            sw.Close();
            fs.Close();
        }

        public virtual void Show()
        {
            MessageBox.Show("已售出");
        }

    }
}
