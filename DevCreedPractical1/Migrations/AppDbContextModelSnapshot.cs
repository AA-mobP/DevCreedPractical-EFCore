﻿// <auto-generated />
using System;
using DevCreedPractical1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DevCreedPractical1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DevCreedPractical1.Models.Blog", b =>
                {
                    b.Property<int>("Blog_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("this is the primary key");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Blog_Id"));

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)")
                        .HasColumnName("Blog_Url");

                    b.HasKey("Blog_Id")
                        .HasName("PK_BlogId");

                    b.ToTable("TableBlogs", "Blogging");
                });

            modelBuilder.Entity("DevCreedPractical1.Models.BookmarkedPosts", b =>
                {
                    b.Property<int>("FirstId")
                        .HasColumnType("int");

                    b.Property<int>("SecondId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("FirstId", "SecondId");

                    b.ToTable("tblBookmarkedPosts");
                });

            modelBuilder.Entity("DevCreedPractical1.Models.Post", b =>
                {
                    b.Property<int>("Post_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("this is the primary key");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Post_Id"));

                    b.Property<int>("Blog_Id")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(500)");

                    b.Property<string>("ExcludedProp")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)")
                        .HasColumnName("Title");

                    b.HasKey("Post_Id")
                        .HasName("PK_PostId");

                    b.HasIndex("Blog_Id");

                    b.ToTable("TablePosts", "Blogging");
                });

            modelBuilder.Entity("DevCreedPractical1.Models.Post", b =>
                {
                    b.HasOne("DevCreedPractical1.Models.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("Blog_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("DevCreedPractical1.Models.Blog", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
