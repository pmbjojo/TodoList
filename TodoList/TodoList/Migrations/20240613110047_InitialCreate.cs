using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoList.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Todos",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Todos");

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Author", "Description", "Status", "Title" },
                values: new object[,]
                {
                    { 1, "Admin", "This is a sample post 1", 2, "Sample Post 1" },
                    { 2, "Admin", "This is a sample post 2", 2, "Sample Post 2" },
                    { 3, "Admin", "This is a sample post 3", 2, "Sample Post 3" },
                    { 4, "Admin", "This is a sample post 4", 2, "Sample Post 4" }
                });
        }
    }
}
