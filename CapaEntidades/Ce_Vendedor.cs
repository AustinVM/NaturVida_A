namespace CapaEntidades
{
    public class Ce_Vendedor
    {
        public int Codigo { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string NombreCompleto { get; set; }

        public Ce_Vendedor()
        {
            Codigo = 0;
            Usuario = "";
            Contraseña = "";
            NombreCompleto = "";
        }
    }
}