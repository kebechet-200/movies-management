using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesManagement.PersistanceDB.Migrations
{
    public partial class userandroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5d489c1e-621f-4cd3-8731-dda3adce8244", "f868f8fd-e169-470f-a3c0-3a77ad5c41bc", "Admin", "ADMIN" },
                    { "df1b80ec-bf30-4c08-bb20-20bc483546db", "aadc54d4-4019-414f-a1fc-dd8bc7a8bade", "Moderator", "MODERATOR" },
                    { "0f51bf29-a635-457c-9d4e-3a8054e6a125", "e19e05df-14c9-4bf5-aca5-7dfd319da185", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6e26f921-6e71-4e1b-bee4-9b09539b0634", 0, "85886e3a-77e9-4ef9-acdf-2e5e92f0c5a8", "lasha997@gmail.com", true, false, null, "LASHA997@GMAIL.COM", "LASHA997", null, "AQAAAAEAACcQAAAAEGcqq5VjRqROpnohBs9IvYZMUjbhOuUrDjHfyGzQ7N86xZQpEIpYJ6P7Zi3cq0bQgQ==", null, true, "aa7cf32d-0f29-4acd-8a47-f47754a0e2ba", false, "lasha997" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 4, 6, 0, 43, 48, 400, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2022, 4, 6, 2, 43, 48, 405, DateTimeKind.Local).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2022, 4, 6, 7, 43, 48, 405, DateTimeKind.Local).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2022, 4, 5, 23, 43, 48, 405, DateTimeKind.Local).AddTicks(1214));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f51bf29-a635-457c-9d4e-3a8054e6a125");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d489c1e-621f-4cd3-8731-dda3adce8244");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df1b80ec-bf30-4c08-bb20-20bc483546db");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6e26f921-6e71-4e1b-bee4-9b09539b0634");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 4, 6, 0, 27, 41, 837, DateTimeKind.Local).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2022, 4, 6, 2, 27, 41, 840, DateTimeKind.Local).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2022, 4, 6, 7, 27, 41, 840, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2022, 4, 5, 23, 27, 41, 840, DateTimeKind.Local).AddTicks(6843));
        }
    }
}
