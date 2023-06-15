using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SavingFileDb.Migrations
{
    public partial class Addfieldtofile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "Files",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Files");
        }
    }
}
