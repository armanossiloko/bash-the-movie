using System;
using System.Collections.Generic;
using System.Text;

namespace BTM.MobileApp.Models
{
    public class TicketPreviewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Resolved { get; set; }
        public DateTime DateAdded { get; set; }
        public int UserID { get; set; }
        public string User { get; set; }
    }
}
