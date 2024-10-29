using Microsoft.AspNetCore.Mvc;

namespace MovieShopDb.Controllers;

public class AccountController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}