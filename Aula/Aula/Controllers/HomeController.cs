using Aula.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Aula.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult TesteTagHelper()
        {
            var model = new ClienteModel();

            ViewBag.MeuViewBag = "Teste";
            ViewData["MeuOutroBg"] = "Outro Teste";

            return View(model);
        }

        [HttpPost]
		public IActionResult TesteTagHelper(ClienteModel model)
		{
            if (ModelState.IsValid)
            {

            }
			return View(model);
		}

		public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}