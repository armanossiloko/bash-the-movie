using System;
using System.Collections.Generic;
using System.Text;

namespace BTM.Models.Requests
{
    public class TicketEditModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Resolved { get; set; }
        public DateTime DateAdded { get; set; }
        public int UserID { get; set; }
    }
}
