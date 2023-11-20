using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class MaterialCertificate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "MaterialCertificates",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MaterialCertificates_CompanyId",
                table: "MaterialCertificates",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialCertificates_Companies_CompanyId",
                table: "MaterialCertificates",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialCertificates_Companies_CompanyId",
                table: "MaterialCertificates");

            migrationBuilder.DropIndex(
                name: "IX_MaterialCertificates_CompanyId",
                table: "MaterialCertificates");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "MaterialCertificates");
        }
    }
}
