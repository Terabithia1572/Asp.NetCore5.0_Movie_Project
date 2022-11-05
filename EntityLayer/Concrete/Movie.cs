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
        public string MovieImage { get; set; }
        public DateTime MovieReleaseDate { get; set; }
        public DateTime MovieTime { get; set; }
        public string MovieCountry { get; set; }
        public string MovieTrailer { get; set; }
        public string MovieTabIndex { get; set; }
        public double MovieStars { get; set; }
        public bool MovieStatus { get; set; }
        public int MovieExtraID { get; set; }
        public MovieExtra MovieExtra { get; set; }
        public int CategoryID { get; set; } //ilişkili tabloda
        //ilişkili tabloda tutulacak ID
        public Category Category { get; set; }

    }
}
