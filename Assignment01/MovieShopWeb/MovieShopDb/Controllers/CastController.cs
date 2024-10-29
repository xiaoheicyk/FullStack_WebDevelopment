using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
using Infrastruture.Data;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopDb.Controllers;

public class CastController : Controller
{
    private readonly ICastService _service;

    public CastController(ICastService service)
    {
        _service = service;
    }
    // GET
    public IActionResult Index()
    {
        var casts = _service.GetAllCasts();
        var castCards = casts.Select(cast => new CastCardModel
        {
            Id = cast.Id,
            Name = cast.Name,
            ProfilePath = cast.ProfilePath,
            TmdbUrl = cast.TmdbUrl
        }).ToList();
        return View(castCards as IEnumerable<CastCardModel>);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
}