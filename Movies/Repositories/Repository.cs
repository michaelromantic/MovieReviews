using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Movies.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private MovieContext db;

        public Repository(MovieContext db)
        {
            this.db = db;
        }

        public void Create(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return db.Set<T>();
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public List<Genre> PopulateGenreList()
        {
            return db.Set<Genre>().ToList();
        }

        public List<Movie> PopulateMovieList()
        {
            return db.Set<Movie>().ToList();
        }

        public List<Movie> GetMovieByGenreId(int genreId)
        {
            return db.Set<Movie>().Where(f => f.GenreId == genreId).ToList();
        }

        public List<Review> GetReviewsByMovieId(int movieId)
        {
            return db.Set<Review>().Where(f => f.MovieId == movieId).ToList();
        }

        public void Update(T entity)
        {
            db.Set<T>().Update(entity);
            db.SaveChanges();
        }

        public void Delete(T entity)
        {
            db.Set<T>().Remove(entity);
            db.SaveChanges();
        }

        public Genre GetGenreByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
