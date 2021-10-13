using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCinema
{
    class TicketUtil
    {
        /// <summary>
        /// 创建电影票
        /// </summary>
        /// <param name="scheduleItem"></param>
        /// <param name="seat"></param>
        /// <param name="discount"></param>
        /// <param name="customer"></param>
        /// <param name="type"></param>
        public static Ticket CreateTicket(ScheduleItem scheduleItem, Seat seat, int discount, string customer, string type)
        {
            Ticket newTicket = null;
            switch (type)
            { 
                case "student":
                    newTicket = new StudentTicket(scheduleItem, seat, discount);
                    break;
                case "free":
                    newTicket = new FreeTicket(scheduleItem, seat,customer);
                    break;
                case "":
                    newTicket = new Ticket(scheduleItem, seat);
                    break;
            }
            return newTicket;
        }

    }
}
