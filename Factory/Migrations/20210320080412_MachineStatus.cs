using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class MachineStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MachineStatus",
                table: "Machines",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MachineStatus",
                table: "Machines");
        }
    }
}
