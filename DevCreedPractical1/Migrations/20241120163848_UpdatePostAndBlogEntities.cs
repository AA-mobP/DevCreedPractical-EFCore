using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevCreedPractical1.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePostAndBlogEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblPosts_tblBlogs_BlogId",
                table: "tblPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblPosts",
                table: "tblPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblBlogs",
                table: "tblBlogs");

            migrationBuilder.EnsureSchema(
                name: "Blogging");

            migrationBuilder.RenameTable(
                name: "tblPosts",
                newName: "TablePosts",
                newSchema: "Blogging");

            migrationBuilder.RenameTable(
                name: "tblBlogs",
                newName: "TableBlogs",
                newSchema: "Blogging");

            migrationBuilder.RenameIndex(
                name: "IX_tblPosts_BlogId",
                schema: "Blogging",
                table: "TablePosts",
                newName: "IX_TablePosts_BlogId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameTable(
                name: "TablePosts",
                schema: "Blogging",
                newName: "tblPosts");

            migrationBuilder.RenameTable(
                name: "TableBlogs",
                schema: "Blogging",
                newName: "tblBlogs");

            migrationBuilder.RenameIndex(
                name: "IX_TablePosts_BlogId",
                table: "tblPosts",
                newName: "IX_tblPosts_BlogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblPosts",
                table: "tblPosts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblBlogs",
                table: "tblBlogs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tblPosts_tblBlogs_BlogId",
                table: "tblPosts",
                column: "BlogId",
                principalTable: "tblBlogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
