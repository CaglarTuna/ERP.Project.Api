using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class todoIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TodoMembers_StaffId_TodoId",
                table: "TodoMembers");

            migrationBuilder.CreateIndex(
                name: "IX_TodoMembers_Id",
                table: "TodoMembers",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TodoMembers_StaffId",
                table: "TodoMembers",
                column: "StaffId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TodoMembers_Id",
                table: "TodoMembers");

            migrationBuilder.DropIndex(
                name: "IX_TodoMembers_StaffId",
                table: "TodoMembers");

            migrationBuilder.CreateIndex(
                name: "IX_TodoMembers_StaffId_TodoId",
                table: "TodoMembers",
                columns: new[] { "StaffId", "TodoId" },
                unique: true,
                filter: "[StaffId] IS NOT NULL AND [TodoId] IS NOT NULL");
        }
    }
}
