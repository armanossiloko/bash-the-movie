using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.Models
{
    public class MediaPeopleSetRole
    {
        [Column(Order = 0), /*Key,*/ ForeignKey("Media")]
        public int MediaID { get; set; }
        public Media Media { get; set; }

        [Column(Order = 1), /*Key,*/ ForeignKey("People")]
        public int PeopleID { get; set; }
        public People People { get; set; }

        [Column(Order = 2), /*Key,*/ ForeignKey("SetRole")]
        public int SetRoleID { get; set; }
        public SetRole SetRole { get; set; }
    }
}
