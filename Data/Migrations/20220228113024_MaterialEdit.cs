using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class MaterialEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HeightMeasureId",
                table: "Materials",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materials_HeightMeasureId",
                table: "Materials",
                column: "HeightMeasureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_HeightMeasures_HeightMeasureId",
                table: "Materials",
                column: "HeightMeasureId",
                principalTable: "HeightMeasures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_HeightMeasures_HeightMeasureId",
                table: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_Materials_HeightMeasureId",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "HeightMeasureId",
                table: "Materials");
        }
    }
}
