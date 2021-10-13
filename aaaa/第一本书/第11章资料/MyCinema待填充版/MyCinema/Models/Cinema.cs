using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;

namespace MyCinema
{
    class Cinema
    {
        public Dictionary<string, Seat> Seats { get; set; }
        public Schedule Schedule { get; set; }
        public List<Ticket> SoldTickets { get; set; }

        public Cinema()
        {
            Seats = new Dictionary<string, Seat>();
            Schedule = new Schedule();
            SoldTickets = new List<Ticket>();
        }

        /// <summary>
        /// 保存售票情况
        /// </summary>
        public void Save()
        {
             // 用序列化来保存更简单快捷
            /*
             *写！ 
             */

        }

        /// <summary>
        /// 读取售票情况
        /// </summary>
        public void Load()
        {
            /*
             *写！ 
             */
        }

    }
}
