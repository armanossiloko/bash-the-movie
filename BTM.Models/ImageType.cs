using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.Models
{
    public class ImageType
    {
        [Key]
        public int ImageTypeID { get; set; }
        public string Name { get; set; }

        public ICollection<Image> Images { get; set; }
    }
}
