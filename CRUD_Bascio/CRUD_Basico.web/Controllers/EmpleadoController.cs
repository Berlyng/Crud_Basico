using Microsoft.AspNetCore.Mvc;

namespace CRUD_Basico.web.Controllers
{
    public class EmpleadoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
