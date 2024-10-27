using Microsoft.AspNetCore.Mvc;

namespace MovieShopMVC.Controllers;

public class MovieController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}