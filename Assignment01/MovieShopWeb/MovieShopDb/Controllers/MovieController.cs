using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models;
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
        var movies = _movieService.GetAllMovies();
        var movieCards = movies.Select(movie => new MovieCardModel
        {
            MovieId = movie.Id,
            Title = movie.Title, 
            BackdropPath= movie.BackdropUrl,
            ImdbUrl = movie.ImdbUrl
        }).ToList();
        return View(movieCards as IEnumerable<MovieCardModel>);
    }
    
}