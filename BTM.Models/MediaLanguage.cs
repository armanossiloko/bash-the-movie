using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.Models
{
    public class MediaLanguage
    {
        [ForeignKey("Media")]
        public int MediaID { get; set; }
        public Media Media { get; set; }

        [ForeignKey("Language")]
        public int LanguageID { get; set; }
        public Language Language { get; set; }
    }
}
