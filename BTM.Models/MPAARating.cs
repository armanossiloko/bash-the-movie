using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.Models
{
    public class MPAARating
    {
        [Key]
        public int RatingID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //public ICollection<Media> Media { get; set; }
    }
}
