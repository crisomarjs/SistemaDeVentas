using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVServices.Interfaces
{
    public interface ICorreoService
    {
        Task Enviar(string para, string asunto, string mensajeHtml);
    }
}
