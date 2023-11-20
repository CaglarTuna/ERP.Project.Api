using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class TodoList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoList_Staffs_StaffId",
                table: "TodoList");

            migrationBuilder.RenameColumn(
                name: "StaffId",
                table: "TodoList",
                newName: "StaffsId");

            migrationBuilder.RenameIndex(
                name: "IX_TodoList_StaffId",
                table: "TodoList",
                newName: "IX_TodoList_StaffsId");

            migrationBuilder.AddColumn<bool>(
                name: "Flag",
                table: "TodoList",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "InterestId",
                table: "TodoList",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TodoMember",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffId = table.Column<int>(type: "int", nullable: true),
                    StaffsId = table.Column<int>(type: "int", nullable: true),
                    TodoId = table.Column<int>(type: "int", nullable: true),
                    TodoListId = table.Column<int>(type: "int", nullable: true),
                    FlagMember = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TodoMember_Staffs_StaffsId",
                        column: x => x.StaffsId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TodoMember_TodoList_TodoListId",
                        column: x => x.TodoListId,
                        principalTable: "TodoList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TodoList_InterestId",
                table: "TodoList",
                column: "InterestId");

            migrationBuilder.CreateIndex(
                name: "IX_TodoMember_StaffsId",
                table: "TodoMember",
                column: "StaffsId");

            migrationBuilder.CreateIndex(
                name: "IX_TodoMember_TodoListId",
                table: "TodoMember",
                column: "TodoListId");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoList_Orders_InterestId",
                table: "TodoList",
                column: "InterestId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TodoList_Staffs_StaffsId",
                table: "TodoList",
                column: "StaffsId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoList_Orders_InterestId",
                table: "TodoList");

            migrationBuilder.DropForeignKey(
                name: "FK_TodoList_Staffs_StaffsId",
                table: "TodoList");

            migrationBuilder.DropTable(
                name: "TodoMember");

            migrationBuilder.DropIndex(
                name: "IX_TodoList_InterestId",
                table: "TodoList");

            migrationBuilder.DropColumn(
                name: "Flag",
                table: "TodoList");

            migrationBuilder.DropColumn(
                name: "InterestId",
                table: "TodoList");

            migrationBuilder.RenameColumn(
                name: "StaffsId",
                table: "TodoList",
                newName: "StaffId");

            migrationBuilder.RenameIndex(
                name: "IX_TodoList_StaffsId",
                table: "TodoList",
                newName: "IX_TodoList_StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoList_Staffs_StaffId",
                table: "TodoList",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
