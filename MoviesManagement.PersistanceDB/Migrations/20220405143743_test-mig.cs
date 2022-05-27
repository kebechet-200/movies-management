using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesManagement.PersistanceDB.Migrations
{
    public partial class testmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2022, 4, 5, 17, 37, 42, 555, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2022, 4, 5, 19, 37, 42, 558, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2022, 4, 6, 0, 37, 42, 558, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2022, 4, 5, 16, 37, 42, 558, DateTimeKind.Local).AddTicks(9344));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
