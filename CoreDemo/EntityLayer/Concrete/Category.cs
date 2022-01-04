using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Category
    {
        [Key]
        public int CatagoryID { get; set; }
        public string CatagoryName { get; set; }
        public string CatagoryDescription { get; set; }
        public bool CatagoryStatus { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
