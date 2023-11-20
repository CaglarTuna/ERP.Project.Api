using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class OrderProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StaffProcess_Orders_OrderId",
                table: "StaffProcess");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "StaffProcess",
                newName: "OrderProductId");

            migrationBuilder.RenameIndex(
                name: "IX_StaffProcess_OrderId",
                table: "StaffProcess",
                newName: "IX_StaffProcess_OrderProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_StaffProcess_OrderProducts_OrderProductId",
                table: "StaffProcess",
                column: "OrderProductId",
                principalTable: "OrderProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StaffProcess_OrderProducts_OrderProductId",
                table: "StaffProcess");

            migrationBuilder.RenameColumn(
                name: "OrderProductId",
                table: "StaffProcess",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_StaffProcess_OrderProductId",
                table: "StaffProcess",
                newName: "IX_StaffProcess_OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_StaffProcess_Orders_OrderId",
                table: "StaffProcess",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
