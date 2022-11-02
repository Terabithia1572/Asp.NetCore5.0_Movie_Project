using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class MovieExtra
    {
        [Key]
        public int MovieExtraID { get; set; }
        public string MovieQuality { get; set; }
        public int MovieAge { get; set; }
        public bool MovieExtraStatus { get; set; }
    }
}
