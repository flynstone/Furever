using Microsoft.EntityFrameworkCore.Migrations;

namespace Furever.Api.Migrations
{
    public partial class AddDbFinalSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Favorites",
                columns: new[] { "AnimalId", "UserId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "Favorites",
                columns: new[] { "AnimalId", "UserId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "Favorites",
                columns: new[] { "AnimalId", "UserId" },
                values: new object[] { 2, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumns: new[] { "AnimalId", "UserId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumns: new[] { "AnimalId", "UserId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumns: new[] { "AnimalId", "UserId" },
                keyValues: new object[] { 2, 2 });
        }
    }
}
