using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCinema
{
    //创建这个之后就可以直接继承 如果不加前面代码需要多加十多行
    [Serializable]
    //电影
    class Movie
    {
        /// <summary>
        /// 电影名称
        /// </summary>
        public string MovieName { get; set; }
        /// <summary>
        /// 海报名
        /// </summary>
        public string Poster { get; set; }
        /// <summary>
        /// 导演
        /// </summary>
        public string Director { get; set; }
        /// <summary>
        /// 演员
        /// </summary>
        public string Actor { get; set; }
        /// <summary>
        /// 电影类型
        /// </summary>
        public MovieType MovieType { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public int Price { get; set; }

        public Movie() { }
        public Movie(string movieName, string poster, string director, string actor, MovieType movieType, int price)
        {
            this.MovieName = movieName;
            this.Poster = poster;
            this.Director = director;
            this.Actor = actor;
            this.MovieType = movieType;
            this.Price = price;
        }
    }
}
