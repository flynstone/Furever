using Microsoft.EntityFrameworkCore.Migrations;

namespace Furever.Api.Migrations
{
    public partial class ReeditRefugeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Refuges_OwnerId",
                table: "Animals");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Animals",
                newName: "RefugeId");

            migrationBuilder.RenameIndex(
                name: "IX_Animals_OwnerId",
                table: "Animals",
                newName: "IX_Animals_RefugeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Refuges_RefugeId",
                table: "Animals",
                column: "RefugeId",
                principalTable: "Refuges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Refuges_RefugeId",
                table: "Animals");

            migrationBuilder.RenameColumn(
                name: "RefugeId",
                table: "Animals",
                newName: "OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Animals_RefugeId",
                table: "Animals",
                newName: "IX_Animals_OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Refuges_OwnerId",
                table: "Animals",
                column: "OwnerId",
                principalTable: "Refuges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
