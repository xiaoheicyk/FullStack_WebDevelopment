using Microsoft.AspNetCore.Mvc;

namespace MovieShopDbApp.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}