using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BTM.Models
{
    public class UsersRoles
    {
        [Key]
        public int UserRoleID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }
        //public DateTime DatumIzmjene { get; set; }

        [ForeignKey("Role")]
        public int RoleID { get; set; }
        public Role Role { get; set; }
    }
}
