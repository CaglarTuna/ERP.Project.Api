using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class del : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProcessLanguages_Languages_LanguagesId",
                table: "ProcessLanguages");

            migrationBuilder.DropIndex(
                name: "IX_ProcessLanguages_LanguagesId",
                table: "ProcessLanguages");

            migrationBuilder.DropColumn(
                name: "LanguagesId",
                table: "ProcessLanguages");




        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProcessLanguages_Languages_LanguageId",
                table: "ProcessLanguages");

            migrationBuilder.DropIndex(
                name: "IX_ProcessLanguages_LanguageId_ProcessId",
                table: "ProcessLanguages");

            migrationBuilder.AddColumn<int>(
                name: "LanguagesId",
                table: "ProcessLanguages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProcessLanguages_LanguagesId",
                table: "ProcessLanguages",
                column: "LanguagesId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProcessLanguages_Languages_LanguagesId",
                table: "ProcessLanguages",
                column: "LanguagesId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
