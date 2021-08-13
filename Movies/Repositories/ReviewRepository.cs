using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Repositories
{
    public class ReviewRepository : Repository<Review>
    {
        public ReviewRepository(MovieContext db) : base(db)
        {

        }
    }
}
