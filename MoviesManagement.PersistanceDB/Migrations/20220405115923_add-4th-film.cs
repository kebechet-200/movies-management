using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesManagement.PersistanceDB.Migrations
{
    public partial class add4thfilm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Image", "StartDate" },
                values: new object[] { "http://queducult.fr/wp-content/uploads/2021/01/IMG_7046.jpg", new DateTime(2022, 4, 5, 21, 59, 22, 831, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsExpired", "StartDate" },
                values: new object[] { false, new DateTime(2022, 4, 5, 13, 59, 22, 831, DateTimeKind.Local).AddTicks(5368) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 3, 30, 23, 57, 12, 595, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2022, 3, 31, 1, 57, 12, 598, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Image", "StartDate" },
                values: new object[] { "https://cdn.unitycms.io/image/ocroped/1200,1200,1000,1000,0,0/J-Xznv7DCWA/0MhZW_2tq5Y8clI2S8XVNo.jpg", new DateTime(2022, 3, 31, 6, 57, 12, 598, DateTimeKind.Local).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsExpired", "StartDate" },
                values: new object[] { true, new DateTime(2022, 3, 30, 22, 57, 12, 598, DateTimeKind.Local).AddTicks(7373) });
        }
    }
}
