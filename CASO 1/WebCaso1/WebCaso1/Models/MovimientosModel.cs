using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Web;
using System.Web.Mvc;
using WebCaso1.Entidades;

namespace WebCaso1.Models
{
    public class MovimientosModel
    {

        public int RegistrarMovimientos(MovimientosENT e)
        {
            using (var http = new HttpClient())
            {
                var url = "https://localhost:44351/RegistrarMovimientos";
                JsonContent json = JsonContent.Create(e);
                var resp = http.PostAsync(url, json).Result;

                if (resp.IsSuccessStatusCode)
                    return resp.Content.ReadFromJsonAsync<int>().Result;
                else
                    return 0;
            }
        }

        public List<SelectListItem> ConsultarTipos()
        {
            using (var http = new HttpClient())
            {
                var url = "https://localhost:44351/ConsultarTipos";
                var resp = http.GetAsync(url).Result;

                if (resp.IsSuccessStatusCode)
                    return resp.Content.ReadFromJsonAsync<List<SelectListItem>>().Result;
                else
                    return new List<SelectListItem>();
            }
        }

        public List<MovimientosENT> ConsultarMovimientos()
        {
            using (var http = new HttpClient())
            {
                var url = "https://localhost:44351/ConsultarMovimientos";
                var resp = http.GetAsync(url).Result;

                if (resp.IsSuccessStatusCode)
                    return resp.Content.ReadFromJsonAsync<List<MovimientosENT>>().Result;
                else
                    return new List<MovimientosENT>();
            }
        }

    }
}