using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoList.Migrations
{
    /// <inheritdoc />
    public partial class DataAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4);
        }
    }
}
