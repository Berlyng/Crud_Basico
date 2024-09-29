using CRUD_Basico.web.Data;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Basico.web.Controllers
{
    public class EmpleadoController : Controller
    {
		private readonly EmpleadoContex _contex;
		public EmpleadoController(EmpleadoContex contex)
        {
            _contex = contex;
        }
        public IActionResult Index()
        {
            var info = _contex.Empleados.ToList();
            return View(info);
        }
    }
}
