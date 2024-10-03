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


		[HttpPost]
		public async Task<IActionResult> Nuevo(E_Empleados empleado)
		{
            await _contex.Empleados.AddAsync(empleado);
            await _contex.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

		}

		[HttpGet]
		public async Task<IActionResult>Editar(int id)
		{
            E_Empleados empleado = await _contex.Empleados.FirstAsync(e => e.Id == id);

			return View(empleado);
		}

		[HttpPost]
		public async Task<IActionResult> Editar(E_Empleados empleado)
		{
			 _contex.Empleados.Update(empleado);
			await _contex.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		[HttpGet]
		public async Task<IActionResult> Eliminar(int id)
		{
			E_Empleados empleado = await _contex.Empleados.FirstAsync(e => e.Id == id);
			_contex.Empleados.Remove(empleado);
			await _contex.SaveChangesAsync();

			return RedirectToAction(nameof(Index));
		}


	}
}
