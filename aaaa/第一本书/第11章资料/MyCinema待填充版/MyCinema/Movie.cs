using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCinema
{
    class Movie
    {
        public string MovieName { get; set; }
        public string Poster { get; set; }
        public string Director { get; set; }
        public string Actor { get; set; }
        public MovieType MovieType { get; set; }
        public int Price { get; set; }
    }
}
