using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DavidOcHome.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Img { get; set; }
        public int Seasons { get; set; }
        public int Views { get; set; }
    }
}