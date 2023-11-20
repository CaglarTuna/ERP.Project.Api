using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class consuptionMaterial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeliveryNote",
                table: "ConsumptionMaterialStock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "ConsumptionMaterialStock",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ConsumptionMaterialStock_StaffId",
                table: "ConsumptionMaterialStock",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConsumptionMaterialStock_Staffs_StaffId",
                table: "ConsumptionMaterialStock",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConsumptionMaterialStock_Staffs_StaffId",
                table: "ConsumptionMaterialStock");

            migrationBuilder.DropIndex(
                name: "IX_ConsumptionMaterialStock_StaffId",
                table: "ConsumptionMaterialStock");

            migrationBuilder.DropColumn(
                name: "DeliveryNote",
                table: "ConsumptionMaterialStock");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "ConsumptionMaterialStock");
        }
    }
}
