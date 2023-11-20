using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class staffProc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "StaffProcess",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StaffProcess_OrderId",
                table: "StaffProcess",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_StaffProcess_Orders_OrderId",
                table: "StaffProcess",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StaffProcess_Orders_OrderId",
                table: "StaffProcess");

            migrationBuilder.DropIndex(
                name: "IX_StaffProcess_OrderId",
                table: "StaffProcess");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "StaffProcess");
        }
    }
}
