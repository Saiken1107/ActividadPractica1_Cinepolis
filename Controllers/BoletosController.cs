using Microsoft.AspNetCore.Mvc;
using Practica1_CINECO.Models;

namespace Practica1_CINECO.Controllers
{
    public class BoletosController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new BoletoModel { Comprador = string.Empty });
        }

        [HttpPost]
        public IActionResult Index(BoletoModel model)
        {
            if (ModelState.IsValid)
            {
                model.TotalPagar = CalcularTotal(model.CantidadBoletos, model.TieneTarjetaCineco);
                return View(model); // Regresa el modelo actualizado
            }

            return View(model);
        }

        private double CalcularTotal(int cantidadBoletos, bool tieneTarjetaCineco)
        {
            const double precioBoleto = 12000;
            double total = cantidadBoletos * precioBoleto;

            if (cantidadBoletos > 15)
            {
                total *= 0.85;
            }
            else if (cantidadBoletos >= 3 && cantidadBoletos <= 5)
            {
                total *= 0.90;
            }

            if (tieneTarjetaCineco)
            {
                total *= 0.90;
            }

            return total;
        }
    }
}