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

    public async Task<IActionResult> Index()
    {
        var movies =await _movieService.GetAllMoviesAsync();
        var movieCards = movies.Select(movie => new MovieCardModel
        {
            MovieId = movie.Id,
            Title = movie.Title, 
            BackdropPath= movie.BackdropUrl,
            ImdbUrl = movie.ImdbUrl
        }).ToList();
        return View(movieCards as IEnumerable<MovieCardModel>);
    }
    
    public async Task<IActionResult> TopRevenueMovies(int number = 20)
    {
        var movies = await _movieService.GetTopRevenueMoviesAsync(number);
        var movieCards = movies.Select(movie => new MovieCardModel
        {
            MovieId = movie.Id,
            Title = movie.Title,
            BackdropPath = movie.BackdropUrl,
            ImdbUrl = movie.ImdbUrl
        }).ToList();
        return View(movieCards as IEnumerable<MovieCardModel>);
    }
    
    public async Task<IActionResult> SearchById(int id)
    {
        var movie = await _movieService.GetMovieDetailsAsync(id);
        if (movie == null)
        {
            return NotFound();
        }

        return View("MovieDetails",movie);
    }


    
    
    public async Task<IActionResult> Details(int id)
         {
             var movie = await _movieService.GetMovieDetailsAsync(id);
             if (movie == null)
             {
                 return NotFound();
             }
     
             return View("MovieDetails",movie);
         }
    
    
    
    
    
}