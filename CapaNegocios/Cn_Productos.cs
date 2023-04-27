using CapaDatos;
using CapaEntidades;
using System.Data;

namespace CapaNegocios
{
    public class Cn_Productos
    {
        Cd_Productos oCd_Productos = new Cd_Productos();

        public void InsertarProducto(Ce_Productos InsertarProducto)
        {
            oCd_Productos.InsertarProducto(InsertarProducto);
        }

        public DataTable MostrarProducto(Ce_Productos MostrarProductos)
        {
            DataTable dt = oCd_Productos.MostrarProducto(MostrarProductos);

            if (dt == null)
            {
                return dt;
            }

            return dt;
        }

        public void ActualizarProducto(Ce_Productos ActualizarProducto)
        {
            oCd_Productos.ActualizarProducto(ActualizarProducto);
        }

        public void EliminarProducto(Ce_Productos EliminarProducto)
        {
            oCd_Productos.EliminarProducto(EliminarProducto);
        }
    }
}