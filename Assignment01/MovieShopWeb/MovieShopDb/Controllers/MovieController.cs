using ApplicationCore.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopDb.Controllers;

public class MovieController : Controller
{
    private readonly IMovieService _movieService;

    public MovieController(IMovieService movieService)
    {
        _movieService = movieService;
    }
    // GET
    public IActionResult Index()
    {
        var result = _movieService.GetAllMovies();
        return View(result);
    }
}