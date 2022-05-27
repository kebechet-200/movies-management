using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesManagement.PersistanceDB.Migrations
{
    public partial class addphoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsExpired",
                table: "Movies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Image", "IsExpired", "StartDate" },
                values: new object[] { "https://fr.web.img4.acsta.net/medias/nmedia/18/69/96/84/19151192.jpg", true, new DateTime(2022, 3, 30, 23, 28, 1, 286, DateTimeKind.Local).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Image", "StartDate" },
                values: new object[] { "https://www.themoviedb.org/t/p/w500/wuMc08IPKEatf9rnMNXvIDxqP4W.jpg", new DateTime(2022, 3, 31, 1, 28, 1, 291, DateTimeKind.Local).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Image", "StartDate" },
                values: new object[] { "https://cdn.unitycms.io/image/ocroped/1200,1200,1000,1000,0,0/J-Xznv7DCWA/0MhZW_2tq5Y8clI2S8XVNo.jpg", new DateTime(2022, 3, 31, 6, 28, 1, 291, DateTimeKind.Local).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Image", "StartDate" },
                values: new object[] { "https://fr.web.img6.acsta.net/pictures/19/02/13/12/13/2348674.jpg", new DateTime(2022, 3, 30, 22, 28, 1, 291, DateTimeKind.Local).AddTicks(8416) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "IsExpired",
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
    }
}
