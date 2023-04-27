namespace CapaEntidades
{
    public class Ce_FactutaDetalles : Ce_Factura
    {
        public int idFactutaDetalles { get; set; }
        public int Numero_Factura { get; set; }
        public int Codigo_Productos { get; set; }
        public int Cantidad { get; set; }
        public int Valor_Unidad { get; set; }

        public Ce_FactutaDetalles()
        {
            idFactutaDetalles = 0;
            Numero_Factura = 0;
            Codigo_Productos = 0;
            Cantidad = 0;
            Valor_Unidad = 0;
        }
    }
}