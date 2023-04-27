using CapaEntidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Cd_Productos
    {
        public void InsertarProducto(Ce_Productos InsertarProducto)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion.Conexion))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_INSERTARPRODUCTO"))
                    {
                        cmd.Connection = conex;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Codigo", InsertarProducto.Codigo);
                        cmd.Parameters.AddWithValue("@Descripcion", InsertarProducto.Descripción);
                        cmd.Parameters.AddWithValue("@Valor_Unidad", InsertarProducto.Valor_Unidad);
                        cmd.Parameters.AddWithValue("@Cantidad", InsertarProducto.Cantidad);
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

        public DataTable MostrarProducto(Ce_Productos MostrarProductos)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion.Conexion))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_MOSTRARPRODUCTO"))
                    {
                        DataTable dt = new DataTable();
                        cmd.Connection = conex;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Codigo", MostrarProductos.Codigo);
                        SqlDataReader dr = cmd.ExecuteReader();
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

        public void ActualizarProducto(Ce_Productos ActualizarProducto)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion.Conexion))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_ACTUALIZARPRODUCTO"))
                    {
                        cmd.Connection = conex;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Codigo", ActualizarProducto.Codigo);
                        cmd.Parameters.AddWithValue("@Descripcion", ActualizarProducto.Descripción);
                        cmd.Parameters.AddWithValue("@Valor_Unidad", ActualizarProducto.Valor_Unidad);
                        cmd.Parameters.AddWithValue("@Cantidad", ActualizarProducto.Cantidad);
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

        public void EliminarProducto(Ce_Productos EliminarProducto)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion.Conexion))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_ELIMINARPRODUCTO"))
                    {
                        cmd.Connection = conex;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Codigo", EliminarProducto.Codigo);
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