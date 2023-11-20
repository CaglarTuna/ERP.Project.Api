using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class shape : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_MaterialShapes_MaterialShapeId",
                table: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_MaterialShapes_Id",
                table: "MaterialShapes");

            migrationBuilder.DropIndex(
                name: "IX_Materials_MaterialShapeId",
                table: "Materials");

            migrationBuilder.RenameColumn(
                name: "MaterialShapeId",
                table: "Materials",
                newName: "ShapeId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialShapes_Id",
                table: "MaterialShapes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_ShapeId",
                table: "Materials",
                column: "ShapeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_MaterialShapes_ShapeId",
                table: "Materials",
                column: "ShapeId",
                principalTable: "MaterialShapes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_MaterialShapes_ShapeId",
                table: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_MaterialShapes_Id",
                table: "MaterialShapes");

            migrationBuilder.DropIndex(
                name: "IX_Materials_ShapeId",
                table: "Materials");

            migrationBuilder.RenameColumn(
                name: "ShapeId",
                table: "Materials",
                newName: "MaterialShapeId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialShapes_Id",
                table: "MaterialShapes",
                column: "Id",
                unique: true);

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
    }
}
