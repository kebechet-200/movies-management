using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesManagement.PersistanceDB.Migrations
{
    public partial class testmigrationn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e12b490-8893-462a-8c73-e065034effd1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b67ba522-a06c-47d5-9882-7cc167b12379");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8897935-8048-4091-b14f-251f3d211f96");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e34edb64-8818-4bab-afd9-609911295192");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "e8897935-8048-4091-b14f-251f3d211f96", "b01f3abe-a377-425c-9573-202845da3a20", "Admin", "ADMIN" },
                    { "b67ba522-a06c-47d5-9882-7cc167b12379", "666fe5cc-c9ac-4e66-8367-886569d087b0", "Moderator", "MODERATOR" },
                    { "6e12b490-8893-462a-8c73-e065034effd1", "892482c1-3a47-42b2-8092-cedf9a910888", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e34edb64-8818-4bab-afd9-609911295192", 0, "eab483b1-6445-4edf-a84e-e2dbf05bad2b", "User", "lasha997@gmail.com", true, false, null, "LASHA997@GMAIL.COM", "LASHA997", null, "AQAAAAEAACcQAAAAEOL7qdPaqW9co9hB6v8+FxEVXxvAbIcxkuaKyNAq9B89STIc+fhnybPBDz1kX1lz3Q==", null, true, "6563efd8-a1db-4600-8b52-636063b83628", false, "lasha997" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 4, 6, 11, 42, 50, 96, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2022, 4, 6, 13, 42, 50, 100, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2022, 4, 6, 18, 42, 50, 100, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2022, 4, 6, 10, 42, 50, 100, DateTimeKind.Local).AddTicks(5530));
        }
    }
}
