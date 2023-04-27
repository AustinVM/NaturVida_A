using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class Cn_Inventario
    {
        Cd_Inventario oCd_Inventario = new Cd_Inventario();

        public DataTable MostrarInventario()
        {
            DataTable dt = oCd_Inventario.MostrarInventario();

            if (dt == null)
            {
                return dt;
            }

            return dt;
        }

        public DataTable MostrarInventarioProducto(int CodigoProd)
        {
            DataTable dt = oCd_Inventario.MostrarInventarioProducto(CodigoProd);

            if (dt == null)
            {
                return dt;
            }

            return dt;
        }
    }
}
