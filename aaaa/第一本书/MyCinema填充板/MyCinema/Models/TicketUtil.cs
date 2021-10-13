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

        //几个参数的意思ScheduleItem获得放映计划 Seat座位号 如果是学生票的要有折扣discount 如果是赠票则要有赠送人customer 选择你要的是那种票则需要一个参数来进行判断type
        public static Ticket CreateTicket(ScheduleItem scheduleItem, Seat seat, int discount, string customer, string type)
        {
            Ticket newTicket = null;
            switch (type)
            {
                    //当选择学生类的时候触发的事件
                case"student":
                    newTicket = new StudentTicket(scheduleItem,seat,discount);
                    break;
                    //选择赠票类的时候触发的事件
                case"free":
                    newTicket = new FreeTicket(scheduleItem, seat, customer);
                    break;
                case"":
                    newTicket=new Ticket(scheduleItem,seat);
                    break;
            }
            return newTicket;
        }

    }
}
