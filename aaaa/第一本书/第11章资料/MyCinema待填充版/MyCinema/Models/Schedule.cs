using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MyCinema
{
    [Serializable]
    class Schedule
    {
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
            if (Items == null)
            {
                Items = new Dictionary<string, ScheduleItem>();
            }
            Items.Clear();

            XmlDocument myXnl = new XmlDocument();
            myXnl.Load("ShowList.xml");
            XmlNode feednode = myXnl.DocumentElement;
            //中间变量
            string movieName = null;
            string piayBill = null;
            string director = null;
            string actor = null;
            string movieType = null;
            string price = null;

            foreach (XmlNode node in feednode.ChildNodes)
            {
                if (node.Name == "Movie")
                {
                    foreach (XmlNode subNode in node.ChildNodes)
                    {
                        switch (subNode.Name)
                        { 
                            case "Name":
                                movieName = subNode.InnerText;
                                break;
                            case "Poster":
                                piayBill = subNode.InnerText;
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
                                    item.Movie.Poster = piayBill;
                                    item.Movie.Director = director;
                                    item.Movie.Actor = actor;
                                    item.Movie.MovieType = (MovieType)Enum.Parse(typeof(MovieType), movieType);
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
