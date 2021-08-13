using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Movies.Models;
using Movies.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Movies.Controllers
{
    public class MovieController : Controller
    {
        IRepository<Movie> movieRepo;

        public MovieController(IRepository<Movie> movieRepo)
        {
            this.movieRepo = movieRepo;
        }

        private void DropList()
        {
            var genre = movieRepo.PopulateGenreList();
            ViewBag.Genre = new SelectList(genre, "Id", "Name");
        }

        public ViewResult Index()
        {
            var movieList = movieRepo.GetAll();
            return View(movieList);
        }

        public ViewResult Details(int id)
        {
            var movie = movieRepo.GetById(id);
            return View(movie);
        }

        public ViewResult Create(int id)
        {
            DropList();

            return View(new Movie() {GenreId = id, ReleaseYear = DateTime.Now.ToString("dddd, MMMM dd yyyy hh:mm tt") });
        }

        [HttpPost]
        public ActionResult Create(Movie model)
        {
            DropList();

            model.ReleaseYear = DateTime.Now.ToString("dddd, MMMM dd yyyy hh:mm tt");
            movieRepo.Create(model);
            return RedirectToAction("Details", "Movie", new { id = model.Id });
        }

        public ViewResult CreateByGenreId(int genreid)
        {
            DropList();

            return View(new Movie() { GenreId = genreid });
        }


        public ViewResult Update(int id)
        {
            DropList();

            var movie = movieRepo.GetById(id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Update(Movie model)
        {
            DropList();

            model.ReleaseYear = DateTime.Now.ToString("dddd, MMMM dd yyyy hh:mm tt");

            movieRepo.Update(model);
            ViewBag.Result = "You have successfully updated this blog.";
            return RedirectToAction("Details", "Movie", new { id = model.Id });
        }

        //public ViewResult Delete(int id)
        //{
        //    var movie = movieRepo.GetById(id);
        //    movieRepo.Delete(movie);
        //    return View(movie);
        //}

        public ActionResult Delete(int id)
        {
            var movie = movieRepo.GetById(id);
            movieRepo.Delete(movie);
            return RedirectToAction("Index", "Movie");
        }
    }
}
