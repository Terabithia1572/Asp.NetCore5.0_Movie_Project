using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class MovieExtra
    {
        [Key]
        public int MovieExtraID { get; set; }
        public string MovieQuality { get; set; }
        public int MovieAge { get; set; }
        public bool MovieExtraStatus { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
