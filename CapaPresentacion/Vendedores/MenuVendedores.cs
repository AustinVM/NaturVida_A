using CapaEntidades;
using CapaNegocios;
using CapaPresentacion.Global;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion._Inventario
{
    public partial class MenuVendedores : Form
    {
        Cn_Vendedor oCn_Vendedore = new Cn_Vendedor();
        Ce_Vendedor oCe_Vendedor = new Ce_Vendedor();
        DataTable dt = new DataTable();
        ErrorProvider noCoindicen = new ErrorProvider();
        ErrorProvider error = new ErrorProvider();

        public MenuVendedores()
        {
            InitializeComponent();
        }
        private void MenuVendedores_Load(object sender, System.EventArgs e)
        {
            cargarDgv();
            cargarCmb();
        }

        #region Btns_CRUD

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuarIngreVende.Text) || string.IsNullOrEmpty(txtContraseIngreVende.Text) || string.IsNullOrEmpty(txtConfimarContra.Text) || string.IsNullOrEmpty(txtNombIngreVende.Text))
            {
                MessageBox.Show("Hay campos vacios.");
            }
            else if (txtContraseIngreVende.Text != txtConfimarContra.Text)
            {
                noCoindicen.SetError(txtConfimarContra, "No coinciden las contraseñas.");
            }
            else
            {
                Ce_Vendedor InsertarVendedor = new Ce_Vendedor();
                InsertarVendedor.Codigo = Convert.ToInt32(txtCodIngreVende.Text);
                InsertarVendedor.Usuario = txtUsuarIngreVende.Text;
                InsertarVendedor.Contraseña = txtConfimarContra.Text;
                InsertarVendedor.NombreCompleto = txtUsuarIngreVende.Text;
                oCn_Vendedore.InsertarVendedor(InsertarVendedor);
            }
        }

        private void btnConsultarVende_Click(object sender, System.EventArgs e)
        {
            cargarUsuarioEspec();
        }

        private void btnMostrarVende_Click(object sender, System.EventArgs e)
        {
            cargarDgv();
        }

        private void btnActVende_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtActUsuarVende.Text) || string.IsNullOrEmpty(txtActContraVende.Text) || string.IsNullOrEmpty(txtConfirContraAct.Text) || string.IsNullOrEmpty(txtActUsuarVende.Text))
            {
                MessageBox.Show("Hay campos vacios.");
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea actualizar el vendedor?", "Question", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    if (txtActContraVende.Text != txtConfirContraAct.Text)
                    {
                        noCoindicen.SetError(txtConfirContraAct, "No coinciden las contraseñas.");
                    }
                    else
                    {
                        Ce_Vendedor ActualizarVendedor = new Ce_Vendedor();
                        ActualizarVendedor.Codigo = Convert.ToInt32(cmbActVende.SelectedValue);
                        ActualizarVendedor.Usuario = txtActUsuarVende.Text;
                        ActualizarVendedor.Contraseña = txtConfirContraAct.Text;
                        ActualizarVendedor.NombreCompleto = txtActNombVende.Text;
                        oCn_Vendedore.ActualizarVendedor(ActualizarVendedor);
                    }
                }
            }
        }

        private void btnConsultarVendeAct_Click(object sender, System.EventArgs e)
        {
            Ce_Vendedor ActualizarVendedor = new Ce_Vendedor();
            ActualizarVendedor.Codigo = Convert.ToInt32(cmbActVende.SelectedValue);
            dt = oCn_Vendedore.MostrarVendedor(ActualizarVendedor);
            llenarTxtAct();
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar el vendedor?", "Question", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Ce_Vendedor EliminarVendedor = new Ce_Vendedor();
                EliminarVendedor.Codigo = Convert.ToInt32(cmbEliminarVende.SelectedValue);
                oCn_Vendedore.EliminarVendedor(EliminarVendedor);
            }
        }

        #endregion

        #region MisMetodos

        private void cargarDgv()
        {
            dgvVendedores.DataSource = oCn_Vendedore.MostrarVendedor(oCe_Vendedor);
            dgvVendedores.Columns[2].Visible = false;
        }

        private void cargarCmb()
        {
            cmbVendedores.DataSource = oCn_Vendedore.MostrarVendedor(oCe_Vendedor);
            cmbVendedores.ValueMember = "Codigo";
            cmbVendedores.DisplayMember = "Usuario";

            cmbActVende.DataSource = oCn_Vendedore.MostrarVendedor(oCe_Vendedor);
            cmbActVende.ValueMember = "Codigo";
            cmbActVende.DisplayMember = "Usuario";

            cmbEliminarVende.DataSource = oCn_Vendedore.MostrarVendedor(oCe_Vendedor);
            cmbEliminarVende.ValueMember = "Codigo";
            cmbEliminarVende.DisplayMember = "Usuario";
        }

        private void llenarTxtAct()
        {
            txtActUsuarVende.Text = dt.Rows[0]["Usuario"].ToString();
            txtActNombVende.Text = dt.Rows[0]["Nombre"].ToString();
        }

        private void cargarUsuarioEspec()
        {
            Ce_Vendedor VendedorEspec = new Ce_Vendedor();
            VendedorEspec.Codigo = Convert.ToInt32(cmbVendedores.SelectedValue);
            dgvVendedores.DataSource = oCn_Vendedore.MostrarVendedor(VendedorEspec);
        }

        private void NoVacio(object NoVacio)
        {
            TextBox _NoVacio = (TextBox)NoVacio;
            bool vacio = false;
            if (string.IsNullOrEmpty(_NoVacio.Text))
            {
                vacio = true;
                error.SetError(_NoVacio, "No puede estar vacio.");
            }
            else
            {
                error.SetError(_NoVacio, "");
            }
        }

        #endregion

        #region VAlidacionesTxts

        private void txtCodIngreVende_TextChanged(object sender, EventArgs e)
        {
            if (Cp_MetodGlobal.validarCampos(txtCodIngreVende) == true)
            {
                error.SetError(txtCodIngreVende, "Solo numeros.");
            }
            else
            {
                error.SetError(txtCodIngreVende, "");
            }
        }

        private void txtUsuarIngreVende_TextChanged(object sender, EventArgs e)
        {
            NoVacio(sender);
        }

        private void txtContraseIngreVende_TextChanged(object sender, EventArgs e)
        {
            NoVacio(sender);
        }

        private void txtNombIngreVende_TextChanged(object sender, EventArgs e)
        {
            NoVacio(sender);
        }

        private void txtActUsuarVende_TextChanged(object sender, EventArgs e)
        {
            NoVacio(sender);
        }

        private void txtActContraVende_TextChanged(object sender, EventArgs e)
        {
            NoVacio(sender);
        }

        private void txtActNombVende_TextChanged(object sender, EventArgs e)
        {
            NoVacio(sender);
        }

        private void txtConfimarContra_TextChanged(object sender, EventArgs e)
        {
            NoVacio(sender);
        }

        #endregion

    }
}
