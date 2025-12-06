using Microsoft.AspNetCore.Mvc;

namespace Novedades_HP3C.Controllers
{
    public class NovedadesController : Controller
    {
        public IActionResult Novedades()
        {
            return View();
        }
    }
}
