using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCreedPractical1.Models
{
    internal class Post
    {
        public int Post_Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string ExcludedProp { get; set; }

        public Blog Blog { get; set; }
        public List<SubPost> SubPosts { get; set; }
    }
}
