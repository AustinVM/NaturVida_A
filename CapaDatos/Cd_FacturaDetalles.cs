using CapaEntidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Cd_FacturaDetalles
    {
        public void InsertarFacturaDetalles(Ce_FactutaDetalles InsertarFacturaDetalles)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion.Conexion))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_AGGFACTDETA"))
                    {
                        cmd.Connection = conex;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Codigo_Productos", InsertarFacturaDetalles.Codigo_Productos);
                        cmd.Parameters.AddWithValue("@Cantidad", InsertarFacturaDetalles.Cantidad);
                        cmd.Parameters.AddWithValue("@Valor_Unidad", InsertarFacturaDetalles.Valor_Unidad);
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
        public DataTable MostrarFacturaDetalles(Ce_FactutaDetalles MostrarFacturaDetalles)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion.Conexion))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand())
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
        public void ActualizarFacturaDetalles(Ce_FactutaDetalles ActualizarFacturaDetalles)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion.Conexion))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conex;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Numero_Factura", ActualizarFacturaDetalles.Numero_Factura);
                        cmd.Parameters.AddWithValue("@Codigo_Productos", ActualizarFacturaDetalles.Codigo_Productos);
                        cmd.Parameters.AddWithValue("@Cantidad", ActualizarFacturaDetalles.Cantidad);
                        cmd.Parameters.AddWithValue("@Valor_Unidad", ActualizarFacturaDetalles.Valor_Unidad);
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
        public void EliminarFacturaDetalles(Ce_FactutaDetalles EliminarFacturaDetalles)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion.Conexion))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("EliminarFacturaDetalles"))
                    {
                        cmd.Connection = conex;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Numero_Factura", EliminarFacturaDetalles.Numero_Factura);
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