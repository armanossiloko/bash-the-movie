using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.Models
{
    public class Award
    {
        [Key]
        public int AwardID { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        [ForeignKey("Media")]
        public int MediaID { get; set; }
        public Media Media { get; set; }

        [ForeignKey("AwardType")]
        public int AwardTypeID { get; set; }
        public AwardType AwardType { get; set; }

        [ForeignKey("AwardShow")]
        public int AwardShowID { get; set; }
        public AwardShow AwardShow { get; set; }
    }
}
