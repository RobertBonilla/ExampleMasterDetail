using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Frontend.Models.Domain;

namespace WebApp.Frontend.Models.Dto
{
    public class detListaProducto
    {
        public detLista detLista { get; set; }
        public Producto Producto { get; set; }
    }
}
