using System;
using System.Collections.Generic;
using System.Text;

namespace BTM.MobileApp.Models
{
    public class BugPreviewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateAdded { get; set; }
        public string Submitter { get; set; }
        public string Priority { get; set; }
        public string Description { get; set; }
    }
}
