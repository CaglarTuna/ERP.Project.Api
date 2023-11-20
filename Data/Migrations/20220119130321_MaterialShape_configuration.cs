using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class MaterialShape_configuration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialShapes_Materials_MaterialsId",
                table: "MaterialShapes");

            migrationBuilder.DropIndex(
                name: "IX_MaterialShapes_MaterialsId",
                table: "MaterialShapes");

            migrationBuilder.DropColumn(
                name: "MaterialsId",
                table: "MaterialShapes");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialShapes_Id",
                table: "MaterialShapes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MaterialShapes_MaterialId",
                table: "MaterialShapes",
                column: "MaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialShapes_Materials_MaterialId",
                table: "MaterialShapes",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialShapes_Materials_MaterialId",
                table: "MaterialShapes");

            migrationBuilder.DropIndex(
                name: "IX_MaterialShapes_Id",
                table: "MaterialShapes");

            migrationBuilder.DropIndex(
                name: "IX_MaterialShapes_MaterialId",
                table: "MaterialShapes");

            migrationBuilder.AddColumn<int>(
                name: "MaterialsId",
                table: "MaterialShapes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MaterialShapes_MaterialsId",
                table: "MaterialShapes",
                column: "MaterialsId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialShapes_Materials_MaterialsId",
                table: "MaterialShapes",
                column: "MaterialsId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
