using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HeightMeasures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeightMeasures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialHeightMeasure",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    MaterialsId = table.Column<int>(type: "int", nullable: true),
                    HeightMeasureId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialHeightMeasure", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaterialHeightMeasure_HeightMeasures_HeightMeasureId",
                        column: x => x.HeightMeasureId,
                        principalTable: "HeightMeasures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialHeightMeasure_Materials_MaterialsId",
                        column: x => x.MaterialsId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeightMeasures_Id",
                table: "HeightMeasures",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MaterialHeightMeasure_HeightMeasureId",
                table: "MaterialHeightMeasure",
                column: "HeightMeasureId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialHeightMeasure_MaterialsId",
                table: "MaterialHeightMeasure",
                column: "MaterialsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaterialHeightMeasure");

            migrationBuilder.DropTable(
                name: "HeightMeasures");
        }
    }
}
