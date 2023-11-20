using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class MaterialStockReletionsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_MaterialStock_CompanyId",
                table: "MaterialStock",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialStock_StoreId",
                table: "MaterialStock",
                column: "StoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialStock_Companies_CompanyId",
                table: "MaterialStock",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialStock_Stores_StoreId",
                table: "MaterialStock",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialStock_Companies_CompanyId",
                table: "MaterialStock");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialStock_Stores_StoreId",
                table: "MaterialStock");

            migrationBuilder.DropIndex(
                name: "IX_MaterialStock_CompanyId",
                table: "MaterialStock");

            migrationBuilder.DropIndex(
                name: "IX_MaterialStock_StoreId",
                table: "MaterialStock");
        }
    }
}
