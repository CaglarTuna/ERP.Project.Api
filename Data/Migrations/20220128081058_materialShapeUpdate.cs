using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class materialShapeUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialShapes_Materials_MaterialId",
                table: "MaterialShapes");

            migrationBuilder.DropIndex(
                name: "IX_MaterialShapes_MaterialId",
                table: "MaterialShapes");

            migrationBuilder.DropColumn(
                name: "MaterialId",
                table: "MaterialShapes");

            migrationBuilder.AddColumn<int>(
                name: "MaterialShapeId",
                table: "Materials",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materials_MaterialShapeId",
                table: "Materials",
                column: "MaterialShapeId",
                unique: true,
                filter: "[MaterialShapeId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_MaterialShapes_MaterialShapeId",
                table: "Materials",
                column: "MaterialShapeId",
                principalTable: "MaterialShapes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_MaterialShapes_MaterialShapeId",
                table: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_Materials_MaterialShapeId",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "MaterialShapeId",
                table: "Materials");

            migrationBuilder.AddColumn<int>(
                name: "MaterialId",
                table: "MaterialShapes",
                type: "int",
                nullable: true);

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
                onDelete: ReferentialAction.Restrict);
        }
    }
}
