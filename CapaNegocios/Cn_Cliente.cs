using CapaDatos;
using CapaEntidades;
using System.Data;

namespace CapaNegocios
{
    public class Cn_Clientes
    {
        Cd_Cliente oCd_Cliente = new Cd_Cliente();

        public void InsertarCliente(Ce_Cliente InsertarCliente)
        {
            oCd_Cliente.InsertarCliente(InsertarCliente);
        }

        public DataTable MostrarCliente(Ce_Cliente MostrarCliente)
        {
            DataTable dt = oCd_Cliente.MostrarCliente(MostrarCliente);

            if (dt == null)
            {
                return dt;
            }

            return dt;
        }

        public void ActualizarCliente(Ce_Cliente ActualizarCliente)
        {
            oCd_Cliente.ActualizarCliente(ActualizarCliente);
        }

        public void EliminarCliente(Ce_Cliente EliminarCliente)
        {
            oCd_Cliente.EliminarCliente(EliminarCliente);
        }
    }
}
