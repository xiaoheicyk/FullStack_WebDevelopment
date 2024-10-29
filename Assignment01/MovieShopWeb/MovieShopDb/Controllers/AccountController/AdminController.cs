using Microsoft.AspNetCore.Mvc;

namespace MovieShopDb.Controllers;

public class AdminController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}