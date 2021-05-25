using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Core.Domain
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string descripcion { get; set; }
        public decimal valor { get; set; }
    }
}
