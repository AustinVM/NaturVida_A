using CapaDatos;
using CapaEntidades;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace CapaNegocios
{
    public class Cn_Vendedor
    {
        Cd_Vendedor oCd_Vendedor = new Cd_Vendedor();

        public void InsertarVendedor(Ce_Vendedor InsertarVendedor)
        {
            InsertarVendedor.Contraseña = EncriptarContrasenia(InsertarVendedor);
            oCd_Vendedor.InsertarVendedor(InsertarVendedor);
        }

        public DataTable MostrarVendedor(Ce_Vendedor MostrarVendedor)
        {
            DataTable dt = oCd_Vendedor.MostrarVendedor(MostrarVendedor);

            if (dt == null)
            {
                return dt;
            }

            return dt;
        }

        public void ActualizarVendedor(Ce_Vendedor ActualizarVendedor)
        {
            ActualizarVendedor.Contraseña = EncriptarContrasenia(ActualizarVendedor);
            oCd_Vendedor.ActualizarVendedor(ActualizarVendedor);
        }

        public void EliminarVendedor(Ce_Vendedor EliminarVendedor)
        {
            oCd_Vendedor.EliminarVendedor(EliminarVendedor);
        }

        public int AutenticarVendedor(Ce_Vendedor AutenticarVendedor)
        {
            int AutenVende = 2;

            List<string> credencialees = oCd_Vendedor.AutenticarVendedor(AutenticarVendedor);
            AutenticarVendedor.Contraseña = EncriptarContrasenia(AutenticarVendedor);

            if (credencialees == null || credencialees.Count == 0)
            {
                AutenVende = 3; // Usuario no existe
            }
            else if (AutenticarVendedor.Usuario != credencialees[0] && AutenticarVendedor.Contraseña != credencialees[1])
            {
                AutenVende = 2; // Datos incorrectos
            }
            else if (AutenticarVendedor.Usuario == credencialees[0] && AutenticarVendedor.Contraseña == credencialees[1])
            {
                AutenVende = 1; // Usuario valido
            }
            return AutenVende;
        }

        private static string EncriptarContrasenia(Ce_Vendedor InsertarVendedor)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convertimos la contraseña en bytes
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(InsertarVendedor.Contraseña));

                // Convertimos los bytes en una cadena hexadecimal
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}