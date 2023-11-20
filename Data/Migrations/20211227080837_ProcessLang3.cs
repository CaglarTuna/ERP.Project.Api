using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ProcessLang3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StaffsId",
                table: "ProcessLanguages",
                type: "int",
                nullable: true);

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
