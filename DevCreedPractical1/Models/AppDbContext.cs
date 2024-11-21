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
        public DbSet<BookmarkedPosts> tblBookmarkedPosts { get; set; }
        public DbSet<ForTest> tblFortest { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-ECE5S76\\SQL2022;Initial Catalog=DevCreedPracticalEFCore;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>(options =>
            {
                options.HasKey(p => p.Blog_Id).HasName("PK_BlogId");
            });

            modelBuilder.Entity<Post>().Ignore(p => p.SubPosts);
            modelBuilder.Entity<Post>().ToTable("TablePosts", schema: "Blogging");
            modelBuilder.Entity<Post>().Ignore(p => p.ExcludedProp);
            modelBuilder.Entity<Post>(options =>
            {
                options.HasKey(p => p.Post_Id).HasName("PK_PostId");

                options.Property(p => p.Name).IsRequired();
                options.Property(p => p.Content).IsRequired();

                options.Property(p => p.Name).HasColumnType("NVARCHAR(50)");
                options.Property(p => p.Content).HasColumnType("NVARCHAR(500)");

                options.Property(p => p.Name).HasColumnName("Title");

                options.Property(p => p.ExcludedProp).HasMaxLength(50);

                options.Property(p => p.Name).HasDefaultValue("Post Name");
                options.Property(p => p.Content).HasDefaultValueSql("CONCAT('Content created in', GETDATE())");

                options.Property(p => p.ComputedProp).HasComputedColumnSql("'title is: ' + [Title] + ', ' + 'content is: ' + [Content]");

                options.Property(p => p.Post_Id).HasComment("this is the primary key");
            });

            modelBuilder.Entity<BookmarkedPosts>().HasKey(b => new { b.FirstId, b.SecondId });
        }
    }
}
