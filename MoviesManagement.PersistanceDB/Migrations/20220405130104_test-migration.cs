using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesManagement.PersistanceDB.Migrations
{
    public partial class testmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 4, 5, 16, 1, 3, 470, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2022, 4, 5, 18, 1, 3, 473, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2022, 4, 5, 23, 1, 3, 473, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2022, 4, 5, 15, 1, 3, 473, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Image", "IsActive", "IsExpired", "Name", "StartDate" },
                values: new object[,]
                {
                    { 5, "ფილმის აღწერა #1", "https://fr.web.img4.acsta.net/medias/nmedia/18/69/96/84/19151192.jpg", true, false, "შეშლილთა კუნძული", new DateTime(2022, 4, 5, 16, 1, 3, 473, DateTimeKind.Local).AddTicks(7666) },
                    { 6, "ფილმის აღწერა #1", "https://fr.web.img4.acsta.net/medias/nmedia/18/69/96/84/19151192.jpg", true, false, "შეშლილთა კუნძული", new DateTime(2022, 4, 5, 16, 1, 3, 473, DateTimeKind.Local).AddTicks(7670) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 4, 5, 14, 59, 22, 828, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2022, 4, 5, 16, 59, 22, 831, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2022, 4, 5, 21, 59, 22, 831, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2022, 4, 5, 13, 59, 22, 831, DateTimeKind.Local).AddTicks(5368));
        }
    }
}
