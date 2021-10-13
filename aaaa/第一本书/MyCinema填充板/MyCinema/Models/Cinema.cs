
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
        //因为只有一个厅所以座位号是唯一的所以用Dictionary来存放
        public Dictionary<string, Seat> Seats { get; set; }
        public Schedule Schedule { get; set; }
        //因为场次没有唯一的东西所以用List来拼(但是如果硬要用Dictionary来写的话就可以用场次+座位号来确定唯一性)
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
            using (FileStream fs = new FileStream("soldTickets.txt", FileMode.OpenOrCreate)) 
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs,SoldTickets);
            }
        }

        /// <summary>
        /// 读取售票情况
        /// </summary>
        public void Load()
        {
            //之所以要用TRY原因是用的强转 会出错所以用try来进行测试 如果用as的话则不需要try了
            try
            {
                using (FileStream fs=new FileStream("soldTicket.txt",FileMode.OpenOrCreate))
                {
                    //创建文件流
                    BinaryFormatter bf = new BinaryFormatter();
                    //反向读取数据从硬盘中读取出来
                    SoldTickets = (List < Ticket >) bf.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("出错了"+ex.Message);
                SoldTickets = new List<Ticket>();
            }
        }

    }
}
