using System;

namespace CapaEntidades
{
    public class Ce_Factura
    {
        public int idFactura { get; set; }
        public DateTime Fecha { get; set; }
        public int Documento_Cliente { get; set; }
        public int Codigo_Vendedor { get; set; }

        public Ce_Factura()
        {
            Fecha = DateTime.Now;
            Documento_Cliente = 0;
            Codigo_Vendedor = 0;
        }
    }
}