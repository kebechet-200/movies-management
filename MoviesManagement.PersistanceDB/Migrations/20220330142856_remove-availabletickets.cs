using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesManagement.PersistanceDB.Migrations
{
    public partial class removeavailabletickets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailableTickets",
                table: "Movies");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 3, 30, 17, 28, 56, 190, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2022, 3, 30, 19, 28, 56, 192, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2022, 3, 31, 0, 28, 56, 192, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2022, 3, 30, 16, 28, 56, 192, DateTimeKind.Local).AddTicks(9804));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AvailableTickets",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvailableTickets", "StartDate" },
                values: new object[] { 30, new DateTime(2022, 3, 29, 19, 25, 14, 0, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvailableTickets", "StartDate" },
                values: new object[] { 30, new DateTime(2022, 3, 29, 21, 25, 14, 3, DateTimeKind.Local).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvailableTickets", "StartDate" },
                values: new object[] { 30, new DateTime(2022, 3, 30, 2, 25, 14, 3, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvailableTickets", "StartDate" },
                values: new object[] { 30, new DateTime(2022, 3, 29, 18, 25, 14, 3, DateTimeKind.Local).AddTicks(5981) });
        }
    }
}
