using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.Models
{
    public class Media
    {
        [Key]
        public int MediaID { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }

        [Column(TypeName = "date")]
        public DateTime ReleaseDate { get; set; }
        public double Budget { get; set; }
        public double WorldwideGross { get; set; }
        public int Duration { get; set; }
        public string Director { get; set; }

        //// Many-to-many
        //public ICollection<Genre> Genres { get; set; }
        //public ICollection<Country> Countries { get; set; }
        //public ICollection<Language> Languages { get; set; }
        //public ICollection<PlotKeywords> Keywords { get; set; }
        //public ICollection<Soundtrack> Soundtracks { get; set; }
        //public ICollection<List> Lists { get; set; }

        //// Many-to-one
        //public ICollection<Image> Images { get; set; }
        //public ICollection<Award> Awards { get; set; }
        //public ICollection<Season> Seasons { get; set; }
        //public ICollection<Trailer> Trailers { get; set; }

        //// One-to-many
        //[ForeignKey("MPAARating")]
        //public int MPAARatingID { get; set; }
        //public MPAARating Rating { get; set; }

        [ForeignKey("Studio")]
        public int StudioID { get; set; }
        public Studio Studio { get; set; }

        [ForeignKey("Rating")]
        public int RatingID { get; set; }
        public MPAARating Rating { get; set; }

        public override string ToString()
        {
            return $"{Title} ({ReleaseDate.Year})";
        }
    }
}
