using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class todolistupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoMember_Staffs_StaffsId",
                table: "TodoMember");

            migrationBuilder.DropForeignKey(
                name: "FK_TodoMember_TodoList_TodoListId",
                table: "TodoMember");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TodoMember",
                table: "TodoMember");

            migrationBuilder.DropIndex(
                name: "IX_TodoMember_StaffsId",
                table: "TodoMember");

            migrationBuilder.DropIndex(
                name: "IX_TodoMember_TodoListId",
                table: "TodoMember");

            migrationBuilder.DropColumn(
                name: "StaffsId",
                table: "TodoMember");

            migrationBuilder.DropColumn(
                name: "TodoListId",
                table: "TodoMember");

            migrationBuilder.RenameTable(
                name: "TodoMember",
                newName: "TodoMembers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TodoMembers",
                table: "TodoMembers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TodoMembers_StaffId_TodoId",
                table: "TodoMembers",
                columns: new[] { "StaffId", "TodoId" },
                unique: true,
                filter: "[StaffId] IS NOT NULL AND [TodoId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TodoMembers_TodoId",
                table: "TodoMembers",
                column: "TodoId");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoMembers_Staffs_StaffId",
                table: "TodoMembers",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TodoMembers_TodoList_TodoId",
                table: "TodoMembers",
                column: "TodoId",
                principalTable: "TodoList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoMembers_Staffs_StaffId",
                table: "TodoMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_TodoMembers_TodoList_TodoId",
                table: "TodoMembers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TodoMembers",
                table: "TodoMembers");

            migrationBuilder.DropIndex(
                name: "IX_TodoMembers_StaffId_TodoId",
                table: "TodoMembers");

            migrationBuilder.DropIndex(
                name: "IX_TodoMembers_TodoId",
                table: "TodoMembers");

            migrationBuilder.RenameTable(
                name: "TodoMembers",
                newName: "TodoMember");

            migrationBuilder.AddColumn<int>(
                name: "StaffsId",
                table: "TodoMember",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TodoListId",
                table: "TodoMember",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TodoMember",
                table: "TodoMember",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TodoMember_StaffsId",
                table: "TodoMember",
                column: "StaffsId");

            migrationBuilder.CreateIndex(
                name: "IX_TodoMember_TodoListId",
                table: "TodoMember",
                column: "TodoListId");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoMember_Staffs_StaffsId",
                table: "TodoMember",
                column: "StaffsId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TodoMember_TodoList_TodoListId",
                table: "TodoMember",
                column: "TodoListId",
                principalTable: "TodoList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
