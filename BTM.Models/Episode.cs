using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.Models
{
    public class Episode
    {
        [Key]
        public int EpisodeID { get; set; }
        public string Synopsis { get; set; }

        [Column(TypeName = "date")]
        public DateTime ReleasedTime { get; set; }

        [ForeignKey("Season")]
        public int SeasonID { get; set; }
        public Season Season { get; set; }
    }
}
