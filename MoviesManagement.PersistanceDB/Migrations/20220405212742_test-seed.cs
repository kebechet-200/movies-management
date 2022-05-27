using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesManagement.PersistanceDB.Migrations
{
    public partial class testseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_UserId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Movies_Name",
                table: "Movies");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Image", "IsActive", "IsExpired", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, "ფილმის აღწერა #1", "https://fr.web.img4.acsta.net/medias/nmedia/18/69/96/84/19151192.jpg", true, false, "შეშლილთა კუნძული", new DateTime(2022, 4, 6, 0, 27, 41, 837, DateTimeKind.Local).AddTicks(5281) },
                    { 2, "ფილმის აღწერა #2", "https://www.themoviedb.org/t/p/w500/wuMc08IPKEatf9rnMNXvIDxqP4W.jpg", true, false, "ჰარი პოტერი და ფილოსოფიური ქვა", new DateTime(2022, 4, 6, 2, 27, 41, 840, DateTimeKind.Local).AddTicks(6647) },
                    { 3, "ფილმის აღწერა #3", "https://cdn.unitycms.io/image/ocroped/1200,1200,1000,1000,0,0/J-Xznv7DCWA/0MhZW_2tq5Y8clI2S8XVNo.jpg", true, false, "დედოფლის გამბიტი", new DateTime(2022, 4, 6, 7, 27, 41, 840, DateTimeKind.Local).AddTicks(6830) },
                    { 4, "ფილმის აღწერა #4", "https://fr.web.img6.acsta.net/pictures/19/02/13/12/13/2348674.jpg", true, true, "პროფესორი და შეშლილი", new DateTime(2022, 4, 5, 23, 27, 41, 840, DateTimeKind.Local).AddTicks(6843) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_UserId",
                table: "Tickets",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_UserId",
                table: "Tickets");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Movies",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Movies",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_Name",
                table: "Movies",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_UserId",
                table: "Tickets",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
