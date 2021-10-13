using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCinema
{
    [Serializable]
    //保存影院的座位信息
    class Seat
    {
        /// <summary>
        /// 座位号 类型String
        /// </summary>
        public string SeatNum { get; set; }
        /// <summary>
        /// 座位卖出状态颜色Color类型
        /// </summary>
        public Color Color { get; set; }
        /// <summary>
        /// 带参构造函数表示座位信息和颜色
        /// </summary>
        /// <param name="seatNum"></param>
        /// <param name="color"></param>
        public Seat(string seatNum, Color color)
        {
            this.SeatNum = seatNum;
            this.Color = color;
        }
    }
}
