using Microsoft.AspNetCore.Mvc;

namespace MovieShopDb.Controllers;

public class UserController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}