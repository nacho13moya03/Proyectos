using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebKN.Entities;

namespace WebKN.Models
{
    public class UsuarioModel
    {

        public void IniciarSesion(UsuarioEnt entidad)
        { 
            // LLAMAR AL WEB API PARA VALIDAR EL ACCESO DEL USUARIO
        }

        public void RegistrarCuenta(UsuarioEnt entidad)
        {
            // LLAMAR AL WEB API PARA REGISTRAR EL USUARIO
        }

        public void RecuperarCuenta(UsuarioEnt entidad)
        {
            // LLAMAR AL WEB API PARA VALIDAR SI ES UN USUARIO VALIDO Y LE MANDO UN CORREO
        }

    }
}