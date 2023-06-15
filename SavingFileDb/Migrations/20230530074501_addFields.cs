using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SavingFileDb.Migrations
{
    public partial class addFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UpdatedByLogin",
                table: "Files",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedIn",
                table: "Files",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedByLogin",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "UpdatedIn",
                table: "Files");
        }
    }
}
