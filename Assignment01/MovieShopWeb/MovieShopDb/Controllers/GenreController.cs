using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopDb.Controllers;

public class GenreController : Controller
{
    private readonly IGenreService _genreService;
    public GenreController(IGenreService service)
    {
        _genreService = service;
    }

    public IActionResult Index()
    {
        var result = _genreService.GetAllGenres();
        return View(result);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Genre genre)
    {
        if (ModelState.IsValid)
        {
            _genreService.AddGenre(genre);
            return RedirectToAction("Index");
        }
        return View(genre);
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var result = _genreService.GetGenreById(id);
        return View(result);
    }

    [HttpPost]
    public IActionResult Edit(Genre genre)
    {
        if (ModelState.IsValid)
        {
            _genreService.UpdateGenre(genre, genre.Id);
            return RedirectToAction("Index");
        }
        return View(genre);
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var result = _genreService.GetGenreById(id);
        return View(result);
    }

    [HttpPost]
    public IActionResult Delete(Genre genre)
    {
        if (ModelState.IsValid)
        {
            _genreService.DeleteGenre(genre.Id);
            return RedirectToAction("Index");
        }
        return View(genre);
    }
    
    
    
}