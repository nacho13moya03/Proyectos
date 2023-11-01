using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiCaso1.Entidades
{
    public class MovimientosENT
    {
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public int TipoMovimiento { get; set; }

    }
}