using Microsoft.AspNetCore.Mvc;

namespace MovieShopDbApp.Controllers;

public class AccountController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}