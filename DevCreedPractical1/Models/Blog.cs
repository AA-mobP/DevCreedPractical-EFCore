﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCreedPractical1.Models
{
    internal class Blog
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public List<Post> Posts { get; set; }
    }
}
