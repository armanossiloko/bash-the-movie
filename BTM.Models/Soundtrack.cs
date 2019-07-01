using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.Models
{
    public class Soundtrack
    {
        [Key]
        public int SoundtrackID { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Location { get; set; }

        [ForeignKey("Media")]
        public int MediaID { get; set; }
        public Media Media { get; set; }

        //public ICollection<Media> Media { get; set; }
    }
}
