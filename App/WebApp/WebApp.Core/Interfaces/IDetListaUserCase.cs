using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Core.Domain;
using WebApp.Core.Dto;

namespace WebApp.Core.Interfaces
{
    public interface IDetListaUserCase
    {
        detLista insertarDetLista(detLista model);
        detLista modificarDetLista(detLista model);
        detLista eliminarDetLista(detLista model);
        ListaItems getListaProductos(Lista model);
    }
}
