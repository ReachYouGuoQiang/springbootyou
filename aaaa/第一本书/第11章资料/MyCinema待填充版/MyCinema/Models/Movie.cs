using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCinema
{
    [Serializable]
    //电影类
    class Movie
    {
        /// <summary>
        /// 电影名类型String
        /// </summary>
        public string MovieName { get; set; }
        /// <summary>
        /// 海报名类型String
        /// </summary>
        public string Poster { get; set; }
        /// <summary>
        /// 导演名类型String
        /// </summary>
        public string Director { get; set; }
        /// <summary>
        /// 主演类型String
        /// </summary>
        public string Actor { get; set; }
        /// <summary>
        /// 电影类型 类型MovieType
        /// </summary>
        public MovieType MovieType { get; set; }
        /// <summary>
        /// 票价类型int(电影类)
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// 无惨电影构造函数
        /// </summary>
        public Movie() { }
        /// <summary>
        /// 带参电影构造函数
        /// </summary>
        /// <param name="movieName"></param>
        /// <param name="poster"></param>
        /// <param name="director"></param>
        /// <param name="actor"></param>
        /// <param name="movieType"></param>
        /// <param name="price"></param>
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
