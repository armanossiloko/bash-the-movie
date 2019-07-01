using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.Models
{
    public class Trailer
    {
        [Key]
        public int TrailerID { get; set; }
        public string Location { get; set; }

        [ForeignKey("Media")]
        public int MediaID { get; set; }
        public Media Media { get; set; }
    }
}
