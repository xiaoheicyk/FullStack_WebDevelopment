using ApplicationCore.Contracts.Services;
using Infrastruture.Data;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopDb.Controllers;

public class GenreController : Controller
{
    private readonly IGenreService _context;

    public GenreController(IGenreService context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var result = _context.GetAllGenres();
        return View(result);

    }
    
    
}