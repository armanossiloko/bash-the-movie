using System;
using System.Collections.Generic;
using System.Text;

namespace BTM.Models.Requests
{
    public class MediaDetailModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public DateTime DateReleased { get; set; }
        public string Keywords { get; set; }
        public string Country { get; set; }
        public string Genres { get; set; }
        public string Languages { get; set; }
        public string Director { get; set; }
        public string Budget { get; set; }
        public string BoxOffice { get; set; }
        public string Poster { get; set; }
        public int Rating { get; set; }
    }
}
