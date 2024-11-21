using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevCreedPractical1.Migrations
{
    /// <inheritdoc />
    public partial class updateTables2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Post_Id",
                schema: "Blogging",
                table: "TablePosts",
                type: "tinyint",
                nullable: false,
                comment: "this is the primary key",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "this is the primary key")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateTable(
                name: "tblFortest",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblFortest", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblFortest");

            migrationBuilder.AlterColumn<int>(
                name: "Post_Id",
                schema: "Blogging",
                table: "TablePosts",
                type: "int",
                nullable: false,
                comment: "this is the primary key",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldComment: "this is the primary key")
                .Annotation("SqlServer:Identity", "1, 1");
        }
    }
}
