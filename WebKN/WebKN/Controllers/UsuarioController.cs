using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebKN.Entities;
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
            var datos = modelUsuario.ConsultaUsuario();
            Session["NombreUsuario"] = datos.Nombre;
            ViewBag.Direcciones = modelUsuario.ConsultarProvincias();
            return View(datos);
        }

        [HttpPost]
        public ActionResult PerfilUsuario(UsuarioEnt entidad)
        {
            string respuesta = modelUsuario.ActualizarCuenta(entidad);

            if (respuesta == "OK")
            {
                return RedirectToAction("PerfilUsuario", "Usuario");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido actualizar su información";
                ViewBag.Direcciones = modelUsuario.ConsultarProvincias();
                return View();
            }
        }

    }
}