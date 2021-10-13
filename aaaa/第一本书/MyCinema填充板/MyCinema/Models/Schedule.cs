using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MyCinema
{
    [Serializable]
    //放映计划类
    class Schedule
    {
        /// <summary>
        /// 电影场次
        /// </summary>
        public Dictionary<string, ScheduleItem> Items { get; set; }

        public Schedule()
        {
            Items = new Dictionary<string, ScheduleItem>();
        }

        /// <summary>
        /// 读取XML文件获取放映计划列表中每个场次信息
        /// </summary>
        public void LoadItems()
        {
            if(Items==null)
            {
                Items = new Dictionary<string, ScheduleItem>();
            }
            Items.Clear();
            XmlDocument myxml = new XmlDocument();
            myxml.Load("ShowList.xml");
            XmlNode feenode = myxml.DocumentElement;
            //中间变量
            string movieName = null;
            string playBill = null;
            string director = null;
            string actor = null;
            string movieType = null;
            string price = null;
            foreach (XmlNode node in feenode.ChildNodes)
            {
                if(node.Name=="Movie")
                {
                    foreach (XmlNode subNode in node.ChildNodes)
                    {
                        switch (subNode.Name)
                        {
                            case "Name":
                                movieName = subNode.InnerText;
                                break;
                            case "Poster":
                                playBill = subNode.InnerText;
                                break;
                            case "Director":
                                director = subNode.InnerText;
                                break;
                            case "Actor":
                                actor = subNode.InnerText;
                                break;
                            case "Type":
                                movieType = subNode.InnerText;
                                break;
                            case "Price":
                                price = subNode.InnerText;
                                break;
                            case "Schedule":
                                foreach (XmlNode scheduleNode in subNode.ChildNodes)
                                {
                                    ScheduleItem item = new ScheduleItem();
                                    item.Time = scheduleNode.InnerText;
                                    item.Movie.MovieName = movieName;
                                    item.Movie.Poster = playBill;
                                    item.Movie.Director = director;
                                    item.Movie.Actor = actor;
                                    item.Movie.MovieType = (MovieType)Enum.Parse(typeof(MovieType),movieType);
                                    item.Movie.Price = int.Parse(price);
                                    Items.Add(item.Time,item);
                                }
                                break;
                        }
                    }
                }
            }
        }
    }
}
