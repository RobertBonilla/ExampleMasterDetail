using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using WebApp.Core.Domain;
using WebApp.Core.Dto;
using WebApp.Core.Interfaces;

namespace WebApp.Infraestructure.Repository
{
    public class DetListaRepository : IDetListaRepository
    {
        private readonly IConfiguration _configuration;
        public DetListaRepository(IConfiguration configuration)
        {
            _configuration = (configuration != null) ? configuration : throw new ArgumentNullException(nameof(configuration));
        }
        public detLista eliminarDetLista(detLista model)
        {
            detLista newModel = null;
            try
            {
                using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    con.Open();
                    using (SqlTransaction sqlTran = con.BeginTransaction())
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "deleteDetLista";
                            cmd.Transaction = sqlTran;
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("detListaId", model.DetListaId);
                            int result = cmd.ExecuteNonQuery();
                            sqlTran.Commit();
                            newModel = model;
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.ToString());
            }
            return newModel;
        }

        public IEnumerable<detListaProducto> getListaProductos(Lista model)
        {
            List<detListaProducto> list = new List<detListaProducto>();
            try
            {
                using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    string query = @"SELECT det.detListaId,det.listaId,det.productoId,det.valorUnitario,det.cantidad,det.subTotal,
                                    pro.nombre,pro.descripcion,pro.valor
                                    FROM detLista det
                                    INNER JOIN Producto pro on det.productoId = pro.productoId";
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
                                    list.Add(new detListaProducto()
                                    {
                                        detLista = new detLista()
                                        {
                                            DetListaId = (sdr["detListaId"] != null) ? int.Parse(sdr["detListaId"].ToString()) : 0,
                                            ListaId = (sdr["listaId"] != null) ? int.Parse(sdr["listaId"].ToString()) : 0,
                                            ProductoId = (sdr["productoId"] != null) ? int.Parse(sdr["productoId"].ToString()) : 0,
                                            Cantidad = (sdr["cantidad"] != null) ? int.Parse(sdr["cantidad"].ToString()) : 0,
                                            ValorUnitario = (sdr["valorUnitario"] != null) ? decimal.Parse(sdr["valorUnitario"].ToString()) : 0
                                        },
                                        Producto = new Producto()
                                        {
                                            ProductoId = (sdr["productoId"] != null) ? int.Parse(sdr["productoId"].ToString()) : 0,
                                            Nombre = (sdr["nombre"] != null) ? sdr["nombre"].ToString() : "",
                                            Descripcion = (sdr["descripcion"] != null) ? sdr["descripcion"].ToString() : "",
                                            Valor = (sdr["valor"] != null) ? decimal.Parse(sdr["valor"].ToString()) : 0
                                        }                                        
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

        public detLista insertarDetLista(detLista model)
        {
            detLista newModel = null;
            try
            {
                using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    con.Open();
                    using (SqlTransaction sqlTran = con.BeginTransaction())
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "insertDetLista";
                            cmd.Transaction = sqlTran;
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("listaId", model.ListaId);
                            cmd.Parameters.AddWithValue("productoId", model.ProductoId);
                            cmd.Parameters.AddWithValue("valorUnitario", model.ValorUnitario);
                            cmd.Parameters.AddWithValue("cantidad", model.Cantidad);
                            cmd.Parameters.AddWithValue("subTotal", model.SubTotal);
                            int result = cmd.ExecuteNonQuery();
                            sqlTran.Commit();
                            newModel = model;
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.ToString());
            }
            return newModel;
        }

        public detLista modificarDetLista(detLista model)
        {
            detLista newModel = null;
            try
            {
                using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    con.Open();
                    using (SqlTransaction sqlTran = con.BeginTransaction())
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "updateDetLista";
                            cmd.Transaction = sqlTran;
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("detListaId", model.DetListaId);
                            cmd.Parameters.AddWithValue("valorUnitario", model.ValorUnitario);
                            cmd.Parameters.AddWithValue("cantidad", model.Cantidad);
                            cmd.Parameters.AddWithValue("subTotal", model.SubTotal);
                            int result = cmd.ExecuteNonQuery();
                            sqlTran.Commit();
                            newModel = model;
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.ToString());
            }
            return newModel;
        }
    }
}
