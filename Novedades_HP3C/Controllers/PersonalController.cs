using Microsoft.AspNetCore.Mvc;

namespace Novedades_HP3C.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Personal()
        {
            return View();
        }
    }
}
