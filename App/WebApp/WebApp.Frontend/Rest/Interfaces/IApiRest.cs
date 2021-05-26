using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Frontend.Models.Domain;
using WebApp.Frontend.Models.Dto;
using WebApp.Frontend.Rest.Reponses;

namespace WebApp.Frontend.Rest.Interfaces
{
    public interface IApiRest
    {
        GenericListResponse<Lista> getLista();

        GenericResponse<Lista> getListaModel(int idLista);

        GenericResponse<ListaItems> getListaData(int ListaId);

        GenericResponse<Lista> modificarLista(Lista model);

        GenericResponse<detLista> eliminarDetail(detLista model);
    }
}
