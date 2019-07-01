using System;
using System.Collections.Generic;
using System.Text;

namespace BTM.Models.Requests
{
    public class MediaRatingInputModel
    {
        public int MediaID { get; set; }
        public int UserID { get; set; }
        public int Rating { get; set; }
    }
}
