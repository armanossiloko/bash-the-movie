using System;
using System.Collections.Generic;
using System.Text;

namespace BTM.MobileApp.Models
{
    public class NewsPreviewModel
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public string Submitter { get; set; }
    }
}
