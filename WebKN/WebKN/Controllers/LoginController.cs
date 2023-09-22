using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebKN.Models;

namespace WebKN.Controllers
{
    public class LoginController : Controller
    {
        Usuario claseUsuario = new Usuario();

        public ActionResult IniciarSesion()
        { 
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }


    }
}