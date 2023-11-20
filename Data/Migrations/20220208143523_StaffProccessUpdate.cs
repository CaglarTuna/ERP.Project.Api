using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class StaffProccessUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Hour",
                table: "StaffProcess",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Minute",
                table: "StaffProcess",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Second",
                table: "StaffProcess",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hour",
                table: "StaffProcess");

            migrationBuilder.DropColumn(
                name: "Minute",
                table: "StaffProcess");

            migrationBuilder.DropColumn(
                name: "Second",
                table: "StaffProcess");
        }
    }
}
