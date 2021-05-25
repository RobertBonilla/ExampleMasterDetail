using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Core.Domain;

namespace WebApp.Core.Interfaces
{
    public interface IListaUserCase
    {
        Lista GetLista(Lista model);
        IEnumerable<Lista> ObtenerLista();
        Lista ModificarLista(Lista model);
        Lista InsertarLista(Lista model);
    }
}
