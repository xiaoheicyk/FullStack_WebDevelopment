using ApplicationCore.Contracts.Services;
using Infrastructure.Servcies;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopMVC.Controllers;

public class GenreController : Controller
{
    private readonly IGenreService _genreService;

    public GenreController(IGenreService genreService)
    {
        _genreService = genreService;
    }
    // GET
    public async Task<IActionResult> Index()
    {
        var genres = await _genreService.GetAllGenresAsync();
        return View(genres);
    }
}