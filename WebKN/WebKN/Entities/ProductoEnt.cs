﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebKN.Entities
{
    public class ProductoEnt
    {
        public long ConProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string Imagen { get; set; }
        public bool Estado { get; set; }
    }
}