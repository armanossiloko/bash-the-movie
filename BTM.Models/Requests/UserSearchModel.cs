using System;
using System.Collections.Generic;
using System.Text;

namespace BTM.Models.Requests
{
    public class UserSearchModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool LoadRoles { get; set; }
    }
}
