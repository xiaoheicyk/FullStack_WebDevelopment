using ApplicationCore.Contracts.Services; // 引入电影服务接口
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging; // 引入日志记录
using ApplicationCore.Models; // 引入电影模型
using System.Diagnostics;

namespace MovieShopDb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<MovieController> _logger;
        private readonly IMovieService _movieService;

        public HomeController(ILogger<MovieController> logger, IMovieService movieService)
        {
            _logger = logger;
            _movieService = movieService;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Login", "User");
        }

    }
}