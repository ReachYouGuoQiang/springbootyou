using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCinema
{
    class Cinema
    {
        public Dictionary<string, Seat> Seats { get; set; }
        public Schedule Schedule { get; set; }
        public List<Ticket> SoldTickets { get; set; }

        /// <summary>
        /// 保存售票情况
        /// </summary>
        public void Save()
        { 
        
        }

        /// <summary>
        /// 读取售票情况
        /// </summary>
        public void Load()
        { 
        
        }

    }
}
