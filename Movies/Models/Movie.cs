using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Movies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public string ReleaseYear { get; set; }
        
        public Movie()
        {

        }

        public Movie(int id, string title, string genre, string image, string description, string director, string releaseYear)
        {
            Id = id;
            Title = title;
            Genre = genre;
            Image = image;
            Description = description;
            Director = director;
            ReleaseYear = releaseYear;
        }
    }
}
