using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class OrderProductStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequestStatuId",
                table: "MaterialSupplyRequests");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "OrderProducts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_StatusId",
                table: "OrderProducts",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_Statuses_StatusId",
                table: "OrderProducts",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_Statuses_StatusId",
                table: "OrderProducts");

            migrationBuilder.DropIndex(
                name: "IX_OrderProducts_StatusId",
                table: "OrderProducts");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "OrderProducts");

            migrationBuilder.AddColumn<int>(
                name: "RequestStatuId",
                table: "MaterialSupplyRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
