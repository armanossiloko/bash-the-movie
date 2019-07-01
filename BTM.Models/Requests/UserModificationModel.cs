using System;
using System.Collections.Generic;
using System.Text;

namespace BTM.Models.Requests
{
    public class UserModificationModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAdmin { get; set; }
        //public bool IsMember { get; set; }
    }
}
