using EntidadDTO;
using LogicaNegocio.ConexionAPI;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Formatting;

namespace LogicaNegocio
{
    public class Autores : IAutores
    {
        private readonly URL conexion = new URL();
        public async Task<List<AutoresDTO>> ConsultarAutores()
        {
            using (var client = new HttpClient())
            {

                HttpResponseMessage response = await client.GetAsync($"{conexion.URLConnect}autores/listado");
                var jsonString = await response.Content.ReadAsStringAsync();
                List<AutoresDTO> lista = JsonConvert.DeserializeObject<List<AutoresDTO>>(jsonString);
                return lista;

            }
        }

        public async Task<string> RegistrarAutor(AutoresDTO autor)
        {

            using (var client = new HttpClient())
            {

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.PostAsJsonAsync($"{conexion.URLConnect}autores",autor);
                return response.Content.ReadAsStringAsync().Result;


            }
        }
    }
}
