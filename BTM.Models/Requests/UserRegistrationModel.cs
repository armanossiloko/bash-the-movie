using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BTM.Models.Requests
{
    public class UserRegistrationModel
    {
        [Required(AllowEmptyStrings = false)]
        public string Username { get; set; }




        [EmailAddress]
        [Required]
        [MinLength(5)]
        public string Email { get; set; }




        [Required(AllowEmptyStrings = false)]
        [MinLength(3)]
        public string Password { get; set; }


        [Required(AllowEmptyStrings = false)]
        public string PasswordConfirmation { get; set; }




        [Required(AllowEmptyStrings = false)]
        [RegularExpression("^[a-zA-Z ]*$")]
        public string FirstName { get; set; }


        //[Required(AllowEmptyStrings = false)]
        [RegularExpression("^[a-zA-Z ]*$")]
        public string MiddleName { get; set; }


        [Required(AllowEmptyStrings = false)]
        [RegularExpression("^[a-zA-Z ]*$")]
        public string LastName { get; set; }


        [Required(AllowEmptyStrings = false)]
        public string Avatar { get; set; }


        public string FBLink { get; set; }
        public string TwitterLink { get; set; }
        public string LinkedInLink { get; set; }
        public string InstagramLink { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<int> Roles { get; set; } = new List<int>();
    }
}
