using APIKN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIKN.Controllers
{
    public class UsuarioController : ApiController
    {

        [HttpGet]
        [Route("ConsultaUsuarios")]
        public List<TUsuario> ConsultaUsuarios()
        {
            try
            {
                using (var context = new BDKNEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    var datos = (from x in context.TUsuario
                            select x).ToList();

                    return datos;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("ConsultarProvincias")]
        public List<System.Web.Mvc.SelectListItem> ConsultarProvincias()
        {
            try
            {
                using (var context = new BDKNEntities())
                {
                    var datos = (from x in context.TProvincia
                                 select x).ToList();

                    List<System.Web.Mvc.SelectListItem> direcciones = new List<System.Web.Mvc.SelectListItem>();
                    foreach (var item in datos)
                    {
                        direcciones.Add(new System.Web.Mvc.SelectListItem { Value = item.ConProvincia.ToString(), Text = item.Descripcion });
                    }

                    return direcciones;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
