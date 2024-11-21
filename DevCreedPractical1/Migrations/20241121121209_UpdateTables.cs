using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevCreedPractical1.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TablePosts_TableBlogs_BlogId",
                schema: "Blogging",
                table: "TablePosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TablePosts",
                schema: "Blogging",
                table: "TablePosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TableBlogs",
                schema: "Blogging",
                table: "TableBlogs");

            migrationBuilder.DropColumn(
                name: "Id",
                schema: "Blogging",
                table: "TablePosts");

            migrationBuilder.DropColumn(
                name: "Id",
                schema: "Blogging",
                table: "TableBlogs");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "Blogging",
                table: "TablePosts",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "BlogId",
                schema: "Blogging",
                table: "TablePosts",
                newName: "Blog_Id");

            migrationBuilder.RenameIndex(
                name: "IX_TablePosts_BlogId",
                schema: "Blogging",
                table: "TablePosts",
                newName: "IX_TablePosts_Blog_Id");

            migrationBuilder.RenameColumn(
                name: "Url",
                schema: "Blogging",
                table: "TableBlogs",
                newName: "Blog_Url");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                schema: "Blogging",
                table: "TablePosts",
                type: "NVARCHAR(500)",
                nullable: false,
                defaultValueSql: "CONCAT([Title], '`s Content')",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                schema: "Blogging",
                table: "TablePosts",
                type: "NVARCHAR(50)",
                nullable: false,
                defaultValue: "Post Name",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Post_Id",
                schema: "Blogging",
                table: "TablePosts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "this is the primary key")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "ExcludedProp",
                schema: "Blogging",
                table: "TablePosts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Blog_Url",
                schema: "Blogging",
                table: "TableBlogs",
                type: "NVARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Blog_Id",
                schema: "Blogging",
                table: "TableBlogs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "this is the primary key")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "ComputedProp",
                schema: "Blogging",
                table: "TablePosts",
                type: "nvarchar(max)",
                nullable: false,
                computedColumnSql: "'title is: ' + [Title] + ', ' + 'content is: ' + [Content]");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostId",
                schema: "Blogging",
                table: "TablePosts",
                column: "Post_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogId",
                schema: "Blogging",
                table: "TableBlogs",
                column: "Blog_Id");

            migrationBuilder.CreateTable(
                name: "tblBookmarkedPosts",
                columns: table => new
                {
                    FirstId = table.Column<int>(type: "int", nullable: false),
                    SecondId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBookmarkedPosts", x => new { x.FirstId, x.SecondId });
                });

            migrationBuilder.AddForeignKey(
                name: "FK_TablePosts_TableBlogs_Blog_Id",
                schema: "Blogging",
                table: "TablePosts",
                column: "Blog_Id",
                principalSchema: "Blogging",
                principalTable: "TableBlogs",
                principalColumn: "Blog_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TablePosts_TableBlogs_Blog_Id",
                schema: "Blogging",
                table: "TablePosts");

            migrationBuilder.DropTable(
                name: "tblBookmarkedPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostId",
                schema: "Blogging",
                table: "TablePosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogId",
                schema: "Blogging",
                table: "TableBlogs");

            migrationBuilder.DropColumn(
                name: "ComputedProp",
                schema: "Blogging",
                table: "TablePosts");

            migrationBuilder.DropColumn(
                name: "Post_Id",
                schema: "Blogging",
                table: "TablePosts");

            migrationBuilder.DropColumn(
                name: "ExcludedProp",
                schema: "Blogging",
                table: "TablePosts");

            migrationBuilder.DropColumn(
                name: "Blog_Id",
                schema: "Blogging",
                table: "TableBlogs");

            migrationBuilder.RenameColumn(
                name: "Title",
                schema: "Blogging",
                table: "TablePosts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Blog_Id",
                schema: "Blogging",
                table: "TablePosts",
                newName: "BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_TablePosts_Blog_Id",
                schema: "Blogging",
                table: "TablePosts",
                newName: "IX_TablePosts_BlogId");

            migrationBuilder.RenameColumn(
                name: "Blog_Url",
                schema: "Blogging",
                table: "TableBlogs",
                newName: "Url");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                schema: "Blogging",
                table: "TablePosts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(500)",
                oldDefaultValueSql: "CONCAT([Title], '`s Content')");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Blogging",
                table: "TablePosts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(50)",
                oldDefaultValue: "Post Name");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                schema: "Blogging",
                table: "TablePosts",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                schema: "Blogging",
                table: "TableBlogs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(50)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                schema: "Blogging",
                table: "TableBlogs",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TablePosts",
                schema: "Blogging",
                table: "TablePosts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TableBlogs",
                schema: "Blogging",
                table: "TableBlogs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TablePosts_TableBlogs_BlogId",
                schema: "Blogging",
                table: "TablePosts",
                column: "BlogId",
                principalSchema: "Blogging",
                principalTable: "TableBlogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
