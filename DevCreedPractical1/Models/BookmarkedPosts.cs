using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCreedPractical1.Models
{
    [PrimaryKey("FirstId", "SecondId")]
    internal class BookmarkedPosts
    {
        public int FirstId { get; set; }
        public int SecondId { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
