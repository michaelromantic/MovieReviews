using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Repositories
{
    public class GenreRepository : Repository<Genre>
    {
        public GenreRepository(MovieContext db) : base(db)
        {

        }
    }
}
