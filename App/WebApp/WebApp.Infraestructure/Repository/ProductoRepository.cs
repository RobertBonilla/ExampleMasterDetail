using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Core.Domain;
using WebApp.Core.Interfaces;

namespace WebApp.Infraestructure.Repository
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly IConfiguration _configuration;
        public ProductoRepository(IConfiguration configuration)
        {
            _configuration = (configuration != null) ? configuration : throw new ArgumentNullException(nameof(configuration));
        }
        public IEnumerable<Producto> GetProductos()
        {
            throw new NotImplementedException();
        }
    }
}
