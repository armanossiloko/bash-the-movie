using System;
using System.Collections.Generic;
using System.Text;

namespace BTM.Models.Requests
{
    public class AwardInputModel
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public int MediaID { get; set; }
        public int AwardTypeID { get; set; }
        public int AwardShowID { get; set; }
    }
}
