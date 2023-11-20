using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class orderStaff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeliveryNote",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DellveryStaffId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Receiver",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DellveryStaffId",
                table: "Orders",
                column: "DellveryStaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Staffs_DellveryStaffId",
                table: "Orders",
                column: "DellveryStaffId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Staffs_DellveryStaffId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_DellveryStaffId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DeliveryNote",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DellveryStaffId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Receiver",
                table: "Orders");
        }
    }
}
