using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class orderNeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "MaterialExpertDeliverys",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrderNeeds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    MaterialId = table.Column<int>(type: "int", nullable: true),
                    Recruitment = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderNeeds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderNeeds_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderNeeds_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderNeeds_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaterialExpertDeliverys_OrderId",
                table: "MaterialExpertDeliverys",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderNeeds_Id",
                table: "OrderNeeds",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderNeeds_MaterialId",
                table: "OrderNeeds",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderNeeds_OrderId",
                table: "OrderNeeds",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderNeeds_ProductId",
                table: "OrderNeeds",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialExpertDeliverys_Orders_OrderId",
                table: "MaterialExpertDeliverys",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialExpertDeliverys_Orders_OrderId",
                table: "MaterialExpertDeliverys");

            migrationBuilder.DropTable(
                name: "OrderNeeds");

            migrationBuilder.DropIndex(
                name: "IX_MaterialExpertDeliverys_OrderId",
                table: "MaterialExpertDeliverys");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "MaterialExpertDeliverys");
        }
    }
}
