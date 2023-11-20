using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class consuptionStand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StandId",
                table: "ConsumptionMaterialStock",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ConsumptionMaterialStock_StandId",
                table: "ConsumptionMaterialStock",
                column: "StandId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConsumptionMaterialStock_Stands_StandId",
                table: "ConsumptionMaterialStock",
                column: "StandId",
                principalTable: "Stands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConsumptionMaterialStock_Stands_StandId",
                table: "ConsumptionMaterialStock");

            migrationBuilder.DropIndex(
                name: "IX_ConsumptionMaterialStock_StandId",
                table: "ConsumptionMaterialStock");

            migrationBuilder.DropColumn(
                name: "StandId",
                table: "ConsumptionMaterialStock");
        }
    }
}
