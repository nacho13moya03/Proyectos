using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCaso1.Entidades;
using WebCaso1.Models;

namespace WebCaso1.Controllers
{
    public class MovimientosController : Controller
    {
        MovimientosModel modelo = new MovimientosModel();

        [HttpGet]
        public ActionResult RegistroMovimientos()
        {
            ViewBag.Tipos = modelo.ConsultarTipos();
            return View();
        }

        [HttpPost]
        public ActionResult RegistroMovimientos(MovimientosENT e)
        {
            var respuesta = modelo.RegistrarMovimientos(e);

            if (respuesta > 0)
                return RedirectToAction("RegistroMovimientos", "Movimientos");
            else
                return RedirectToAction("Index", "Home");
        }



        [HttpGet]
        public ActionResult ConsultarMovimientos()
        {
            var datos = modelo.ConsultarMovimientos();
            return View(datos);
        }

    }
}