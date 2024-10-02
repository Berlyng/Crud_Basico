using CRUD_Basico.web.Data;
using CRUD_Basico.web.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Basico.web.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly EmpleadoContex _contex;
        public EmpleadoController(EmpleadoContex contex)
        {
            _contex = contex;
        }
        public async Task<IActionResult> Index()
        {
            List<E_Empleados> info = await _contex.Empleados.ToListAsync();
            return View(info);
        }

        [HttpGet]
		public IActionResult Nuevo()
		{

			return View();
		}



	}
}
