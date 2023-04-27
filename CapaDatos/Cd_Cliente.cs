using CapaEntidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Cd_Cliente
    {
        public void InsertarCliente(Ce_Cliente InsertarCliente)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion.Conexion))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_INSERTARCLIENTE"))
                    {
                        cmd.Connection = conex;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Documento", InsertarCliente.Documento);
                        cmd.Parameters.AddWithValue("@Nombre", InsertarCliente.Nombre);
                        cmd.Parameters.AddWithValue("@Direccion", InsertarCliente.Direccion);
                        cmd.Parameters.AddWithValue("@Telefono", InsertarCliente.Telefono);
                        cmd.Parameters.AddWithValue("@Correo", InsertarCliente.Correo);
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

        public DataTable MostrarCliente(Ce_Cliente MostrarCliente)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion.Conexion))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_MOSTRARCLIENTES"))
                    {
                        cmd.Connection = conex;
                        DataTable dt = new DataTable();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Documento", MostrarCliente.Documento);
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

        public void ActualizarCliente(Ce_Cliente ActualizarCliente)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion.Conexion))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_ACTUALIZARCLIENTE"))
                    {
                        cmd.Connection = conex;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Documento", ActualizarCliente.Documento);
                        cmd.Parameters.AddWithValue("@Nombre", ActualizarCliente.Nombre);
                        cmd.Parameters.AddWithValue("@Direccion", ActualizarCliente.Direccion);
                        cmd.Parameters.AddWithValue("@Telefono", ActualizarCliente.Telefono);
                        cmd.Parameters.AddWithValue("@Correo", ActualizarCliente.Correo);
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

        public void EliminarCliente(Ce_Cliente EliminarCliente)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion.Conexion))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_ELIMINARCLIENTE"))
                    {
                        cmd.Connection = conex;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Documento", EliminarCliente.Documento);
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
