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
    public class ReviewController : Controller
    {
        IRepository<Review> reviewRepo;

        public ReviewController(IRepository<Review> reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }

        public ViewResult Index(int movieId)
        {

            return View(reviewRepo.GetReviewsByMovieId(movieId));
        }

        public ViewResult Create(int id)
        {
            var movie = reviewRepo.PopulateMovieList();

            ViewBag.Movie = new SelectList(movie, "Id", "Title");

            int[] Ratings = { 1, 2, 3, 4, 5 };
            ViewBag.Ratings = new SelectList(Ratings);

            return View(new Review() { MovieId = id });
        }

        [HttpPost]
        public ViewResult Create(Review model)
        {
            var movie = reviewRepo.PopulateMovieList();
            ViewBag.Movie = new SelectList(movie, "Id", "Title");

            int[] Ratings = { 1, 2, 3, 4, 5 };
            ViewBag.Ratings = new SelectList(Ratings);

            model.AddRatings();
            model.AddReviews();
            reviewRepo.Create(model);
            ViewBag.Result = "Thanks for your review!";
            return View(model);
        }



        public ViewResult CreateByMovieId(int movieId)
        {
            var movie = reviewRepo.PopulateMovieList();

            ViewBag.Content = new SelectList(movie, "Id", "Title");

            int[] Ratings = { 1, 2, 3, 4, 5 };
            ViewBag.Ratings = new SelectList(Ratings);

            return View(new Review() { MovieId = movieId });
        }

        [HttpPost]
        public ActionResult CreateByMovieId(Review model)
        {
            //var movie = reviewRepo.PopulateMovieList();
            //ViewBag.Movie = new SelectList(movie, "Id", "Title");

            int[] Ratings = { 1, 2, 3, 4, 5 };
            ViewBag.Ratings = new SelectList(Ratings);

            model.AddRatings();
            model.AddReviews();
            reviewRepo.Create(model);
            ViewBag.Result = "Thanks for your review!";
            return RedirectToAction("Details", "Movie", new { id = model.MovieId });
        }


        public ActionResult Delete(int id)
        {
            var review = reviewRepo.GetById(id);
            review.DeleteReview();
            reviewRepo.Delete(review);
            return RedirectToAction("Details", "Movie", new { id = review.MovieId });
        }


        public ViewResult Update(int id)
        {
            var movie = reviewRepo.PopulateMovieList();

            ViewBag.Movie = new SelectList(movie, "Id", "Title");

            int[] Ratings = { 1, 2, 3, 4, 5 };
            ViewBag.Ratings = new SelectList(Ratings);


            var review = reviewRepo.GetById(id);

            return View(review);
        }

        [HttpPost]
        public ActionResult Update(Review model)
        {

            var movie = reviewRepo.PopulateMovieList();

            ViewBag.Movie = new SelectList(movie, "Id", "Title");

            int[] Ratings = { 1, 2, 3, 4, 5 };
            ViewBag.Ratings = new SelectList(Ratings);

            reviewRepo.Update(model);
            ViewBag.Result = "You have successfuly upodated this review";
            return RedirectToAction("Details", "Movie", new { id = model.MovieId });
        }
    }
}
