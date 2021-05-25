using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Core.Domain;
using WebApp.Core.Interfaces;

namespace WebApp.Core.UserCase
{
    public class ListaUserCase : IListaUserCase
    {
        private readonly IListaRepository _repository;

        public ListaUserCase(IListaRepository repository)
        {
            _repository = (repository != null) ? repository : throw new ArgumentException(nameof(repository));
        }

        public Lista GetLista(Lista model)
        {
            return _repository.GetLista(model);
        }

        public Lista InsertarLista(Lista model)
        {
            if(model!=null && model.Descripcion!=null)
            {
                return _repository.InsertarLista(model);
            }
            throw new ArgumentNullException("datos incompletos");
        }

        public Lista ModificarLista(Lista model)
        {
            if (model != null && model.ListaId>0 && model.Descripcion != null)
            {
                return _repository.InsertarLista(model);
            }
            throw new ArgumentNullException("datos incompletos");
        }

        public IEnumerable<Lista> ObtenerLista()
        {
            return _repository.ObtenerLista();
        }
    }
}
