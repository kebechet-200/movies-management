using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoviesManagement.Admin.Models;
using MoviesManagement.Services.Abstractions;
using MoviesManagement.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviesManagement.Admin.Controllers
{
    [Authorize(Roles = "Moderator,Admin")]
    public class MovieController : Controller
    {
        public IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await _movieService.GetAllAsync();
            return View(movies.Adapt<List<MovieViewModel>>());
        }

        public async Task<IActionResult> Details(int id)
        {
            var movie = await _movieService.GetAsync(id);
            return View(movie.Adapt<MovieViewModel>());
        }

        public async Task<IActionResult> Edit(int id)
        {
            var movie = await _movieService.GetAsync(id);
            if(movie == null)
            {
                ModelState.AddModelError("", "ფილმი ვერ მოიძებნა");
                return View("NotFound");
            }
            return View(movie.Adapt<MovieViewModel>());
        } 

        [HttpPost]
        public async Task<IActionResult> Edit([FromForm] MovieViewModel model)
        {
            if (model == null)
            {
                ModelState.AddModelError("", "მოდელს ვერ დაამატებ");
                return View("NotFound");
            }

            await _movieService.UpdateAsync(model.Adapt<MovieModel>());

            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] MovieViewModel model)
        {
            if (model == null)
            {
                ModelState.AddModelError("", "ფილმი ვერ ემატება");
                return View("NotFound");
            }

            model.IsActive = false;

            await _movieService.CreateAsync(model.Adapt<MovieModel>());

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await _movieService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> GetNonActive()
        {
            var movies = await _movieService.GetAllNonActiveAsync();
            return View(movies.Adapt<List<MovieViewModel>>());
        }


        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> MakeActive(int id)
        {
            await _movieService.MakeActive(id);
            return RedirectToAction("Index");
        }
    }
}
