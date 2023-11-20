using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class staffProccess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_StaffProcess_StaffId_ProcessId",
                table: "StaffProcess");

            migrationBuilder.CreateIndex(
                name: "IX_StaffProcess_Id",
                table: "StaffProcess",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StaffProcess_StaffId",
                table: "StaffProcess",
                column: "StaffId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_StaffProcess_Id",
                table: "StaffProcess");

            migrationBuilder.DropIndex(
                name: "IX_StaffProcess_StaffId",
                table: "StaffProcess");

            migrationBuilder.CreateIndex(
                name: "IX_StaffProcess_StaffId_ProcessId",
                table: "StaffProcess",
                columns: new[] { "StaffId", "ProcessId" },
                unique: true,
                filter: "[StaffId] IS NOT NULL AND [ProcessId] IS NOT NULL");
        }
    }
}
