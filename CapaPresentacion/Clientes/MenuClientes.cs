using CapaEntidades;
using CapaNegocios;
using CapaPresentacion.Global;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion.Clientes
{
    public partial class MenuClientes : Form
    {
        Cn_Clientes oCn_Clientes = new Cn_Clientes();
        Ce_Cliente oCe_Clientes = new Ce_Cliente();
        DataTable dt = new DataTable();
        ErrorProvider error = new ErrorProvider();

        public MenuClientes()
        {
            InitializeComponent();
        }
        private void MenuClientes_Load(object sender, System.EventArgs e)
        {
            cargarDgv();
            cargarCmb();
        }

        private void btnLimpiarIng_Click(object sender, EventArgs e)
        {
            limpiarTxt();
        }

        private void btnLimpiarActClien_Click(object sender, EventArgs e)
        {
            limpiarTxt();
        }

        #region MisMetodos

        private void cargarDgv()
        {
            dgvClientes.DataSource = oCn_Clientes.MostrarCliente(oCe_Clientes);
        }

        private void cargarCmb()
        {
            cmbClientes.DataSource = oCn_Clientes.MostrarCliente(oCe_Clientes);
            cmbClientes.ValueMember = "Documento";
            cmbClientes.DisplayMember = "Nombre";

            cmbActClien.DataSource = oCn_Clientes.MostrarCliente(oCe_Clientes);
            cmbActClien.ValueMember = "Documento";
            cmbActClien.DisplayMember = "Nombre";

            cmbEliminarClien.DataSource = oCn_Clientes.MostrarCliente(oCe_Clientes);
            cmbEliminarClien.ValueMember = "Documento";
            cmbEliminarClien.DisplayMember = "Nombre";
        }

        private void cargarClienteEspec()
        {
            Ce_Cliente MostrarClienteEspec = new Ce_Cliente();
            MostrarClienteEspec.Documento = Convert.ToInt32(cmbClientes.SelectedValue);
            dgvClientes.DataSource = oCn_Clientes.MostrarCliente(MostrarClienteEspec);
        }

        private void llenarTxtAct()
        {
            txtActNombClien.Text = dt.Rows[0]["Nombre"].ToString();
            txtActDirecClien.Text = dt.Rows[0]["Direccion"].ToString();
            txtActTelClien.Text = dt.Rows[0]["Telefono"].ToString();
            txtActCorrClien.Text = dt.Rows[0]["Correo"].ToString();
        }

        private void limpiarTxt()
        {
            txtDocIngreClien.Clear();
            txtNombIngreClien.Clear();
            txtDirecIngreClien.Clear();
            txtTelIngreClien.Clear();
            txtCorrIngreClien.Clear();
            txtActNombClien.Clear();
            txtActDirecClien.Clear();
            txtActTelClien.Clear();
            txtActCorrClien.Clear();
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

        #region Btns_CRUD

        private void btnConsultarClien_Click(object sender, EventArgs e)
        {
            cargarClienteEspec();
        }

        private void btnMostrarClien_Click(object sender, EventArgs e)
        {
            cargarDgv();
        }

        private void btnConsultarClienAct_Click(object sender, EventArgs e)
        {
            limpiarTxt();
            Ce_Cliente ConsultarClienAct = new Ce_Cliente();
            ConsultarClienAct.Documento = Convert.ToInt32(cmbActClien.SelectedValue);
            dt = oCn_Clientes.MostrarCliente(ConsultarClienAct);
            llenarTxtAct();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDocIngreClien.Text) || string.IsNullOrEmpty(txtNombIngreClien.Text))
            {
                MessageBox.Show("Hay campos vacios.");
            }
            else
            {
                Ce_Cliente InsertarCliente = new Ce_Cliente();
                InsertarCliente.Documento = Convert.ToInt32(txtDocIngreClien.Text);
                InsertarCliente.Nombre = txtNombIngreClien.Text;
                InsertarCliente.Direccion = txtDirecIngreClien.Text;
                InsertarCliente.Telefono = txtTelIngreClien.Text;
                InsertarCliente.Correo = txtCorrIngreClien.Text;
                oCn_Clientes.InsertarCliente(InsertarCliente);
                cargarDgv();
                cargarCmb();
            }
        }

        private void btnEliminarClien_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar el cliente?", "Question", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Ce_Cliente EliminarCliente = new Ce_Cliente();
                EliminarCliente.Documento = Convert.ToInt32(cmbEliminarClien.SelectedValue);
                oCn_Clientes.EliminarCliente(EliminarCliente);
                cargarDgv();
                cargarCmb();
            }
        }

        private void btnActClien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombIngreClien.Text))
            {
                MessageBox.Show("Hay campos vacios.");
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea actualizar el cliente?", "Question", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Ce_Cliente ActualizarCliente = new Ce_Cliente();
                    ActualizarCliente.Documento = Convert.ToInt32(cmbActClien.SelectedValue);
                    ActualizarCliente.Nombre = txtActNombClien.Text;
                    ActualizarCliente.Direccion = txtActDirecClien.Text;
                    ActualizarCliente.Telefono = txtActTelClien.Text;
                    ActualizarCliente.Correo = txtActCorrClien.Text;
                    oCn_Clientes.ActualizarCliente(ActualizarCliente);
                    cargarDgv();
                    cargarCmb();
                }
            }
        }

        #endregion

        #region ValidacionesTxts

        private void txtDocIngreClien_TextChanged(object sender, EventArgs e)
        {
            if (Cp_MetodGlobal.validarCampos(txtDocIngreClien) == true)
            {
                error.SetError(txtDocIngreClien, "Solo numeros.");
            }
            else
            {
                error.SetError(txtDocIngreClien, "");
            }
        }

        private void txtNombIngreClien_TextChanged(object sender, EventArgs e)
        {
            NoVacio(sender);
        }

        private void txtDirecIngreClien_TextChanged(object sender, EventArgs e)
        {
            NoVacio(sender);
        }

        private void txtTelIngreClien_TextChanged(object sender, EventArgs e)
        {
            if (Cp_MetodGlobal.validarCampos(txtCorrIngreClien) == true)
            {
                error.SetError(txtCorrIngreClien, "Solo numeros.");
            }
            else
            {
                error.SetError(txtCorrIngreClien, "");
            }
        }

        private void txtCorrIngreClien_TextChanged(object sender, EventArgs e)
        {
            if (Cp_MetodGlobal.ValidarCorreoElectronico(txtCorrIngreClien.Text) == false)
            {
                error.SetError(txtCorrIngreClien, "Correo invalido.");
            }
            else
            {
                error.SetError(txtCorrIngreClien, "");
            }
        }

        private void txtActNombClien_TextChanged(object sender, EventArgs e)
        {
            NoVacio(sender);
        }

        private void txtActDirecClien_TextChanged(object sender, EventArgs e)
        {
            NoVacio(sender);
        }

        private void txtActTelClien_TextChanged(object sender, EventArgs e)
        {
            NoVacio(sender);
        }

        private void txtActCorrClien_TextChanged(object sender, EventArgs e)
        {
            if (Cp_MetodGlobal.ValidarCorreoElectronico(txtActCorrClien.Text) == false)
            {
                error.SetError(txtActCorrClien, "Correo invalido.");
            }
            else
            {
                error.SetError(txtActCorrClien, "");
            }
        }

        #endregion
    }
}
