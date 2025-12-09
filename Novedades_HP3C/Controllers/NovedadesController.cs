using Microsoft.AspNetCore.Mvc;

namespace Novedades_HP3C.Controllers
{
    public class NovedadesController : Controller
    {
        public IActionResult ConfigNovedades()
        {
            return View();
        }
        public IActionResult CargaNovedades()
        {
            return View();
        }
        public IActionResult ControlNovedades()
        {
            return View();
        }
    }
}
