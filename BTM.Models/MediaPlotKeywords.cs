using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BTM.Models
{
    public class MediaPlotKeywords
    {
        [ForeignKey("Media")]
        public int MediaID { get; set; }
        public Media Media { get; set; }

        [ForeignKey("PlotKeywords")]
        public int KeywordID { get; set; }
        public PlotKeywords Keyword { get; set; }
    }
}
