using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using WebApp.Core.Domain;
using WebApp.Core.Interfaces;

namespace WebApp.Infraestructure.Repository
{
    public class ListaRepository : IListaRepository
    {
        private readonly IConfiguration _configuration;
        private string _conecctioString;
        public ListaRepository(IConfiguration configuration)
        {
            _configuration = (configuration != null) ? configuration : throw new ArgumentNullException(nameof(configuration));
        }
        public IEnumerable<Lista> ObtenerLista()
        {
            List<Lista> list = new List<Lista>();
            using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = "SELECT listaId,fechaCreacion,fechaUpdate,descripcion FROM Lista";
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            list.Add(new Lista()
                            {
                                ListaId = (sdr["listaId"] !=null )? int.Parse(sdr["listaId"].ToString()) : 0,
                                FechaCreacion = (sdr["fechaCreacion"] != null) ? DateTime.Parse(sdr["fechaCreacion"].ToString()):DateTime.MinValue,
                                FechaUpdate = (sdr["fechaUpdate"] != null) ? DateTime.Parse(sdr["fechaUpdate"].ToString()) : DateTime.MinValue,
                                Descripcion = sdr["descripcion"].ToString()
                            });
                        }
                    }
                    con.Close();
                }
            }
            return list;
        }
    }
}
