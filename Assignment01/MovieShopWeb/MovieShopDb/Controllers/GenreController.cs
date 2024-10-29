using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MovieShopDb.Controllers
{
    public class GenreController : Controller
    {
        private readonly IGenreService _genreService;

        public GenreController(IGenreService service)
        {
            _genreService = service;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _genreService.GetAllGenresAsync();
            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Genre genre)
        {
            if (ModelState.IsValid)
            {
                await _genreService.AddGenreAsync(genre);
                return RedirectToAction("Index");
            }
            return View(genre);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var result = await _genreService.GetGenreByIdAsync(id);
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Genre genre)
        {
            if (ModelState.IsValid)
            {
                await _genreService.UpdateGenreAsync(genre, genre.Id);
                return RedirectToAction("Index");
            }
            return View(genre);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _genreService.GetGenreByIdAsync(id);
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Genre genre)
        {
            if (ModelState.IsValid)
            {
                await _genreService.DeleteGenreAsync(genre.Id);
                return RedirectToAction("Index");
            }
            return View(genre);
        }
    }
}