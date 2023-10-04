using APIKN.Entities;
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
                TUsuario user = new TUsuario();
                user.Identificacion = entidad.Identificacion;
                user.Nombre = entidad.Nombre;
                user.Correo = entidad.Correo;
                user.Contrasenna = entidad.Contrasenna;
                user.Estado = entidad.Estado;
                user.Direccion = entidad.Direccion;
                
                context.TUsuario.Add(user);
                context.SaveChanges();

                return "Registro realizado correctamente";
            }
        }

    }
}
