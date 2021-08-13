using Microsoft.EntityFrameworkCore;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=MovieDB;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Add seed data for Genre model:
            modelBuilder.Entity<Genre>().HasData(
                new Genre()
                {
                    Id = 1,
                    Name = "Action"
                }, new Genre()
                { 
                    Id = 2,
                    Name = "Animation"
                }, new Genre()
                {
                    Id = 3,
                    Name = "Classics"
                }, new Genre()
                {
                    Id = 4,
                    Name = "Comedy"
                }, new Genre()
                {
                    Id = 5,
                    Name = "Documentary"
                }, new Genre()
                {
                    Id = 6,
                    Name = "Drama"
                }, new Genre()
                {
                    Id = 7,
                    Name = "Horror"
                }, new Genre()
                {
                    Id = 8,
                    Name = "Kids & Family"
                }, new Genre()
                {
                    Id = 9,
                    Name = "Mystery"
                }, new Genre()
                {
                    Id = 10,
                    Name = "Romance"
                }, new Genre()
                {
                    Id = 11,
                    Name = "Sci-fi & Fantasy"
                });

            //Add seed data for Movie model:
            modelBuilder.Entity<Movie>().HasData(
                new Movie()
                {
                    Id = 1,
                    GenreId = 11,
                    Title = "Moon",
                    Image = "https://m.media-amazon.com/images/M/MV5BMTgzODgyNTQwOV5BMl5BanBnXkFtZTcwNzc0NTc0Mg@@._V1_.jpg",
                    Description = "Astronaut Sam Bell has a quintessentially personal encounter toward the end of his three-year stint on the Moon, where he, working alongside his computer, GERTY, sends back to Earth parcels of a resource that has helped diminish our planet's power problems.",
                    Director = "Duncan Jones",
                    Writer = "Duncan Jones",
                    ReleaseYear = "2009"
                }, new Movie()
                {
                    Id = 2,
                    GenreId = 4,
                    Title = "Christmas Vacation",
                    Image = "https://m.media-amazon.com/images/I/71ONLW9CWHL._AC_SL1000_.jpg",
                    Description = "The Griswold family's plans for a big family Christmas predictably turn into a big disaster.",
                    Director = "Jeremiah S. Chechik",
                    Writer = "John Hughes",
                    ReleaseYear = "1989"
                }, new Movie()
                {
                    Id = 3,
                    GenreId = 1,
                    Title = "Independence Day",
                    Image = "https://m.media-amazon.com/images/M/MV5BMGQwNDNkMmItYWY1Yy00YTZmLWE5OTAtODU0MGZmMzQ1NDdkXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UY1200_CR85,0,630,1200_AL_.jpg",
                    Description = "The aliens are coming and their goal is to invade and destroy Earth. Fighting superior technology, mankind's best weapon is the will to survive.",
                    Director = "Roland Emmerich",
                    Writer = "Dean Devlin & Roland Emmerich",
                    ReleaseYear = "1996"
                }, new Movie()
                {
                    Id = 4,
                    GenreId = 7,
                    Title = "Halloween",
                    Image = "https://m.media-amazon.com/images/I/61NDDpRDDJL._AC_SY741_.jpg",
                    Description = "Fifteen years after murdering his sister on Halloween night 1963, Michael Myers escapes from a mental hospital and returns to the small town of Haddonfield, Illinois to kill again.",
                    Director = "John Carpenter",
                    Writer = "John Carpenter & Debra Hill",
                    ReleaseYear = "1978"
                }, new Movie()
                {
                    Id = 5,
                    GenreId = 4,
                    Title = "Planes, Trains, & Automobiles",
                    Image = "https://m.media-amazon.com/images/M/MV5BMjE4MzI2MTY5MF5BMl5BanBnXkFtZTcwOTY2NTA0OQ@@._V1_.jpg",
                    Description = "A man must struggle to travel home for Thanksgiving with a lovable oaf of a shower curtain ring salesman as his only companion.",
                    Director = "John Hughes",
                    Writer = "John Hughes",
                    ReleaseYear = "1987"
                }, new Movie()
                {
                    Id = 6,
                    GenreId = 6,
                    Title = "Rocky",
                    Image = "https://m.media-amazon.com/images/M/MV5BMTY5MDMzODUyOF5BMl5BanBnXkFtZTcwMTQ3NTMyNA@@._V1_.jpg",
                    Description = "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.",
                    Director = "John G. Avildsen",
                    Writer = "Slyvester Stallone",
                    ReleaseYear = "1976"
                });

            //Add seed data for Review model:
            modelBuilder.Entity<Review>().HasData(
                new Review()
                {
                    Id = 1,
                    MovieId = 1,
                    ReviewerName = "Cheese",
                    Rating = 5,
                    Comment = "Great movie.  Fun!"
                }, new Review()
                {
                    Id = 2,
                    MovieId = 2,
                    ReviewerName = "Mike",
                    Rating = 5,
                    Comment = "The best!  A Christmas classic."
                }, new Review()
                {
                    Id = 3,
                    MovieId = 3,
                    ReviewerName = "Lisa",
                    Rating = 4,
                    Comment = "I coulda been at a barbeque!!!"
                });

            base.OnModelCreating(modelBuilder);
        }

    }
}
