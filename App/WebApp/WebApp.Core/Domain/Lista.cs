using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Core.Domain
{
    public class Lista
    {
        public int ListaId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaUpdate { get; set; }
        public string Descripcion { get; set; }
    }
}
