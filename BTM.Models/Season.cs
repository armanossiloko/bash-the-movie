using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.Models
{
    public class Season
    {
        [Key]
        public int SeasonID { get; set; }
        public string Name { get; set; }
        public int SeasonNumber { get; set; }
        public int YearOfRelease { get; set; }

        public ICollection<Episode> Episodes { get; set; }
    }
}
