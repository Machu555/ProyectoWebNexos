using EntidadDTO;
using EntidadDTO.DTOInput;
using LogicaNegocio.ConexionAPI;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Libros : ILibros
    {
        private readonly URL conexion = new URL();
        public async Task<List<LibrosDTO>> ConsultarLibros()
        {
            using (var client = new HttpClient())
            {

                HttpResponseMessage response = await client.GetAsync($"{conexion.URLConnect}libros/listado");
                var jsonString = await response.Content.ReadAsStringAsync();
                List<LibrosDTO> lista = JsonConvert.DeserializeObject<List<LibrosDTO>>(jsonString);
                return lista;

            }
        }

        public async Task<List<LibrosDTO>> ConsultarLibrospalabraClave(LibrosPalabraClaveDTOIn palabraClave)
        {
            using (var client = new HttpClient())
            {

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.PostAsJsonAsync($"{conexion.URLConnect}libros/listadoPalabraClave", palabraClave);
                var jsonString =  await response.Content.ReadAsStringAsync();
                List<LibrosDTO> lista = JsonConvert.DeserializeObject<List<LibrosDTO>>(jsonString);
                return lista;


            }
        }

        public async Task<string> RegistrarLibro(LibrosDTOIn libro)
        {
            using (var client = new HttpClient())
            {

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.PostAsJsonAsync($"{conexion.URLConnect}libros/registroLibro", libro);
                return response.Content.ReadAsStringAsync().Result;


            }
        }
    }
}
