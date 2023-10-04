﻿using APIKN.Entities;
using System.Linq;
using System.Web.Http;

namespace APIKN.Controllers
{
    public class LoginController : ApiController
    {

        [HttpPost]
        [Route("RegistrarCuenta")]
        public string RegistrarCuenta(UsuarioEnt entidad)
        {
            using (var context = new BDKNEntities())
            {
                //TUsuario user = new TUsuario();
                //user.Identificacion = entidad.Identificacion;
                //user.Nombre = entidad.Nombre;
                //user.Correo = entidad.Correo;
                //user.Contrasenna = entidad.Contrasenna;
                //user.Estado = entidad.Estado;
                //user.Direccion = entidad.Direccion;

                //context.TUsuario.Add(user);
                //context.SaveChanges();

                context.RegistrarCuentaSP(entidad.Identificacion, entidad.Nombre, entidad.Correo, entidad.Contrasenna, entidad.Estado, entidad.Direccion);
                return "Registro realizado correctamente";
            }
        }

        [HttpPost]
        [Route("IniciarSesion")]
        public IniciarSesionSP_Result IniciarSesion(UsuarioEnt entidad)
        {
            using (var context = new BDKNEntities())
            {
                //return (from x in context.TUsuario 
                //             where x.Correo == entidad.Correo
                //             && x.Contrasenna == entidad.Contrasenna
                //             && x.Estado == true
                //             select x).FirstOrDefault();

                return context.IniciarSesionSP(entidad.Correo, entidad.Contrasenna).FirstOrDefault();
            }
        }

    }
}