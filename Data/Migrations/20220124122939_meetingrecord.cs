using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class meetingrecord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "MeetingRecord",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MeetingRecord_OrderId",
                table: "MeetingRecord",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingRecord_Orders_OrderId",
                table: "MeetingRecord",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MeetingRecord_Orders_OrderId",
                table: "MeetingRecord");

            migrationBuilder.DropIndex(
                name: "IX_MeetingRecord_OrderId",
                table: "MeetingRecord");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "MeetingRecord");
        }
    }
}
