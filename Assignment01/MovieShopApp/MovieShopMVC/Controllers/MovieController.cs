using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Models.ResponseModels;
using Infrastructure.Models;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopMVC.Controllers;


public class MovieController : Controller
{
    private readonly IMovieService _movieService;
    private readonly IGenreService _genreService;

    public MovieController(IMovieService movieService,IGenreService genreService)
    {
        _movieService = movieService;
        _genreService = genreService;

    }
    // GET
    
    public async Task<IActionResult> Index(int pageIndex = 1, int pageSize = 40)
    {
        var genres = await _genreService.GetAllGenresAsync();
        ViewData["genres"] = genres;
        
        var movies = await _movieService.GetAllMoviesAsync();
        var movieCards = movies.Select(movie => new MovieCardResponseModel
        {
            Id = movie.Id,
            BackdropPath = movie.BackdropUrl,
            ImbdUrl = movie.ImdbUrl,
            Title = movie.Title
        }).ToList();
        int totalCount = movieCards.Count();
        var paginatedMovies = new PaginatedList<MovieCardResponseModel>(
            movieCards.Skip((pageIndex - 1) * pageSize).Take(pageSize), 
            totalCount, 
            pageIndex, 
            pageSize);
        return View(paginatedMovies);
    }

    [Route("movie/bygenre/{GenreId}")]
    public async Task<IActionResult> ByGenre(int GenreId, int pageIndex = 1, int pageSize = 40,int? genreId = null)
    {
        var genre = await _genreService.GetGenreByIdAsync(GenreId);
        ViewData["GenreName"] = genre.Name;
        var genres = await _genreService.GetAllGenresAsync();
        ViewData["genres"] = genres;
        var movies = await _movieService.GetMoviesByGenreAsync(GenreId);
        var movieCards = movies.Select(movie => new MovieCardResponseModel
        {
            Id = movie.Id,
            BackdropPath = movie.BackdropUrl,
            ImbdUrl = movie.ImdbUrl,
            Title = movie.Title
        }).ToList();
        int totalCount = movieCards.Count();
        var paginatedMovies = new PaginatedList<MovieCardResponseModel>(
            movieCards.Skip((pageIndex - 1) * pageSize).Take(pageSize), 
            totalCount, 
            pageIndex, 
            pageSize);
        ViewData["GenreId"] = GenreId;
        return View(paginatedMovies);
    }

    public async Task<IActionResult> Details(int id)
    {
        var movie = await _movieService.GetMovieByIdAsync(id);
        return View(movie);
    }

    public async Task<IActionResult> Top(int number = 20)
    {
        var movies = await _movieService.GetTopRevenueAsync(number);
        return View(movies);
    }
    
}