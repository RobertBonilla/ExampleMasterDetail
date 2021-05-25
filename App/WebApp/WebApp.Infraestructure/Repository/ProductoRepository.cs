using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using WebApp.Core.Domain;
using WebApp.Core.Interfaces;

namespace WebApp.Infraestructure.Repository
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly IConfiguration _configuration;
        public ProductoRepository(IConfiguration configuration)
        {
            _configuration = (configuration != null) ? configuration : throw new ArgumentNullException(nameof(configuration));
        }
        public IEnumerable<Producto> GetProductos()
        {
            List<Producto> list = new List<Producto>();
            try
            {
                using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    string query = "SELECT productoId,nombre,descripcion,valor FROM Producto";
                    con.Open();
                    using (SqlTransaction sqlTran = con.BeginTransaction())
                    {
                        using (SqlCommand cmd = new SqlCommand(query))
                        {
                            cmd.Transaction = sqlTran;
                            cmd.Connection = con;
                            using (SqlDataReader sdr = cmd.ExecuteReader())
                            {
                                while (sdr.Read())
                                {
                                    list.Add(new Producto()
                                    {
                                        ProductoId = (sdr["productoId"] != null) ? int.Parse(sdr["productoId"].ToString()) : 0,
                                        Nombre = sdr["nombre"].ToString(),
                                        Descripcion = sdr["descripcion"].ToString(),
                                        Valor = (sdr["valor"] != null) ? decimal.Parse(sdr["valor"].ToString()) : 0,
                                    });
                                }
                            }
                            sqlTran.Commit();
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.ToString());
            }
            return list;
        }
    }
}
