using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.Models
{
    public class Image
    {
        [Key]
        public int ImageID { get; set; }
        public string Location { get; set; }

        //[ForeignKey("ImageType")]
        //public int ImageTypeID { get; set; }
        //public ImageType Type { get; set; }

        [ForeignKey("Media")]
        public int MediaID { get; set; }
        public Media Media { get; set; }
    }
}
