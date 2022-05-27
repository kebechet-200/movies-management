using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesManagement.PersistanceDB.Migrations
{
    public partial class samplemigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { 1, "ფილმის აღწერა #1", "https://fr.web.img4.acsta.net/medias/nmedia/18/69/96/84/19151192.jpg", true, false, "შეშლილთა კუნძული", new DateTime(2022, 4, 5, 23, 30, 40, 678, DateTimeKind.Local).AddTicks(2522) },
                    { 2, "ფილმის აღწერა #2", "https://www.themoviedb.org/t/p/w500/wuMc08IPKEatf9rnMNXvIDxqP4W.jpg", true, false, "ჰარი პოტერი და ფილოსოფიური ქვა", new DateTime(2022, 4, 6, 1, 30, 40, 681, DateTimeKind.Local).AddTicks(9367) },
                    { 3, "ფილმის აღწერა #3", "http://queducult.fr/wp-content/uploads/2021/01/IMG_7046.jpg", true, false, "დედოფლის გამბიტი", new DateTime(2022, 4, 6, 6, 30, 40, 681, DateTimeKind.Local).AddTicks(9490) },
                    { 4, "ფილმის აღწერა #4", "https://fr.web.img6.acsta.net/pictures/19/02/13/12/13/2348674.jpg", true, false, "პროფესორი და შეშლილი", new DateTime(2022, 4, 5, 22, 30, 40, 681, DateTimeKind.Local).AddTicks(9498) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_UserId",
                table: "Tickets",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
