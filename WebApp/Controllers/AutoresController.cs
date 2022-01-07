using EntidadDTO;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class AutoresController : Controller
    {
        // GET: Autores

        private readonly IAutores _autorNegocio = new Autores();   
        public async Task<ActionResult> Index()
        {

            List<AutoresDTO> listaAutores  = await _autorNegocio.ConsultarAutores();
            ViewBag.Autores = listaAutores;           
            return View();
        }

        public ActionResult Registro() { 
          
            return View();
        }

        [HttpPost]
        public async  Task<JsonResult> RegistrarAutor(AutoresDTO autor)
        {
       
            var resultado = await _autorNegocio.RegistrarAutor(autor);
            bool error = false;
            string msj = "";
;
            int validacion = Convert.ToInt32(resultado);

            if (validacion == 1)
                msj = "Se ha ingresado el autor";
            else
            {
                error = true;
                if (validacion == 0)
                    msj = "Error en el procedimiento";
                else if (validacion == 2)
                    msj = "El autor existe, por favor ingrese otro";
            }          
            

            return Json(new { error, msj });
        }
    }
}