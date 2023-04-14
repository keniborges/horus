using Microsoft.AspNetCore.Mvc;

namespace Aula.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
