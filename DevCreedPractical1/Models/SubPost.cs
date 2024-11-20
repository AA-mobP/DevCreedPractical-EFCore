using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCreedPractical1.Models
{
    internal class SubPost
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public Post Post { get; set; }
    }
}
