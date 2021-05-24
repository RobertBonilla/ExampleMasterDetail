using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Core.Domain;
using WebApp.Core.Interfaces;

namespace WebApp.Infraestructure.Repository
{
    public class ListaRepository : IListaRepository
    {
        public IEnumerable<Lista> ObtenerLista()
        {
            List<Lista> list = new List<Lista>();
            list.Add(new Lista()
            {
                ListaId = 0,
                Descripcion = "Prueba"
            });
            return list;
        }
    }
}
