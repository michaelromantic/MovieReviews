using Microsoft.AspNetCore.Mvc;
using Movies.Models;
using Movies.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Controllers
{
    public class GenreController : Controller
    {
        IRepository<Genre> genreRepo;

        public GenreController(IRepository<Genre> genreRepo)
        {
            this.genreRepo = genreRepo;
        }

        public ViewResult Index()
        {
            var genreList = genreRepo.GetAll();
            return View(genreList);
        }

        public ViewResult Details(int id)
        {
            var genre = genreRepo.GetById(id);
            return View(genre);
        }
    }
}
