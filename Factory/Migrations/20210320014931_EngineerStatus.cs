using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class EngineerStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EngineerStatus",
                table: "Engineers",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EngineerStatus",
                table: "Engineers");
        }
    }
}
