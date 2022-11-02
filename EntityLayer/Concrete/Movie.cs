using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        public string MovieTitle { get; set; }
        public string MovieDescription { get; set; }
        public DateTime MovieReleaseDate { get; set; }
        public int MovieTime { get; set; }
        public string MovieCountry { get; set; }
        public string MovieTrailer { get; set; }
        public int MovieStars { get; set; }
        public bool MovieStatus { get; set; }

    }
}
