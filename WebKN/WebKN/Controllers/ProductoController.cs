using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebKN.Models;

namespace WebKN.Controllers
{
    public class ProductoController : Controller
    {
        ProductoModel modelProducto = new ProductoModel();

        [HttpGet]
        public ActionResult ConsultaProductos()
        {
            var datos = modelProducto.ConsultaProductos();
            return View(datos);
        }
    }
}