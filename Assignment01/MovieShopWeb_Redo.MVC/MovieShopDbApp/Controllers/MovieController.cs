using ApplicationCore.Models;
using ApplicationCore.Contracts.Repositories;
using Infrastructure.Models;
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
    public async Task<IActionResult> Index(int pageIndex = 1, int pageSize = 40)
    {
        var movies = await _movieRepository.GetAllAsync();
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
        return View((PaginatedList<MovieCardModel>)(paginatedMovies as IEnumerable<MovieCardModel>));
    }
    
    
}