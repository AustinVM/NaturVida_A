namespace CapaEntidades
{
    public class Ce_Cliente
    {
        public int Documento { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public Ce_Cliente()
        {
            Documento = 0;
            Nombre = "";
            Direccion = "";
            Telefono = "";
            Correo = "";
        }
    }
}