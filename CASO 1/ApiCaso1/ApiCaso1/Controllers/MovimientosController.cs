using ApiCaso1.Entidades;
using ApiCaso1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ApiCaso1.Controllers
{
    public class MovimientosController : ApiController
    {

        [HttpGet]
        [Route("ConsultarMovimientos")]
        public List<ConsultarMovimientos_SP_Result> ConsultarMovimientos()
        {
            using (var contexto = new CasoEstudioKNEntities())
            {
                return contexto.ConsultarMovimientos_SP().ToList();
            }
        }

        [HttpGet]
        [Route("ConsultarTipos")]
        public List<System.Web.Mvc.SelectListItem> ConsultarTipos()
        {
            using (var contexto = new CasoEstudioKNEntities())
            {
                var datos = (from x in contexto.TiposMovimientos
                             select x).ToList();

                var combo = new List<System.Web.Mvc.SelectListItem>();
                foreach (var item in datos)
                {
                    combo.Add(new System.Web.Mvc.SelectListItem
                    {
                        Value = item.TipoMovimiento.ToString(),
                        Text = item.DescripcionTipoMovimiento
                    });
                }

                return combo;
            }
        }

        [HttpPost]
        [Route("RegistrarMovimientos")]
        public int RegistrarMovimientos(MovimientosENT e)
        {
            using (var contexto = new CasoEstudioKNEntities())
            {
                return contexto.RegistrarMovimientos_SP(e.Descripcion,e.Monto,e.TipoMovimiento);
            }
        }

    }
}
