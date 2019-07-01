using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.Models
{
    public class MediaList
    {
        [ForeignKey("Media")]
        public int MediaID { get; set; }
        public Media Media { get; set; }

        [ForeignKey("List")]
        public int ListID { get; set; }
        public List List { get; set; }
    }
}
