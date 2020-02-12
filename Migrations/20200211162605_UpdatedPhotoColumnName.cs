using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagement.Migrations
{
    public partial class UpdatedPhotoColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Photo",
                table: "Libraries",
                newName: "PhotoPath");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhotoPath",
                table: "Libraries",
                newName: "Photo");
        }
    }
}
