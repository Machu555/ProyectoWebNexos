using EntidadDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public interface IAutores
    {
        Task<List<AutoresDTO>> ConsultarAutores();
        Task<string> RegistrarAutor(AutoresDTO autor);
    }
}
