using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Frontend.Models.Domain;

namespace WebApp.Frontend.Models.Dto
{
    public class ListaItems
    {
        public Lista Lista { get; set; }
        public IEnumerable<detListaProducto> Items { get; set; }
    }
}
