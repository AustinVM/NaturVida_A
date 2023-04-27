using CapaEntidades;
using CapaNegocios;
using System;
using System.Windows.Forms;

namespace CapaPresentacion.Inventario
{
    public partial class Frm_Inventario : Form
    {
        Cn_Inventario oCn_Inventario = new Cn_Inventario();
        Cn_Productos oCn_Productos = new Cn_Productos();

        public Frm_Inventario()
        {
            InitializeComponent();
        }

        private void cargarDgv()
        {
            dgvInventario.DataSource = oCn_Inventario.MostrarInventario();
        }

        private void cargarProdEspec()
        {
            dgvInventario.DataSource = oCn_Inventario.MostrarInventarioProducto(Convert.ToInt32(cmbInventario.SelectedValue));
        }

        private void cargarCmbs()
        {
            Ce_Productos MostrarProductoCmb = new Ce_Productos();
            cmbInventario.DataSource = oCn_Productos.MostrarProducto(MostrarProductoCmb);
            cmbInventario.ValueMember = "Codigo";
            cmbInventario.DisplayMember = "Descripción";
        }

        private void btnMostrarProductos_Click(object sender, System.EventArgs e)
        {
            cargarDgv();
        }

        private void btnConsultarProductos_Click(object sender, System.EventArgs e)
        {
            cargarProdEspec();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            cargarDgv();
            cargarCmbs();
        }
    }
}
