using CapaPresentacion._Inventario;
using CapaPresentacion.Clientes;
using CapaPresentacion.Facturas;
using CapaPresentacion.Global;
using CapaPresentacion.Inventario;
using CapaPresentacion.Productos;
using System;
using System.Windows.Forms;

namespace CapaPresentacion.Principal
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            MostrarPanel(new MenuProductos());
            lblUsuarVende.Text = Cp_VarGlobal.UsuarioVendedor;
        }

        private void MostrarPanel(Form _hijo)
        {
            this.pnlCruds.Controls.Clear();
            Form hijo = _hijo;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.pnlCruds.Controls.Add(hijo);
            hijo.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarPanel(new MenuProductos());
            lblGestion.Text = "GESTIÓN DE PRODUCTOS";
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarPanel(new MenuClientes());
            lblGestion.Text = "GESTIÓN DE CLIENTES";
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarPanel(new MenuVendedores());
            lblGestion.Text = "GESTIÓN DE VENDEDORES";
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarPanel(new AggFactura());
            lblGestion.Text = "FACTURACIÓN";
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarPanel(new Frm_Inventario());
            lblGestion.Text = "INVENTARIO";
        }
    }
}
