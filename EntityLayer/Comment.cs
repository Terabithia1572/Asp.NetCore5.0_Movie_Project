using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public int CommentLike { get; set; }
        public int CommentUnLike { get; set; }
        public bool CommentStatus { get; set; }
    }

}
