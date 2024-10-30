using ApplicationCore.Models;
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
        var movieCards = movies.Select(movie => new MovieCardModel
        {
            Id = movie.Id,
            BackdropPath = movie.BackdropUrl,
            ImbdUrl = movie.ImdbUrl,
            Title = movie.Title
        }).ToList();
        return View(movieCards as IEnumerable<MovieCardModel>);
    }
    
    
}