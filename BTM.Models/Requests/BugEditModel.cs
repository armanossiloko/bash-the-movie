using System;
using System.Collections.Generic;
using System.Text;

namespace BTM.Models.Requests
{
    public class BugEditModel
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public bool Resolved { get; set; }
        public int UserID { get; set; }
    }
}
