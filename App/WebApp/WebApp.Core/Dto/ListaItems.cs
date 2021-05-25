using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Core.Domain;

namespace WebApp.Core.Dto
{
    public class ListaItems
    {
        public Lista Lista { get; set; }
        public IEnumerable<detListaProducto> Items { get; set; }
    }
}
