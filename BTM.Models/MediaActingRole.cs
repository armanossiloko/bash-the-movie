using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.Models
{
    public class MediaActingRole
    {
        [ForeignKey("Media")]
        public int MediaID { get; set; }
        public Media Media { get; set; }

        [ForeignKey("ActingRole")]
        public int ActingRoleID { get; set; }
        public ActingRole ActingRole { get; set; }
    }
}
