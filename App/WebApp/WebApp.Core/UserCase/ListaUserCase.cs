﻿using System;
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
        public IEnumerable<Lista> ObtenerLista()
        {
            return _repository.ObtenerLista();
        }
    }
}