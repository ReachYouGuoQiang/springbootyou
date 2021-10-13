using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCinema
{
    class Ticket
    {
        public ScheduleItem ScheduleItem { get; set; }
        public Seat Seat { get; set; }
        public int Price { get; set; }

        public virtual void CalcPrice()
        { 
            
        }

        public virtual void Print()
        { 
            
        }

        public virtual void Show()
        { 
            
        }

    }
}
