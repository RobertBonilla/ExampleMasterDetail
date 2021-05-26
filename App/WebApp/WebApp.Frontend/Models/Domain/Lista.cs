using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Frontend.Models.Domain
{
    public class Lista
    {
        public int ListaId { get; set; }
        public string FechaCreacion { get; set; }
        public string FechaUpdate { get; set; }
        public string Descripcion { get; set; }
    }
}
