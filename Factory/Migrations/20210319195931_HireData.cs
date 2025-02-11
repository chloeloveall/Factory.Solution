﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class HireData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "HireDate",
                table: "Engineers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HireDate",
                table: "Engineers");
        }
    }
}
