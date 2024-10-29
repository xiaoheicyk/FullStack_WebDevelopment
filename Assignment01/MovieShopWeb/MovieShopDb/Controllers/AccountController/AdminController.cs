using Microsoft.AspNetCore.Mvc;

namespace YourProjectName.MVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult ManageUsers()
        {
            return View();
        }

        public IActionResult ManageMovies()
        {
            return View();
        }
    }
}