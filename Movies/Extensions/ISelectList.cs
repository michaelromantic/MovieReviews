using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Extensions
{
    public interface ISelectList
    {
        List<Movie> GetMovieByGenreId(int genreId);
        List<Genre> PopulateGenreList();
        List<Movie> PopulateMovieList();
        Genre GetGenreByName(string name);
        List<Review> GetReviewsByMovieId(int movieId);
    }
}
