using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Core.Domain;
using WebApp.Core.Interfaces;

namespace WebApp.Core.UserCase
{
    public class ProductoUserCase : IProductoUserCase
    {
        private readonly IProductoRepository _repository;

        public ProductoUserCase(IProductoRepository repository)
        {
            _repository = (repository != null) ? repository : throw new ArgumentException(nameof(repository));
        }
        public IEnumerable<Producto> GetProductos()
        {
            return _repository.GetProductos();
        }
    }
}
