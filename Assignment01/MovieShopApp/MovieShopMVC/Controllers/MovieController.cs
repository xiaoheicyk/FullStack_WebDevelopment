using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
using Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopMVC.Controllers;

public class MovieController : Controller
{
    private readonly IMovieService _movieService;
    private readonly IGenreService _genreService;

    public MovieController(IMovieService movieService)
    {
        _movieService = movieService;
        
    }
    // GET
    public async Task<IActionResult> Index(int pageIndex = 1, int pageSize = 40)
    {
        var movies = await _movieService.GetAllMoviesAsync();
        var movieCards = movies.Select(movie => new MovieCardModel
        {
            Id = movie.Id,
            BackdropPath = movie.BackdropUrl,
            ImbdUrl = movie.ImdbUrl,
            Title = movie.Title
        }).ToList();
        int totalCount = movieCards.Count();
        var paginatedMovies = new PaginatedList<MovieCardModel>(
            movieCards.Skip((pageIndex - 1) * pageSize).Take(pageSize), 
            totalCount, 
            pageIndex, 
            pageSize);
        return View(paginatedMovies);
    }

    public async Task<IActionResult> ByGenre(int GenreId, int pageIndex = 1, int pageSize = 40)
    {
        var movies = await _movieService.GetMoviesByGenreAsync(GenreId);
        var movieCards = movies.Select(movie => new MovieCardModel
        {
            Id = movie.Id,
            BackdropPath = movie.BackdropUrl,
            ImbdUrl = movie.ImdbUrl,
            Title = movie.Title
        }).ToList();
        int totalCount = movieCards.Count();
        var paginatedMovies = new PaginatedList<MovieCardModel>(
            movieCards.Skip((pageIndex - 1) * pageSize).Take(pageSize), 
            totalCount, 
            pageIndex, 
            pageSize);
        ViewData["GenreId"] = GenreId;
        return View(paginatedMovies);
    }
    
}