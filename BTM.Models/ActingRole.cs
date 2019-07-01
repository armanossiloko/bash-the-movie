using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.Models
{
    public class ActingRole
    {
        [Key]
        public int ActingRoleID { get; set; }
        public string CharacterName { get; set; }

        [ForeignKey("People")]
        public int PeopleID { get; set; }
        public People People { get; set; }
    }
}
