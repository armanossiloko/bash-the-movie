using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.Models
{
    public class SetRole
    {
        [Key]
        public int SetRoleID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
