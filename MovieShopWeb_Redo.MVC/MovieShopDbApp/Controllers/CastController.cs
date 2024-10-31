using Microsoft.AspNetCore.Mvc;

namespace MovieShopDbApp.Controllers;

public class CastController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}