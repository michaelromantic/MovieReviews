using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Repositories
{
    public class MovieRepository : Repository<Movie>
    {
        public MovieRepository(MovieContext db) : base(db)
        {

        }
    }
}
