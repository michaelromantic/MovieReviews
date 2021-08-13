using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies.Migrations
{
    public partial class update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "https://m.media-amazon.com/images/M/MV5BMTY5MDMzODUyOF5BMl5BanBnXkFtZTcwMTQ3NTMyNA@@._V1_.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "https://m.media-amazon.com/images/M/MV5BMjE4MzI2MTY5MF5BMl5BanBnXkFtZTcwOTY2NTA0OQ@@._V1_.jpg");
        }
    }
}
