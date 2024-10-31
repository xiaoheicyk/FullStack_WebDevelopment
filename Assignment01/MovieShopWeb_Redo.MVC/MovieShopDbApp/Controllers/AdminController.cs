using Microsoft.AspNetCore.Mvc;

namespace MovieShopDbApp.Controllers;

public class AdminController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}