
using DevCreedPractical1.Models;

namespace DevCreedPractical1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext context = new();
            Blog blog = new Blog { Url = "https://wwww.blogs.com" };
            
            context.tblBlogs.Add(blog);
            context.SaveChanges();
        }
    }
}