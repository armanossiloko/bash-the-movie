using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.Models
{
    public class PlotKeywords
    {
        [Key]
        public int KeywordID { get; set; }
        public string KeywordName { get; set; }

        public override string ToString()
        {
            return KeywordName;
        }

        //public ICollection<Media> Media { get; set; }
    }
}
