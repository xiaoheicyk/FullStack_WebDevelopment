using ApplicationCore.Contracts.Models;
using ApplicationCore.Contracts.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopDbApp.Controllers;

public class MovieController : Controller
{
    private readonly IMovieRepository _movieRepository;

    public MovieController(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }
    
    
    
    // GET
    public async Task<IActionResult> Index()
    {
        var movies = await _movieRepository.GetAllAsync();
        return View(movies);
    }
    
    
}