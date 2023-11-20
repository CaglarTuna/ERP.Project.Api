using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class consuptionOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "ConsumptionMaterialStock",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ConsumptionMaterialStock_OrderId",
                table: "ConsumptionMaterialStock",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConsumptionMaterialStock_Orders_OrderId",
                table: "ConsumptionMaterialStock",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConsumptionMaterialStock_Orders_OrderId",
                table: "ConsumptionMaterialStock");

            migrationBuilder.DropIndex(
                name: "IX_ConsumptionMaterialStock_OrderId",
                table: "ConsumptionMaterialStock");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "ConsumptionMaterialStock");
        }
    }
}
