using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class InstallationDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PurchaseDate",
                table: "Machines",
                newName: "InstallationDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InstallationDate",
                table: "Machines",
                newName: "PurchaseDate");
        }
    }
}
