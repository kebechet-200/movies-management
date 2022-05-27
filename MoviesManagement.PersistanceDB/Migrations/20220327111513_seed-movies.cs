using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesManagement.PersistanceDB.Migrations
{
    public partial class seedmovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "AvailableTickets", "Description", "IsActive", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, 30, "ფილმის აღწერა #1", true, "შეშლილთა კუნძული", new DateTime(2022, 3, 27, 16, 15, 13, 152, DateTimeKind.Local).AddTicks(6987) },
                    { 2, 30, "ფილმის აღწერა #2", true, "ჰარი პოტერი და ფილოსოფიური ქვა", new DateTime(2022, 3, 27, 16, 15, 13, 155, DateTimeKind.Local).AddTicks(5934) },
                    { 3, 30, "ფილმის აღწერა #3", true, "დედოფლის გამბიტი", new DateTime(2022, 3, 27, 16, 15, 13, 155, DateTimeKind.Local).AddTicks(5989) },
                    { 4, 30, "ფილმის აღწერა #4", true, "პროფესორი და შეშლილი", new DateTime(2022, 3, 27, 16, 15, 13, 155, DateTimeKind.Local).AddTicks(5995) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
