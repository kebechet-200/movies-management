using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesManagement.PersistanceDB.Migrations
{
    public partial class seeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 3, 27, 16, 29, 57, 44, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2022, 3, 27, 16, 29, 57, 47, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2022, 3, 27, 16, 29, 57, 47, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2022, 3, 27, 16, 29, 57, 47, DateTimeKind.Local).AddTicks(6956));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 3, 27, 16, 15, 13, 152, DateTimeKind.Local).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2022, 3, 27, 16, 15, 13, 155, DateTimeKind.Local).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2022, 3, 27, 16, 15, 13, 155, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2022, 3, 27, 16, 15, 13, 155, DateTimeKind.Local).AddTicks(5995));
        }
    }
}
