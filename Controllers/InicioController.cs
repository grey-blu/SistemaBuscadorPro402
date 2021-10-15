using Microsoft.AspNetCore.Mvc;

namespace SistemaBuscador.Controllers
{
    public class InicioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}