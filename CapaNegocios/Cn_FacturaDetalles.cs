using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class Cn_FacturaDetalles
    {
        Cd_FacturaDetalles oCd_FacturaDetalles = new Cd_FacturaDetalles();

        public void InsertarFacturaDetalles(Ce_FactutaDetalles InsertarFacturaDetalles)
        {
            oCd_FacturaDetalles.InsertarFacturaDetalles(InsertarFacturaDetalles);
        }
    }
}
