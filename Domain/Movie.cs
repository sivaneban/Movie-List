﻿

namespace Domain
{
    public class Movie
    {
        public string Title { get; set; }
        public string Plot { get; set; }
        public string Year { get; set; }
        public string imdbID { get; set; }
        public string Genre { get; set; }
        public string Released { get; set; }
        public string Director { get; set; }
        public string Poster { get; set; }
        public Rating[] Ratings { get; set; }
    }
}
