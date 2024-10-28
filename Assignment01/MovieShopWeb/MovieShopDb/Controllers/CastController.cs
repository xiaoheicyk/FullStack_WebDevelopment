using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
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
        var result = _service.GetAllCasts();
        return View(result);
    }
}