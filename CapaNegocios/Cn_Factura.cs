using CapaDatos;
using CapaEntidades;
using System.Data;

namespace CapaNegocios
{
    public class Cn_Factura
    {
        Cd_Factura oCd_Factura = new Cd_Factura();

        public void InsertarFactura(Ce_Factura InsertarFactura)
        {
            oCd_Factura.InsertarFactura(InsertarFactura);
        }

        public DataTable MostrarFactura()
        {
            DataTable dt = oCd_Factura.MostrarFactura();

            if (dt == null)
            {
                return dt;
            }

            return dt;
        }

        public void ActualizarFactura(Ce_Factura ActualizarFactura, Ce_FactutaDetalles ActualizarFactura_DtF)
        {
            oCd_Factura.ActualizarFactura(ActualizarFactura, ActualizarFactura_DtF);
        }

        public void EliminarFactura(Ce_Factura EliminarFactura)
        {
            oCd_Factura.EliminarFactura(EliminarFactura);
        }
    }
}