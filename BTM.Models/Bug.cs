using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.Models
{
    public class Bug
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public bool Resolved { get; set; }
        public DateTime DateAdded { get; set; }

        [EnumDataType(typeof(Priority))]
        public Priority Priority { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
