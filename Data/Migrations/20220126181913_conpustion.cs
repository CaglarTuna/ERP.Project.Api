using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class conpustion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConsumptionMaterials_UnitsOfMeasure_ConsumptionUnitId",
                table: "ConsumptionMaterials");

            migrationBuilder.DropIndex(
                name: "IX_ConsumptionMaterials_ConsumptionUnitId",
                table: "ConsumptionMaterials");

            migrationBuilder.DropColumn(
                name: "ConsumptionUnitId",
                table: "ConsumptionMaterials");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConsumptionUnitId",
                table: "ConsumptionMaterials",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ConsumptionMaterials_ConsumptionUnitId",
                table: "ConsumptionMaterials",
                column: "ConsumptionUnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConsumptionMaterials_UnitsOfMeasure_ConsumptionUnitId",
                table: "ConsumptionMaterials",
                column: "ConsumptionUnitId",
                principalTable: "UnitsOfMeasure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
