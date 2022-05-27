using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesManagement.PersistanceDB.Migrations
{
    public partial class test02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7eb0f86b-fad6-422c-b0f2-2be0b90f9b03", "77190acd-7c89-4d52-8de6-dc4b2eb8db2c", "Admin", "ADMIN" },
                    { "299ccdc4-4e77-4dd0-bb6e-11555205de82", "b0a0252f-bd4d-45de-8285-1e8f1b21c6fc", "Moderator", "MODERATOR" },
                    { "773fdc39-a6e2-476e-9782-78921c0f917c", "82657336-3bca-48a7-bab9-19e12898e3f9", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4638225d-c14b-48a6-9ed1-f90f24e6cb55", 0, "58a543d4-5188-4a1b-ad79-b22b0cfd627d", "lasha997@gmail.com", true, false, null, "LASHA997@GMAIL.COM", "LASHA997", "AQAAAAEAACcQAAAAEMHXb6Ez85AiqCgJ90v1v4FnDBUAX5qKJuFbmwUy+o+i0drExGoxzDOLHJFHqjESXA==", null, true, "5b36ff14-f537-4e60-a0d8-a1655706070c", false, "lasha997" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 4, 12, 11, 51, 13, 992, DateTimeKind.Local).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2022, 4, 12, 13, 51, 13, 997, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2022, 4, 12, 18, 51, 13, 997, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2022, 4, 12, 10, 51, 13, 997, DateTimeKind.Local).AddTicks(7248));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "299ccdc4-4e77-4dd0-bb6e-11555205de82");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "773fdc39-a6e2-476e-9782-78921c0f917c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7eb0f86b-fad6-422c-b0f2-2be0b90f9b03");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4638225d-c14b-48a6-9ed1-f90f24e6cb55");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
