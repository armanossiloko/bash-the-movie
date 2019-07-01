using System;
using System.Collections.Generic;
using System.Text;

namespace BTM.Models.Requests
{
    public class SetRoleInputModel
    {
        public int MediaID { get; set; }
        public int PeopleID { get; set; }
        public int SetRoleID { get; set; }
    }
}
