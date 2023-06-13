using AplicacionAsenet.Models;
using AplicacionAsenet.Models.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacionAsenet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Application _Datos = new Application();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpPost]
        public IActionResult Guardar(VentaModel obj)
        {
            //METODO RECIBE EL OBJETO PARA GUARDARLO EN BD
            if (!ModelState.IsValid)
                return View();


            var respuesta = _Datos.VentaProducto(obj);

            if (respuesta)
                return RedirectToAction("Index");
            else

                return View();

        }
        public IActionResult Index()
        {
            var Ventas = _Datos.VentasTotales();
            return View(Ventas);
        }
        public IActionResult ProductoMasVendido()
        {
            var Ventas = _Datos.ProductoMasVendido();
            return View(Ventas);
        }
        public IActionResult ProductoMenosVendido()
        {
            var Ventas = _Datos.ProductoMenosVendido();
            return View(Ventas);
        }
        public IActionResult VentaProducto()
        {
            //Productos
            ViewBag.Producto = _Datos.Productos().Select(x => new SelectListItem() { Value = x.Id_Producto.ToString(), Text = x.Nombre_Producto }).ToList<SelectListItem>();
            //Clientes
            ViewBag.Cliente = _Datos.Clientes().Select(x => new SelectListItem() { Value = x.Id_cliente.ToString(), Text = x.Nombre }).ToList<SelectListItem>();
            //TipoVenta
            ViewBag.TipoVenta = _Datos.TipoVentas().Select(x => new SelectListItem() { Value = x.Id_TipoVenta.ToString(), Text = x.Tipo_Venta }).ToList<SelectListItem>();



            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
