using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.Models
{
    public class Language
    {
        [Key]
        public int LanguageID { get; set; }
        public string LanguageName { get; set; }

        //public ICollection<Media> Media { get; set; }
        public override string ToString()
        {
            return LanguageName;
        }
    }
}
