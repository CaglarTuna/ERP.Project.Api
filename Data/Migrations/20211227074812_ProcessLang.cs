using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ProcessLang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProcessLanguages_Staffs_StaffId",
                table: "ProcessLanguages");

            migrationBuilder.RenameColumn(
                name: "StaffId",
                table: "ProcessLanguages",
                newName: "LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_ProcessLanguages_StaffId_ProcessId",
                table: "ProcessLanguages",
                newName: "IX_ProcessLanguages_LanguageId_ProcessId");

            migrationBuilder.AddColumn<int>(
                name: "LanguagesId",
                table: "ProcessLanguages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StaffsId",
                table: "ProcessLanguages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProcessLanguages_LanguagesId",
                table: "ProcessLanguages",
                column: "LanguagesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessLanguages_StaffsId",
                table: "ProcessLanguages",
                column: "StaffsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProcessLanguages_Languages_LanguagesId",
                table: "ProcessLanguages",
                column: "LanguagesId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProcessLanguages_Staffs_StaffsId",
                table: "ProcessLanguages",
                column: "StaffsId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProcessLanguages_Languages_LanguagesId",
                table: "ProcessLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProcessLanguages_Staffs_StaffsId",
                table: "ProcessLanguages");

            migrationBuilder.DropIndex(
                name: "IX_ProcessLanguages_LanguagesId",
                table: "ProcessLanguages");

            migrationBuilder.DropIndex(
                name: "IX_ProcessLanguages_StaffsId",
                table: "ProcessLanguages");

            migrationBuilder.DropColumn(
                name: "LanguagesId",
                table: "ProcessLanguages");

            migrationBuilder.DropColumn(
                name: "StaffsId",
                table: "ProcessLanguages");

            migrationBuilder.RenameColumn(
                name: "LanguageId",
                table: "ProcessLanguages",
                newName: "StaffId");

            migrationBuilder.RenameIndex(
                name: "IX_ProcessLanguages_LanguageId_ProcessId",
                table: "ProcessLanguages",
                newName: "IX_ProcessLanguages_StaffId_ProcessId");

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
