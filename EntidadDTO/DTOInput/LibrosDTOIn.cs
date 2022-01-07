using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadDTO.DTOInput
{
    public class LibrosDTOIn
    {
        public string Titulo { get; set; }
        public int Anio { get; set; }
        public string Genero { get; set; }
        public int Paginas { get; set; }
        public int AutorId { get; set; }
    }
}
