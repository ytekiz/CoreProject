using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Blog
    {
        [Key]
        public int BlogID{ get; set; }
        public string BlogTiitle{ get; set; }
        public string BlogContent{ get; set; }
        public string BlogThumbnailImage{ get; set; }
        public string BlogImage{ get; set; }
        public DateTime BlogCrateDate{ get; set; }
        public string BlogStatus{ get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        //public int CommentID { get; set; }
        //public virtual Comment Comment{ get; set; }

        public List<Comment> Comments { get; set; }

    }
}
