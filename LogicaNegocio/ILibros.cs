using EntidadDTO;
using EntidadDTO.DTOInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public interface ILibros
    {
        Task<List<LibrosDTO>> ConsultarLibros();
        Task<string> RegistrarLibro(LibrosDTOIn libro);
        Task<List<LibrosDTO>> ConsultarLibrospalabraClave(LibrosPalabraClaveDTOIn palabraClave);
    }
}
