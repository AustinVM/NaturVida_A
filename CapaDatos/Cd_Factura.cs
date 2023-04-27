using CapaEntidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Cd_Factura
    {
        public void InsertarFactura(Ce_Factura InsertarFactura)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion.Conexion))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_AGREGARFACTURA"))
                    {
                        cmd.Connection = conex;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Fecha", InsertarFactura.Fecha);
                        cmd.Parameters.AddWithValue("@Documento_Cliente", InsertarFactura.Documento_Cliente);
                        cmd.Parameters.AddWithValue("@Codigo_Vendedor", InsertarFactura.Codigo_Vendedor);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException Sqlex)
                {
                    Console.WriteLine("Ocurrio un error con la base de datos." + Sqlex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error." + ex.Message);
                }
            }
        }

        public DataTable MostrarFactura()
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion.Conexion))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("MostrarFactura"))
                    {
                        cmd.Connection = conex;
                        DataTable dt = new DataTable();
                        SqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dt.Load(dr);
                        return dt;
                    }
                }
                catch (SqlException Sqlex)
                {
                    Console.WriteLine("Ocurrio un error con la base de datos." + Sqlex.Message);
                    return null;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error." + ex.Message);
                    return null;
                }
            }
        }

        public void ActualizarFactura(Ce_Factura ActualizarFactura, Ce_FactutaDetalles ActualizarFactura_DtF)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion.Conexion))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("ActualizarFactura"))
                    {
                        cmd.Connection = conex;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Fech", ActualizarFactura.Fecha.ToShortDateString());
                        cmd.Parameters.AddWithValue("@DoClient", ActualizarFactura.Documento_Cliente);
                        cmd.Parameters.AddWithValue("@CodVende", ActualizarFactura.Codigo_Vendedor);
                        cmd.Parameters.AddWithValue("@CodProd", ActualizarFactura_DtF.Codigo_Productos);
                        cmd.Parameters.AddWithValue("@Cant", ActualizarFactura_DtF.Cantidad);
                        cmd.Parameters.AddWithValue("@ValUnidad", ActualizarFactura_DtF.Valor_Unidad);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException Sqlex)
                {
                    Console.WriteLine("Ocurrio un error con la base de datos." + Sqlex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error." + ex.Message);
                }
            }
        }

        public void EliminarFactura(Ce_Factura EliminarFactura)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion.Conexion))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("ActualizarFactura"))
                    {
                        cmd.Connection = conex;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idFactura", EliminarFactura.idFactura);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException Sqlex)
                {
                    Console.WriteLine("Ocurrio un error con la base de datos." + Sqlex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error." + ex.Message);
                }
            }
        }
    }
}