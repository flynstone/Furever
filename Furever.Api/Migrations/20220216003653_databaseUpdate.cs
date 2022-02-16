using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Furever.Api.Migrations
{
    public partial class databaseUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "Description", "Name" },
                values: new object[] { new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 year old, Female, Cavalier King Charles Spaniel", "Daisy" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "DateOfBirth", "Description", "Name", "RefugeId" },
                values: new object[] { 1, new DateTime(2017, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 year old, Male, German Sheppard", "Duke", 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "DateOfBirth", "Description", "Name", "RefugeId" },
                values: new object[] { 1, new DateTime(2018, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 year old, Male, Boxer", "Gus", 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "DateOfBirth", "Description", "Name" },
                values: new object[] { 1, new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 month old, Male, Maltese", "Jasper" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DateOfBirth", "Description", "IsAvailable", "Name", "RefugeId" },
                values: new object[] { 20, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "8 year old, Male, Orange and Gray Short Hair", true, "Simba", 1 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DateOfBirth", "Description", "IsAvailable", "Name", "RefugeId" },
                values: new object[] { 19, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 month old, Female, Gray and White Kitten", true, "Rosie", 1 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DateOfBirth", "Description", "IsAvailable", "Name", "RefugeId" },
                values: new object[] { 18, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 month old, Male, Black and White Kitten", true, "Oreo", 1 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DateOfBirth", "Description", "IsAvailable", "Name", "RefugeId" },
                values: new object[] { 17, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "7 month old, Male, Gray Kitten", true, "Ollie", 1 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DateOfBirth", "Description", "IsAvailable", "Name", "RefugeId" },
                values: new object[] { 16, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 month old, Female, Orange Tabby", true, "Lulu", 1 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DateOfBirth", "Description", "IsAvailable", "Name", "RefugeId" },
                values: new object[] { 15, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 month old, Female, White Kitten", true, "Lucy", 1 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DateOfBirth", "Description", "IsAvailable", "Name", "RefugeId" },
                values: new object[] { 14, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "5 year old, Male, Gray Short Hair", true, "Jax", 1 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DateOfBirth", "Description", "IsAvailable", "Name", "RefugeId" },
                values: new object[] { 12, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "5 month old, Male, Tri-Color Short Hair, Kitten", true, "Binx", 1 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DateOfBirth", "Description", "IsAvailable", "Name", "RefugeId" },
                values: new object[] { 11, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "7 year old, Female, Gray & White Maine Coon", true, "Abby", 1 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DateOfBirth", "Description", "IsAvailable", "Name", "RefugeId" },
                values: new object[] { 10, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "5 month old, Female, Yorkshire Terrier", true, "Zoe", 1 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DateOfBirth", "Description", "IsAvailable", "Name", "RefugeId" },
                values: new object[] { 9, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 month old, Male, German Sheppard", true, "Rocky", 1 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DateOfBirth", "Description", "IsAvailable", "Name", "RefugeId" },
                values: new object[] { 8, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 month old, Brother and Sister, Labrador Retrievers", true, "Molly and Toby", 1 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DateOfBirth", "Description", "IsAvailable", "Name", "RefugeId" },
                values: new object[] { 7, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 year old, Male, Pug", true, "Milo", 1 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DateOfBirth", "Description", "IsAvailable", "Name", "RefugeId" },
                values: new object[] { 6, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 year old, Female, Siberian Husky", true, "Luna", 1 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DateOfBirth", "Description", "IsAvailable", "Name", "RefugeId" },
                values: new object[] { 13, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 year old, Female, Short Hair", true, "Jade", 1 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DateOfBirth", "Description", "IsAvailable", "Name", "RefugeId" },
                values: new object[] { 5, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 year old, Male, Corgi", true, "Kobe", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "Description", "Name" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Skippy" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "DateOfBirth", "Description", "Name", "RefugeId" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Felix", 2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "DateOfBirth", "Description", "Name", "RefugeId" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Garfield", 2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "DateOfBirth", "Description", "Name" },
                values: new object[] { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Shadow" });
        }
    }
}
