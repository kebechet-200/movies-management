using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesManagement.PersistanceDB.Migrations
{
    public partial class changeseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsExpired", "StartDate" },
                values: new object[] { false, new DateTime(2022, 3, 30, 23, 57, 12, 595, DateTimeKind.Local).AddTicks(7563) });

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
                column: "StartDate",
                value: new DateTime(2022, 3, 31, 6, 57, 12, 598, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsExpired", "StartDate" },
                values: new object[] { true, new DateTime(2022, 3, 30, 22, 57, 12, 598, DateTimeKind.Local).AddTicks(7373) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsExpired", "StartDate" },
                values: new object[] { true, new DateTime(2022, 3, 30, 23, 28, 1, 286, DateTimeKind.Local).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2022, 3, 31, 1, 28, 1, 291, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2022, 3, 31, 6, 28, 1, 291, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsExpired", "StartDate" },
                values: new object[] { false, new DateTime(2022, 3, 30, 22, 28, 1, 291, DateTimeKind.Local).AddTicks(8416) });
        }
    }
}
