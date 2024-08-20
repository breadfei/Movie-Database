using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Database
{
    internal class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }

        public Movie (string _title, string _genre)
        {
            Title = _title;
            Genre = _genre;
        }
    }
}
