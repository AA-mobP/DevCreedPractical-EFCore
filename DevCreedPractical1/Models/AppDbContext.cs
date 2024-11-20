using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCreedPractical1.Models
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Blog> tblBlogs { get; set; }
        public DbSet<Post> tblPosts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-ECE5S76\\SQL2022;Initial Catalog=DevCreedPracticalEFCore;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().Ignore(p => p.SubPosts);
            modelBuilder.Entity<Post>().ToTable("TablePosts", schema: "Blogging");
            modelBuilder.Entity<Post>().Property(p => p.Name).IsRequired();
            modelBuilder.Entity<Post>().Property(p => p.Content).IsRequired();
            modelBuilder.Entity<Post>().Ignore(p => p.ExcludedProp);
            modelBuilder.Entity<Post>().Property(p => p.Name).HasColumnName("Title");
            base.OnModelCreating(modelBuilder);
        }
    }
}
