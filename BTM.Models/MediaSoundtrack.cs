using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.Models
{
    public class MediaSoundtrack
    {
        [ForeignKey("Media")]
        public int MediaID { get; set; }
        public Media Media { get; set; }

        [ForeignKey("Soundtrack")]
        public int SoundtrackID { get; set; }
        public Soundtrack Soundtrack { get; set; }
    }
}
