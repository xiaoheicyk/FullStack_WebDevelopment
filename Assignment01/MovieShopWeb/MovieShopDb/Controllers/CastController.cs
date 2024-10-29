using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShopDb.Controllers
{
    public class CastController : Controller
    {
        private readonly ICastService _service;

        public CastController(ICastService service)
        {
            _service = service;
        }

        // GET
        public async Task<IActionResult> Index()
        {
            var casts = await _service.GetAllCastsAsync();
            var castCards = casts.Select(cast => new CastCardModel
            {
                Id = cast.Id,
                Name = cast.Name,
                ProfilePath = cast.ProfilePath,
                TmdbUrl = cast.TmdbUrl
            }).ToList();
            return View(castCards);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}