using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies.Migrations
{
    public partial class initialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Writer",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Animation" },
                    { 3, "Classics" },
                    { 4, "Comedy" },
                    { 5, "Documentary" },
                    { 6, "Drama" },
                    { 7, "Horror" },
                    { 8, "Kids & Family" },
                    { 9, "Mystery" },
                    { 10, "Romance" },
                    { 11, "Sci-fi & Fantasy" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Director", "GenreId", "Image", "ReleaseYear", "Title", "Writer" },
                values: new object[,]
                {
                    { 3, "The aliens are coming and their goal is to invade and destroy Earth. Fighting superior technology, mankind's best weapon is the will to survive.", "Roland Emmerich", 1, "https://m.media-amazon.com/images/M/MV5BMGQwNDNkMmItYWY1Yy00YTZmLWE5OTAtODU0MGZmMzQ1NDdkXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UY1200_CR85,0,630,1200_AL_.jpg", "1996", "Independence Day", "Dean Devlin & Roland Emmerich" },
                    { 2, "The Griswold family's plans for a big family Christmas predictably turn into a big disaster.", "Jeremiah S. Chechik", 4, "https://m.media-amazon.com/images/I/71ONLW9CWHL._AC_SL1000_.jpg", "1989", "Christmas Vacation", "John Hughes" },
                    { 5, "A man must struggle to travel home for Thanksgiving with a lovable oaf of a shower curtain ring salesman as his only companion.", "John Hughes", 4, "https://m.media-amazon.com/images/M/MV5BMjE4MzI2MTY5MF5BMl5BanBnXkFtZTcwOTY2NTA0OQ@@._V1_.jpg", "1987", "Planes, Trains, & Automobiles", "John Hughes" },
                    { 6, "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", "John G. Avildsen", 6, "https://m.media-amazon.com/images/M/MV5BMjE4MzI2MTY5MF5BMl5BanBnXkFtZTcwOTY2NTA0OQ@@._V1_.jpg", "1976", "Rocky", "Slyvester Stallone" },
                    { 4, "Fifteen years after murdering his sister on Halloween night 1963, Michael Myers escapes from a mental hospital and returns to the small town of Haddonfield, Illinois to kill again.", "John Carpenter", 7, "https://m.media-amazon.com/images/I/61NDDpRDDJL._AC_SY741_.jpg", "1978", "Halloween", "John Carpenter & Debra Hill" },
                    { 1, "Astronaut Sam Bell has a quintessentially personal encounter toward the end of his three-year stint on the Moon, where he, working alongside his computer, GERTY, sends back to Earth parcels of a resource that has helped diminish our planet's power problems.", "Duncan Jones", 11, "https://m.media-amazon.com/images/M/MV5BMTgzODgyNTQwOV5BMl5BanBnXkFtZTcwNzc0NTc0Mg@@._V1_.jpg", "2009", "Moon", "Duncan Jones" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AverageRating", "Comment", "MovieId", "NumberOfReviews", "Rating", "ReviewerName", "TotalRatings" },
                values: new object[] { 3, 0, "I coulda been at a barbeque!!!", 3, 0, 4, "Lisa", 0 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AverageRating", "Comment", "MovieId", "NumberOfReviews", "Rating", "ReviewerName", "TotalRatings" },
                values: new object[] { 2, 0, "The best!  A Christmas classic.", 2, 0, 5, "Mike", 0 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AverageRating", "Comment", "MovieId", "NumberOfReviews", "Rating", "ReviewerName", "TotalRatings" },
                values: new object[] { 1, 0, "Great movie.  Fun!", 1, 0, 5, "Cheese", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

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
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DropColumn(
                name: "Writer",
                table: "Movies");
        }
    }
}
