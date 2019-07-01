using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.Models
{
    public class User// : IdentityUser<int>
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }

        public DateTime JoinDate { get; set; }
        public string FBLink { get; set; }
        public string TwitterLink { get; set; }
        public string LinkedInLink { get; set; }
        public string InstagramLink { get; set; }

        public string Avatar { get; set; }

        //[ForeignKey("Login")]
        //public int LoginID { get; set; }
        //public Login Login { get; set; }

        public ICollection<UsersRoles> Roles { get; set; }
        //public ICollection<MediaUser> Votes { get; set; }
        //public ICollection<List> Lists { get; set; }
    }
}
