using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ProcessLang1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProcessLanguages_Staffs_StaffsId",
                table: "ProcessLanguages");

            migrationBuilder.DropIndex(
                name: "IX_ProcessLanguages_LanguageId_ProcessId",
                table: "ProcessLanguages");

            migrationBuilder.DropIndex(
                name: "IX_ProcessLanguages_StaffsId",
                table: "ProcessLanguages");

            migrationBuilder.DropColumn(
                name: "StaffsId",
                table: "ProcessLanguages");

    



        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProcessLanguages_Staffs_StaffId",
                table: "ProcessLanguages");

            migrationBuilder.DropIndex(
                name: "IX_ProcessLanguages_StaffId_ProcessId",
                table: "ProcessLanguages");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "ProcessLanguages");

            migrationBuilder.AddColumn<int>(
                name: "StaffsId",
                table: "ProcessLanguages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProcessLanguages_LanguageId_ProcessId",
                table: "ProcessLanguages",
                columns: new[] { "LanguageId", "ProcessId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProcessLanguages_StaffsId",
                table: "ProcessLanguages",
                column: "StaffsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProcessLanguages_Staffs_StaffsId",
                table: "ProcessLanguages",
                column: "StaffsId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
