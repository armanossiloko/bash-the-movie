using System;
using System.Collections.Generic;
using System.Text;

namespace BTM.Models.Requests
{
    public class MediaSearchRequest
    {
        public string Title { get; set; } = "";
        public int Year { get; set; } = 0;
        public int GenreID { get; set; } = 0;
    }
}
