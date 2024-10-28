using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopDb.Controllers;

public class MovieController : Controller
{
    private readonly IMovieService _movieService;
    public MovieController(IMovieService service)
    {
        _movieService = service;
    }

    public IActionResult Index()
    {
        var result = _movieService.GetAllMovies();
        return View(result);
    }
    
}