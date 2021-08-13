using Microsoft.AspNetCore.Mvc;
using Movies.Models;
using System;

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
            var categories = movieRepo.PopulateCategoryList();
            ViewBag.Category = new SelectList(categories, "Id", "Name");
        }

        public ViewResult Index()
        {
            var contentList = movieRepo.GetAll();
            return View(contentList);
        }

        public ViewResult Details(int id)
        {
            var content = movieRepo.GetById(id);
            return View(content);
        }

        public ViewResult Create(int id)
        {
            DropList();

            return View(new Movie() { CategoryId = id, ReleaseYear = DateTime.Now.ToString("dddd, MMMM dd yyyy hh:mm tt") });
        }

        [HttpPost]
        public ActionResult Create(Movie model)
        {
            DropList();

            model.ReleaseYear = DateTime.Now.ToString("dddd, MMMM dd yyyy hh:mm tt");
            movieRepo.Create(model);
            return RedirectToAction("Details", "Movie", new { id = model.Id });
        }

        public ViewResult CreateByCategoryId(int categoryid)
        {
            DropList();

            return View(new Movie() { CategoryId = categoryid });
        }


        public ViewResult Update(int id)
        {
            DropList();

            var content = movieRepo.GetById(id);
            return View(content);
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
        //    var content = contentRepo.GetById(id);
        //    contentRepo.Delete(content);
        //    return View(content);
        //}

        public ActionResult Delete(int id)
        {
            var content = movieRepo.GetById(id);
            movieRepo.Delete(content);
            return RedirectToAction("Index", "Movie");
        }
    }
}
