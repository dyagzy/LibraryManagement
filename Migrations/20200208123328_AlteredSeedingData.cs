using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagement.Migrations
{
    public partial class AlteredSeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Libraries",
                columns: new[] { "Id", "Department", "NameofAuthor", "Title" },
                values: new object[] { 2, 4, "Frank   Ayaosi ", "Structures Engineering for beginners" });

            migrationBuilder.InsertData(
                table: "Libraries",
                columns: new[] { "Id", "Department", "NameofAuthor", "Title" },
                values: new object[] { 3, 2, "Okundamiya Michael", "Circuit Theorem" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
