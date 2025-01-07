////////10////////20////////30////////40////////50////////60////////70////////80////////90///////100///////110///////120

using ManejoPresupuesto.Models;

using Microsoft.AspNetCore.Mvc;

//..............................................................................

namespace ManejoPresupuesto.Controllers
{
    public class TiposCuentasController : Controller
    {
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(TipoCuenta tipoCuenta)
        {
            // Si las validaciones también se están manejando a nivel front-end,
            // ¿por qué validarlas en el back-end? Porque no se puede confiar en
            // la información que viene del front-end.
            if (!ModelState.IsValid)
            {
                return View(tipoCuenta);
            }
            return View();
        }
    }
}
