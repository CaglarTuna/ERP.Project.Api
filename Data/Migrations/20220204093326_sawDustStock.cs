using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class sawDustStock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "SawdustStock",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "SawdustStock",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SawdustStock_CurrencyId",
                table: "SawdustStock",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_SawdustStock_OrderNo",
                table: "SawdustStock",
                column: "OrderNo");

            migrationBuilder.AddForeignKey(
                name: "FK_SawdustStock_Currencies_CurrencyId",
                table: "SawdustStock",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SawdustStock_Orders_OrderNo",
                table: "SawdustStock",
                column: "OrderNo",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SawdustStock_Currencies_CurrencyId",
                table: "SawdustStock");

            migrationBuilder.DropForeignKey(
                name: "FK_SawdustStock_Orders_OrderNo",
                table: "SawdustStock");

            migrationBuilder.DropIndex(
                name: "IX_SawdustStock_CurrencyId",
                table: "SawdustStock");

            migrationBuilder.DropIndex(
                name: "IX_SawdustStock_OrderNo",
                table: "SawdustStock");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "SawdustStock");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "SawdustStock");
        }
    }
}
