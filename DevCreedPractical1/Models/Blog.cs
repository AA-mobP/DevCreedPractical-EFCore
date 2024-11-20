using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCreedPractical1.Models
{
    [Table("TableBlogs", Schema = "Blogging")]
    internal class Blog
    {
        public int Id { get; set; }
        [Required, Column("Blog_Url", TypeName = "NVARCHAR(50)")]
        public string Url { get; set; }
        [NotMapped]
        public string ExcludedProp { get; set; }
        public List<Post> Posts { get; set; }
    }
}
