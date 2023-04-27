using Aula.Models;
using Microsoft.AspNetCore.Mvc;
using RestSharp.Authenticators;
using RestSharp;
using System.Threading;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Aula.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listagem()
        {
            return View();
        }

		public async Task<IActionResult> Form()
		{
            var model = new ClienteModel();
            var estados = await BuscarEstados();
            var estadosSelect = new List<SelectListItem>() { new SelectListItem() { Text = "Escolha o Estado", Value = "" } };
            foreach (var estado in estados.OrderBy(c => c.Nome))
				estadosSelect.Add(new SelectListItem() { Text = estado.Nome, Value = estado.Id.ToString() });
            ViewBag.Estados = estadosSelect;
			return View(model);
		}

        public async Task<List<EstadoModel>> BuscarEstados()
        {
            var options = new RestClientOptions("https://servicodados.ibge.gov.br/");
			var client = new RestClient(options);
			var request = new RestRequest("api/v1/localidades/estados");
			return await client.GetAsync<List<EstadoModel>>(request);
		}
	}
}
