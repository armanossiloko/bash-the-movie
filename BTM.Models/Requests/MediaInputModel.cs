using System;
using System.Collections.Generic;
using System.Text;

namespace BTM.Models.Requests
{
    public class MediaInputModel
    {
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Budget { get; set; }
        public double WorldwideGross { get; set; }
        //public int Duration { get; set; }
        public string Director { get; set; }
        public string CoverLocation { get; set; }
        public int StudioID { get; set; }
        public int GenreID { get; set; }
        public int LanguageID { get; set; }
        public int CountryID { get; set; }
        public int RatingID { get; set; }
        //public int RatingID { get; set; }
    }
}
