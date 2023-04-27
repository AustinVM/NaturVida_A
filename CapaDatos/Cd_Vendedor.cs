using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Cd_Vendedor
    {
        public void InsertarVendedor(Ce_Vendedor InsertarVendedor)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion.Conexion))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_INSERTARVENDEDOR"))
                    {
                        cmd.Connection = conex;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Codigo", InsertarVendedor.Codigo);
                        cmd.Parameters.AddWithValue("@Usuario", InsertarVendedor.Usuario);
                        cmd.Parameters.AddWithValue("@Contraseña", InsertarVendedor.Contraseña);
                        cmd.Parameters.AddWithValue("@NombreCompleto", InsertarVendedor.NombreCompleto);
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

        public DataTable MostrarVendedor(Ce_Vendedor MostrarVendedor)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion.Conexion))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_MOSTRARVENDEDOR"))
                    {
                        cmd.Connection = conex;
                        cmd.CommandType = CommandType.StoredProcedure;
                        DataTable dt = new DataTable();
                        cmd.Parameters.AddWithValue("@Codigo", MostrarVendedor.Codigo);
                        cmd.Parameters.AddWithValue("@Usuario", MostrarVendedor.Usuario);
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

        public void ActualizarVendedor(Ce_Vendedor ActualizarVendedor)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion.Conexion))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_ACTUALIZARVENDEDOR"))
                    {
                        cmd.Connection = conex;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Codigo", ActualizarVendedor.Codigo);
                        cmd.Parameters.AddWithValue("@Usuario", ActualizarVendedor.Usuario);
                        cmd.Parameters.AddWithValue("@Contraseña", ActualizarVendedor.Contraseña);
                        cmd.Parameters.AddWithValue("@NombreCompleto", ActualizarVendedor.NombreCompleto);
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

        public void EliminarVendedor(Ce_Vendedor EliminarVendedor)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion.Conexion))
            {
                try
                {
                    conex.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_ELIMINARVENDEDOR"))
                    {
                        cmd.Connection = conex;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Codigo", EliminarVendedor.Codigo);
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

        public List<string> AutenticarVendedor(Ce_Vendedor AutenticarVendedor)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion.Conexion))
            {
                try
                {
                    conex.Open();
                    List<string> credenciales = new List<string>();
                    using (SqlCommand cmd = new SqlCommand("SP_AUTENTICARVENDEDOR"))
                    {
                        cmd.Connection = conex;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Usuario", AutenticarVendedor.Usuario);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            credenciales.Add(dr["Usuario"].ToString());
                            credenciales.Add(dr["Contraseña"].ToString());
                        }
                        return credenciales;
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
    }
}