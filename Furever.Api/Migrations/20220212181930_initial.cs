using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Furever.Api.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Species = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Refuges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refuges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    RefugeId = table.Column<int>(type: "INTEGER", nullable: false),
                    IsAvailable = table.Column<bool>(type: "INTEGER", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animals_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animals_Refuges_RefugeId",
                        column: x => x.RefugeId,
                        principalTable: "Refuges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => new { x.AnimalId, x.UserId });
                    table.ForeignKey(
                        name: "FK_Favorites_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favorites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Species" },
                values: new object[] { 1, "Dogs" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Species" },
                values: new object[] { 2, "Cats" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Species" },
                values: new object[] { 3, "Birds" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Species" },
                values: new object[] { 4, "Reptiles" });

            migrationBuilder.InsertData(
                table: "Refuges",
                columns: new[] { "Id", "Address", "City", "Email", "FirstName", "LastName", "Phone", "Username" },
                values: new object[] { 1, "123 Fake Avenue", "Ottawa", "owner@test.com", "Owner", "Test", null, "Testing" });

            migrationBuilder.InsertData(
                table: "Refuges",
                columns: new[] { "Id", "Address", "City", "Email", "FirstName", "LastName", "Phone", "Username" },
                values: new object[] { 2, "123 Fake Street", "Montreal", "test@owner.com", "Test", "Owner", null, "Guest_01" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1, "Test", "User" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2, "User", "Test" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DateOfBirth", "IsAvailable", "Name", "RefugeId" },
                values: new object[] { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Skippy", 1 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DateOfBirth", "IsAvailable", "Name", "RefugeId" },
                values: new object[] { 4, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Shadow", 1 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DateOfBirth", "IsAvailable", "Name", "RefugeId" },
                values: new object[] { 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Felix", 2 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DateOfBirth", "IsAvailable", "Name", "RefugeId" },
                values: new object[] { 3, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Garfield", 2 });

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

            migrationBuilder.CreateIndex(
                name: "IX_Animals_CategoryId",
                table: "Animals",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_RefugeId",
                table: "Animals",
                column: "RefugeId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_UserId",
                table: "Favorites",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Refuges");
        }
    }
}
