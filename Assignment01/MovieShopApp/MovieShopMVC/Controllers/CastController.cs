using ApplicationCore.Contracts.Services;
using ApplicationCore.Models.ResponseModels;
using Infrastructure.Models;
using Infrastructure.Servcies;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopMVC.Controllers;

public class CastController : Controller
{
    private readonly ICastService _castService;

    public CastController(ICastService castService)
    {
        _castService = castService;
    }
    // GET
    public async Task<IActionResult> Index(int pageIndex = 1, int pageSize = 100)
    {
        var casts = await _castService.GetAllCastsAsync();
        var castCards = casts.Select(cast => new CastDetailsResponseModel
        {
            Id = cast.Id,
            Name = cast.Name,
            Gender = cast.Gender,
            TmdbUrl = cast.TmdbUrl,
            ProfilePath = cast.ProfilePath
        }).ToList();
        int count = castCards.Count;
        var paginatedCasts = new PaginatedList<CastDetailsResponseModel>(
            castCards.Skip((pageIndex - 1) * pageSize).Take(pageSize), 
            count, 
            pageIndex, 
            pageSize);
        return View(paginatedCasts);
    }
}