using APIKN.Entities;
using System;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web.Http;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.WebControls;
using System.IO;

namespace APIKN.Controllers
{
    public class LoginController : ApiController
    {
        Utilitarios util = new Utilitarios();

        [HttpPost]
        [Route("RegistrarCuenta")]
        public string RegistrarCuenta(UsuarioEnt entidad)
        {
            try
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
                    return "OK";
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        [HttpPost]
        [Route("IniciarSesion")]
        public IniciarSesionSP_Result IniciarSesion(UsuarioEnt entidad)
        {
            try
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
            catch (Exception)
            {
                return null;
            }
        }

        [HttpPost]
        [Route("RecuperarCuenta")]
        public string RecuperarCuenta(UsuarioEnt entidad)
        {
            try
            {
                using (var context = new BDKNEntities())
                {
                    var datos = context.RecuperarCuentaSP(entidad.Identificacion).FirstOrDefault();

                    if (datos != null)
                    {
                        string rutaArchivo = @"C:\Contrasenna.html";
                        string html = File.ReadAllText(rutaArchivo);

                        html = html.Replace("@@Nombre", datos.Nombre);
                        html = html.Replace("@@Contrasenna", datos.Contrasenna);

                        util.EnviarCorreo(datos.Correo, "Contraseña de Acceso", html);
                        return "OK";
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

    }
}
 