using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagement.Migrations
{
    public partial class SeedLibratyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Libraries",
                columns: new[] { "Id", "Department", "NameofAuthor", "Title" },
                values: new object[] { 1, 5, "Mark Olami", "A-Z of Accounting" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
