using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.Models
{
    public class MediaGenre
    {
        [ForeignKey("Media")]
        public int MediaID { get; set; }
        public Media Media { get; set; }
    
        [ForeignKey("Genre")]
        public int GenreID { get; set; }
        public Genre Genre { get; set; }
    }
}
