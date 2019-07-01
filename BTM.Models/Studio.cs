using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.Models
{
    public class Studio
    {
        [Key]
        public int StudioID { get; set; }
        public string Name { get; set; }

        public ICollection<Media> Media { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
