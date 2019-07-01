using System;
using System.Collections.Generic;
using System.Text;

namespace BTM.Models.Requests
{
    public class FeedbackEditModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public bool Addressed { get; set; }
        public int UserID { get; set; }
    }
}
