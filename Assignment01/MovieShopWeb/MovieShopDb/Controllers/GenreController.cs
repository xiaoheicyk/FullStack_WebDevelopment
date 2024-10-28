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
    
}