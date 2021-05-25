using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Core.Domain;

namespace WebApp.Core.Dto
{
    public class detListaProducto
    {
        public detLista detLista { get; set; }
        public Producto Producto { get; set; }
    }
}
