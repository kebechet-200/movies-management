using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesManagement.PersistanceDB.Migrations
{
    public partial class domigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d067a8d-dacd-4867-bddd-85213d3596a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54d969f8-65a6-4ddf-9b8b-cb2cc11dc42d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e28a0151-7863-4bc6-b612-55405c1fea7a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c8c649f-0b9e-416f-8b5e-fe38d5933f60");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5b59ba7b-d0eb-41a6-9297-1024e8e77351", "ff117620-a6bd-4817-9599-ee4c530c24e9", "Admin", "ADMIN" },
                    { "c6293d6b-6804-45e3-b2c0-efb69155111c", "99b921d2-126c-4d11-afad-5a092dde463e", "Moderator", "MODERATOR" },
                    { "52046c58-ecff-41fb-a1d4-815eb7bff828", "e35bba10-ad13-4e5c-9dd9-ca4ae5e640f5", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "52908fee-a3b8-4ba7-ad4b-5ea323cbf445", 0, "cc4bbf6f-5760-4920-9436-0e2647f27d7d", "User", "lasha997@gmail.com", true, false, null, "LASHA997@GMAIL.COM", "LASHA997", null, "AQAAAAEAACcQAAAAED+yu2hOhU5ij96JfQRPvnRV9ogFf7CGGSi7pGQ5scyfZlux7FNjwdNjYy7MkTBRCQ==", null, true, "30c516ce-9ff1-41a1-b5aa-001389cb3083", false, "lasha997" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 4, 6, 11, 48, 5, 584, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2022, 4, 6, 13, 48, 5, 587, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2022, 4, 6, 18, 48, 5, 587, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2022, 4, 6, 10, 48, 5, 587, DateTimeKind.Local).AddTicks(4520));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52046c58-ecff-41fb-a1d4-815eb7bff828");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b59ba7b-d0eb-41a6-9297-1024e8e77351");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6293d6b-6804-45e3-b2c0-efb69155111c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52908fee-a3b8-4ba7-ad4b-5ea323cbf445");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4d067a8d-dacd-4867-bddd-85213d3596a0", "f07f64ea-62a7-46cb-a474-21975c820e7e", "Admin", "ADMIN" },
                    { "54d969f8-65a6-4ddf-9b8b-cb2cc11dc42d", "515eb96d-2496-4e03-ab5f-914dcbb2f49d", "Moderator", "MODERATOR" },
                    { "e28a0151-7863-4bc6-b612-55405c1fea7a", "8ab947fd-c72a-4c12-975a-cb70f921b457", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5c8c649f-0b9e-416f-8b5e-fe38d5933f60", 0, "1986fbaa-5552-4baf-869c-b4ffd30137be", "lasha997@gmail.com", true, false, null, "LASHA997@GMAIL.COM", "LASHA997", null, "AQAAAAEAACcQAAAAEF0Tqg1sxjjpjJX7YtPDL7Q72jockOUj3g8iHll/CKyS9eEAQA/zWXRi4RrdbHUzsg==", null, true, "b6ca3717-2381-479d-9899-9f94bc3d83b0", false, "lasha997" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 4, 6, 11, 45, 29, 918, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2022, 4, 6, 13, 45, 29, 921, DateTimeKind.Local).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2022, 4, 6, 18, 45, 29, 921, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2022, 4, 6, 10, 45, 29, 922, DateTimeKind.Local).AddTicks(7));
        }
    }
}
