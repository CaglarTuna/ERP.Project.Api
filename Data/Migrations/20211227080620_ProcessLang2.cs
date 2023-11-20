using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ProcessLang2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


  

    

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProcessLanguages_Staffs_StaffsId",
                table: "ProcessLanguages");

            migrationBuilder.DropIndex(
                name: "IX_ProcessLanguages_ProcessId",
                table: "ProcessLanguages");

            migrationBuilder.DropIndex(
                name: "IX_ProcessLanguages_StaffsId",
                table: "ProcessLanguages");

            migrationBuilder.DropColumn(
                name: "StaffsId",
                table: "ProcessLanguages");

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "ProcessLanguages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProcessLanguages_ProcessId",
                table: "ProcessLanguages",
                column: "ProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessLanguages_StaffId_ProcessId",
                table: "ProcessLanguages",
                columns: new[] { "StaffId", "ProcessId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProcessLanguages_Staffs_StaffId",
                table: "ProcessLanguages",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
