using Microsoft.AspNetCore.Mvc;

namespace Cursos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Programacion()
        {
            return View();
        }
        public IActionResult IngenieriaCostos()
        {
            return View();
        }
        public IActionResult InvestigacionOperativa()
        {
            return View();
        }
        public IActionResult TeoriaSistemas()
        {
            return View();
        }
        public IActionResult IngenieriaSoftware()
        {
            return View();
        }
    }
}