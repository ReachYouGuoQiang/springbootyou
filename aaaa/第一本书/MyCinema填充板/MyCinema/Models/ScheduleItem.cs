using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCinema
{
    [Serializable]
    //每天的放映计划类
    class ScheduleItem
    {
        public string Time { get; set; }
        public Movie Movie { get; set; }

        public ScheduleItem()
        {
            Movie = new Movie();
        }
    }
}
