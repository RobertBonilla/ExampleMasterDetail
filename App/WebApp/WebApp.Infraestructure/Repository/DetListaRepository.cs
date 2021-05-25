using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Core.Domain;
using WebApp.Core.Dto;
using WebApp.Core.Interfaces;

namespace WebApp.Infraestructure.Repository
{
    public class DetListaRepository : IDetListaRepository
    {
        private readonly IConfiguration _configuration;
        public DetListaRepository(IConfiguration configuration)
        {
            _configuration = (configuration != null) ? configuration : throw new ArgumentNullException(nameof(configuration));
        }
        public detLista eliminarDetLista(detLista model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<detListaProducto> getListaProductos(Lista model)
        {
            throw new NotImplementedException();
        }

        public detLista insertarDetLista(detLista model)
        {
            throw new NotImplementedException();
        }

        public detLista modificarDetLista(detLista model)
        {
            throw new NotImplementedException();
        }
    }
}
