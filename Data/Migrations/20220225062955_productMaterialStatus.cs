using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class productMaterialStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "ProductMaterials",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductMaterials_StatusId",
                table: "ProductMaterials",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductMaterials_Statuses_StatusId",
                table: "ProductMaterials",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductMaterials_Statuses_StatusId",
                table: "ProductMaterials");

            migrationBuilder.DropIndex(
                name: "IX_ProductMaterials_StatusId",
                table: "ProductMaterials");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "ProductMaterials");
        }
    }
}
