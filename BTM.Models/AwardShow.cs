using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.Models
{
    public class AwardShow
    {
        [Key]
        public int AwardShowID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
 
        public ICollection<Award> Awards { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
