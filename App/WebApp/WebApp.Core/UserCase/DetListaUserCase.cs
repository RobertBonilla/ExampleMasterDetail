using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Core.Domain;
using WebApp.Core.Dto;
using WebApp.Core.Interfaces;

namespace WebApp.Core.UserCase
{
    public class DetListaUserCase : IDetListaUserCase
    {
        private readonly IDetListaRepository _repository;

        public DetListaUserCase(IDetListaRepository repository)
        {
            _repository = (repository != null) ? repository : throw new ArgumentException(nameof(repository));
        }
        public detLista eliminarDetLista(detLista model)
        {
            return _repository.eliminarDetLista(model);
        }

        public ListaItems getListaProductos(Lista model)
        {
            ListaItems listaItems = new ListaItems();
            listaItems.Items = _repository.getListaProductos(model);
            return listaItems;
        }

        public detLista insertarDetLista(detLista model)
        {
            return _repository.insertarDetLista(model);
        }

        public detLista modificarDetLista(detLista model)
        {
            return modificarDetLista(model);
        }
    }
}
