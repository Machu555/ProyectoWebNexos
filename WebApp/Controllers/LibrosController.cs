using EntidadDTO;
using EntidadDTO.DTOInput;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class LibrosController : Controller
    {
        private readonly ILibros _libroNegocio = new Libros();
        // GET: Libros
        public async Task<ActionResult> Index()
        {
           
         
            var  listaLibros = await _libroNegocio.ConsultarLibros();
            ViewBag.Libros = listaLibros;

            
            return View();
        }

        public ActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> RegistrarLibro(LibrosDTOIn libro)
        {
            var resultado = await _libroNegocio.RegistrarLibro(libro);
            bool error = false;
            string msj = "";

            int validacion = Convert.ToInt32(resultado);

            if (validacion == 1)
                msj = "Se ha ingresado el libro";
            else
            {
                error = true;
                if (validacion == 0)
                    msj = "Error en el procedimiento";
                else if (validacion == 2)
                    msj = "El autor no existe, por favor registrarlo.";
                else if (validacion == 3)
                    msj = "Ha superado el limite de libros por autor.";
            }


            return Json(new { error, msj });
        }
        [HttpPost]
        public async Task<JsonResult> ListarPalabraClave(LibrosPalabraClaveDTOIn palabraClave)
        {
            List<LibrosDTO> listaLibros = new List<LibrosDTO>();
            if (palabraClave.Caso > 0)
            {
                listaLibros = await _libroNegocio.ConsultarLibrospalabraClave(palabraClave);               
            }
            else
            {
                listaLibros = await _libroNegocio.ConsultarLibros();   
            }
            return Json(new { listaLibros });
        }


    }
}