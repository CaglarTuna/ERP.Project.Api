using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class supplystatu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RequestStatuId",
                table: "MaterialSupplyRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SuplyStatuId",
                table: "MaterialSupplyRequests",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MaterialSupplyStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSupplyStatus", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSupplyRequests_SuplyStatuId",
                table: "MaterialSupplyRequests",
                column: "SuplyStatuId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSupplyStatus_Id",
                table: "MaterialSupplyStatus",
                column: "Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialSupplyRequests_MaterialSupplyStatus_SuplyStatuId",
                table: "MaterialSupplyRequests",
                column: "SuplyStatuId",
                principalTable: "MaterialSupplyStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialSupplyRequests_MaterialSupplyStatus_SuplyStatuId",
                table: "MaterialSupplyRequests");

            migrationBuilder.DropTable(
                name: "MaterialSupplyStatus");

            migrationBuilder.DropIndex(
                name: "IX_MaterialSupplyRequests_SuplyStatuId",
                table: "MaterialSupplyRequests");

            migrationBuilder.DropColumn(
                name: "RequestStatuId",
                table: "MaterialSupplyRequests");

            migrationBuilder.DropColumn(
                name: "SuplyStatuId",
                table: "MaterialSupplyRequests");
        }
    }
}
