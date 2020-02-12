using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagement.Migrations
{
    public partial class MoreSeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Libraries",
                columns: new[] { "Id", "Department", "NameofAuthor", "Title" },
                values: new object[] { 4, 5, "James John", "Principles of Economics" });

            migrationBuilder.InsertData(
                table: "Libraries",
                columns: new[] { "Id", "Department", "NameofAuthor", "Title" },
                values: new object[] { 5, 4, "Nkem Ijeoma ", "Drawings for Engineers" });

            migrationBuilder.InsertData(
                table: "Libraries",
                columns: new[] { "Id", "Department", "NameofAuthor", "Title" },
                values: new object[] { 6, 2, "Egwale Francis", "Project Defense" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "Libraries",
                columns: new[] { "Id", "Department", "NameofAuthor", "Title" },
                values: new object[] { 1, 5, "Mark Olami", "A-Z of Accounting" });

            migrationBuilder.InsertData(
                table: "Libraries",
                columns: new[] { "Id", "Department", "NameofAuthor", "Title" },
                values: new object[] { 2, 4, "Frank   Ayaosi ", "Structures Engineering for beginners" });

            migrationBuilder.InsertData(
                table: "Libraries",
                columns: new[] { "Id", "Department", "NameofAuthor", "Title" },
                values: new object[] { 3, 2, "Okundamiya Michael", "Circuit Theorem" });
        }
    }
}
