//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIKN
{
    using System;
    using System.Collections.Generic;
    
    public partial class TUsuario
    {
        public long ConUsuario { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contrasenna { get; set; }
        public bool Estado { get; set; }
        public long ConProvincia { get; set; }
        public long ConRol { get; set; }
    
        public virtual TProvincia TProvincia { get; set; }
        public virtual TRol TRol { get; set; }
    }
}
