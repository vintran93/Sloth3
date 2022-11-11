using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Sloth3
{
    class Movie
    {
        public string title;
        public string director;
        public string rating;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating; // capitalize to call the setter down below for more secure
        }

        public string Rating
        {
            get { return rating;  } // allows to get the rating
            set {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            } // define a specific rule if valid setting; set the rating
        }
    }
}
