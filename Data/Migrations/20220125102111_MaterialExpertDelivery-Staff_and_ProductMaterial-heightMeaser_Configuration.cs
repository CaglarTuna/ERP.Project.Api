using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class MaterialExpertDeliveryStaff_and_ProductMaterialheightMeaser_Configuration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductMaterials_Products_ProductId",
                table: "ProductMaterials");

            migrationBuilder.AddColumn<int>(
                name: "HeightMeasureId",
                table: "ProductMaterials",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductsId",
                table: "ProductMaterials",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "MaterialExpertDeliverys",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductMaterials_HeightMeasureId",
                table: "ProductMaterials",
                column: "HeightMeasureId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMaterials_ProductsId",
                table: "ProductMaterials",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialExpertDeliverys_StaffId",
                table: "MaterialExpertDeliverys",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialExpertDeliverys_Staffs_StaffId",
                table: "MaterialExpertDeliverys",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductMaterials_HeightMeasures_HeightMeasureId",
                table: "ProductMaterials",
                column: "HeightMeasureId",
                principalTable: "HeightMeasures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductMaterials_Products_ProductsId",
                table: "ProductMaterials",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialExpertDeliverys_Staffs_StaffId",
                table: "MaterialExpertDeliverys");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductMaterials_HeightMeasures_HeightMeasureId",
                table: "ProductMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductMaterials_Products_ProductsId",
                table: "ProductMaterials");

            migrationBuilder.DropIndex(
                name: "IX_ProductMaterials_HeightMeasureId",
                table: "ProductMaterials");

            migrationBuilder.DropIndex(
                name: "IX_ProductMaterials_ProductsId",
                table: "ProductMaterials");

            migrationBuilder.DropIndex(
                name: "IX_MaterialExpertDeliverys_StaffId",
                table: "MaterialExpertDeliverys");

            migrationBuilder.DropColumn(
                name: "HeightMeasureId",
                table: "ProductMaterials");

            migrationBuilder.DropColumn(
                name: "ProductsId",
                table: "ProductMaterials");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "MaterialExpertDeliverys");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductMaterials_Products_ProductId",
                table: "ProductMaterials",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
