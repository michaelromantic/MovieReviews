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
        public string Image { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string ReleaseYear { get; set; }
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual ICollection<Review> Review { get; set; }

        
        public Movie()
        {

        }

        public Movie(int id, string title, string image, string description, string director, string writer, string releaseYear)
        {
            Id = id;
            Title = title;
            Image = image;
            Description = description;
            Director = director;
            Writer = writer;
            ReleaseYear = releaseYear;
        }
    }
}
