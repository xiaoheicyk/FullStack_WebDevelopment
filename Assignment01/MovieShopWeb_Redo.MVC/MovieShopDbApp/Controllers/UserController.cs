using Microsoft.AspNetCore.Mvc;

namespace MovieShopDbApp.Controllers;

public class UserController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}