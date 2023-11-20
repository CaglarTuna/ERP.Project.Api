using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class SpecialProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpeacialProductDescription_Products_ProductId",
                table: "SpeacialProductDescription");

            migrationBuilder.DropIndex(
                name: "IX_SpeacialProductDescription_ProductId",
                table: "SpeacialProductDescription");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "SpeacialProductDescription",
                newName: "Quantitiy");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SpeacialProductDescription",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "SpeacialProductDescription");

            migrationBuilder.RenameColumn(
                name: "Quantitiy",
                table: "SpeacialProductDescription",
                newName: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SpeacialProductDescription_ProductId",
                table: "SpeacialProductDescription",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_SpeacialProductDescription_Products_ProductId",
                table: "SpeacialProductDescription",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
