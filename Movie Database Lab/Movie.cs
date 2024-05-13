using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Database_Lab
{
    public class Movie
    {
        public string title { get; set; }
        public string catagory { get; set; }

        public Movie (string _title, string _catagory)
        {
            title = _title;
            catagory = _catagory;
        }

    }
}
