using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebKN.Models;

namespace WebKN.Controllers
{
    public class UsuarioController : Controller
    {
        UsuarioModel modelUsuario = new UsuarioModel();

        [HttpGet]
        public ActionResult ConsultaUsuarios()
        {
            var datos = modelUsuario.ConsultaUsuarios();
            return View(datos);
        }

        [HttpGet]
        public ActionResult PerfilUsuario()
        {
            ViewBag.Direcciones = modelUsuario.ConsultarProvincias();
            return View();
        }
    }
}