using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Models;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopDbApp.Controllers;

public class GenreController : Controller
{
    private readonly IGenreRepository _genreRepository;
    private readonly IMovieRepository _movieRepository;

    public GenreController(IGenreRepository genreRepository,IMovieRepository movieRepository)
    {
        _genreRepository = genreRepository;
        _movieRepository = movieRepository;
    }
    
    
    // GET
    public async Task<IActionResult> Index()
    {

        return View();
    }
}