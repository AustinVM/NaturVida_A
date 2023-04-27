namespace CapaEntidades
{
    public class Ce_Productos
    {
        public int Codigo { get; set; }
        public string Descripción { get; set; }
        public int Valor_Unidad { get; set; }
        public int Cantidad { get; set; }

        public Ce_Productos()
        {
            Codigo = 0;
            Descripción = "";
            Valor_Unidad = 0;
            Cantidad = 0;
        }
    }
}
