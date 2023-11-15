﻿using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace APIKN.Controllers
{
    public class ProductoController : ApiController
    {

        [HttpGet]
        [Route("ConsultaProductos")]
        public List<TProducto> ConsultaProductos()
        {
            using (var context = new BDKNEntities())
            {
                return context.TProducto.ToList();
            }
        }

        [HttpPost]
        [Route("RegistrarProducto")]
        public long RegistrarProducto(TProducto tProducto)
        {
            using (var context = new BDKNEntities())
            {
                context.TProducto.Add(tProducto);
                context.SaveChanges();
                return tProducto.ConProducto;
            }
        }

        [HttpPut]
        [Route("ActualizarRutaProducto")]
        public string ActualizarRutaProducto(TProducto tProducto)
        {
            using (var context = new BDKNEntities())
            {
                var datos = context.TProducto.Where(x => x.ConProducto == tProducto.ConProducto).FirstOrDefault();
                datos.Imagen = tProducto.Imagen;
                context.SaveChanges();
                return "OK";
            }
        }


        /*
       

        // GET: api/Producto/5
        [ResponseType(typeof(TProducto))]
        public IHttpActionResult GetTProducto(long id)
        {
            TProducto tProducto = db.TProducto.Find(id);
            if (tProducto == null)
            {
                return NotFound();
            }

            return Ok(tProducto);
        }

        // DELETE: api/Producto/5
        [ResponseType(typeof(TProducto))]
        public IHttpActionResult DeleteTProducto(long id)
        {
            TProducto tProducto = db.TProducto.Find(id);
            if (tProducto == null)
            {
                return NotFound();
            }

            db.TProducto.Remove(tProducto);
            db.SaveChanges();

            return Ok(tProducto);
        }

        private bool TProductoExists(long id)
        {
            return db.TProducto.Count(e => e.ConProducto == id) > 0;
        }
        */

    }
}