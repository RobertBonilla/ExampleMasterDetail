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
        private readonly IListaRepository _repositoryList;

        public DetListaUserCase(IDetListaRepository repository, IListaRepository repositoryList)
        {
            _repository = (repository != null) ? repository : throw new ArgumentException(nameof(repository));
            _repositoryList = (repositoryList != null) ? repositoryList : throw new ArgumentException(nameof(repositoryList));
        }
        public detLista eliminarDetLista(detLista model)
        {
            if (model != null && model.DetListaId > 0)
            {
                return _repository.eliminarDetLista(model);
            }
            throw new ArgumentNullException("datos incompletos");
        }

        public ListaItems getListaProductos(Lista model)
        {
            ListaItems listaItems = new ListaItems();
            listaItems.Lista = _repositoryList.GetLista(model);
            listaItems.Items = _repository.getListaProductos(model);
            return listaItems;
        }

        public detLista insertarDetLista(detLista model)
        {
            if (model!=null && model.ListaId>0 && model.ProductoId >0)
            {
                model.SubTotal = model.ValorUnitario * decimal.Parse(model.Cantidad.ToString());
                return _repository.insertarDetLista(model);
            }
            throw new ArgumentNullException("datos incompletos");
        }

        public detLista modificarDetLista(detLista model)
        {
            if (model != null && model.DetListaId > 0)
            {
                model.SubTotal = model.ValorUnitario * decimal.Parse(model.Cantidad.ToString());
                return _repository.modificarDetLista(model);
            }
            throw new ArgumentNullException("datos incompletos");
        }
    }
}
