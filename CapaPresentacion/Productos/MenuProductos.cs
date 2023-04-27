using CapaEntidades;
using CapaNegocios;
using CapaPresentacion.Global;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion.Productos
{
    public partial class MenuProductos : Form
    {
        private Cn_Productos oCn_Productos = new Cn_Productos();
        private DataTable dt = new DataTable();
        ErrorProvider error = new ErrorProvider();

        public MenuProductos()
        {
            InitializeComponent();
        }
        private void MenuProductos_Load(object sender, EventArgs e)
        {
            cargarDgv();
            cargarCmbs();
        }

        #region MisMetodos

        private void cargarDgv()
        {
            Ce_Productos MostrarProducto = new Ce_Productos();
            dgvProductos.DataSource = oCn_Productos.MostrarProducto(MostrarProducto);
        }

        private void cargarCmbs()
        {
            Ce_Productos MostrarProductoCmb = new Ce_Productos();
            cmbProductos.DataSource = oCn_Productos.MostrarProducto(MostrarProductoCmb);
            cmbProductos.ValueMember = "Codigo";
            cmbProductos.DisplayMember = "Descripción";

            Ce_Productos MostrarProductoCmbAct = new Ce_Productos();
            cmbActProd.DataSource = oCn_Productos.MostrarProducto(MostrarProductoCmbAct);
            cmbActProd.ValueMember = "Codigo";
            cmbActProd.DisplayMember = "Descripción";

            Ce_Productos MostrarProductoCmbElim = new Ce_Productos();
            cmbEliminarProd.DataSource = oCn_Productos.MostrarProducto(MostrarProductoCmbElim);
            cmbEliminarProd.ValueMember = "Codigo";
            cmbEliminarProd.DisplayMember = "Descripción";
        }

        private void cargarProdEspec()
        {
            Ce_Productos MostrarProductoEspec = new Ce_Productos();
            MostrarProductoEspec.Codigo = Convert.ToInt32(cmbProductos.SelectedValue);
            dgvProductos.DataSource = oCn_Productos.MostrarProducto(MostrarProductoEspec);
        }

        private void llenarTxtAct()
        {
            txtDescActProd.Text = dt.Rows[0]["Descripción"].ToString();
            txtValUniActProd.Text = dt.Rows[0]["Valor_Unidad"].ToString();
            txtCantActProd.Text = dt.Rows[0]["Cantidad"].ToString();
        }

        private void LimpiarTxts()
        {
            txtCodIngreProd.Clear();
            txtDescIngreProd.Clear();
            txtValUniIngreProd.Clear();
            txtCantIngreProd.Clear();
            txtDescActProd.Clear();
            txtValUniActProd.Clear();
            txtCantActProd.Clear();
        }

        private bool ProdYaExiste()
        {
            bool existe = false;
            Ce_Productos ProdYaExiste = new Ce_Productos();
            ProdYaExiste.Codigo = Convert.ToInt32(txtCodIngreProd.Text);
            dt = oCn_Productos.MostrarProducto(ProdYaExiste);
            if (dt.Rows.Count == 0)
            {
                existe = false;
            }
            else
            {
                existe = true;
            }
            return existe;
        }

        #endregion

        #region Btns_CRUD

        private void btnConsultarProd_Click(object sender, EventArgs e)
        {
            cargarProdEspec();
        }

        private void btnMostrarProds_Click(object sender, EventArgs e)
        {
            cargarDgv();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodIngreProd.Text) || string.IsNullOrEmpty(txtDescIngreProd.Text) || string.IsNullOrEmpty(txtValUniIngreProd.Text) || string.IsNullOrEmpty(txtCantIngreProd.Text))
            {
                MessageBox.Show("Hay campos vacios.");
            }
            else if (ProdYaExiste() == true)
            {
                MessageBox.Show("El producto ya existe.");
            }
            else
            {
                Ce_Productos InsertarProducto = new Ce_Productos();
                InsertarProducto.Codigo = Convert.ToInt32(txtCodIngreProd.Text);
                InsertarProducto.Descripción = txtDescIngreProd.Text;
                InsertarProducto.Valor_Unidad = Convert.ToInt32(txtValUniIngreProd.Text);
                InsertarProducto.Cantidad = Convert.ToInt32(txtCantIngreProd.Text);
                oCn_Productos.InsertarProducto(InsertarProducto);
                LimpiarTxts();
                cargarDgv();
                cargarCmbs();
            }
        }

        private void btnActProd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescActProd.Text) || string.IsNullOrEmpty(txtValUniActProd.Text) || string.IsNullOrEmpty(txtCantActProd.Text))
            {
                MessageBox.Show("Hay campos vacios.");
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea actualizar el producto?", "Question", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Ce_Productos ActualizarProducto = new Ce_Productos();
                    ActualizarProducto.Codigo = Convert.ToInt32(cmbActProd.SelectedValue);
                    ActualizarProducto.Descripción = txtDescActProd.Text;
                    ActualizarProducto.Valor_Unidad = Convert.ToInt32(txtValUniActProd.Text);
                    ActualizarProducto.Cantidad = Convert.ToInt32(txtCantActProd.Text);
                    oCn_Productos.ActualizarProducto(ActualizarProducto);
                    cargarDgv();
                    cargarCmbs();
                }
            }
        }

        private void btnConsultarProdAct_Click(object sender, EventArgs e)
        {
            LimpiarTxts();
            Ce_Productos MostrarProductoEspec = new Ce_Productos();
            MostrarProductoEspec.Codigo = Convert.ToInt32(cmbActProd.SelectedValue);
            dt = oCn_Productos.MostrarProducto(MostrarProductoEspec);
            llenarTxtAct();
        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar el producto?", "Advertencia", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Ce_Productos EliminarProducto = new Ce_Productos();
                EliminarProducto.Codigo = Convert.ToInt32(cmbEliminarProd.SelectedValue);
                oCn_Productos.EliminarProducto(EliminarProducto);
                cargarDgv();
                cargarCmbs();
            }
        }

        #endregion

        #region Btns_LimpiarTextBox

        private void btnLimpiarIng_Click(object sender, EventArgs e)
        {
            LimpiarTxts();
        }

        private void btnLimpiarAct_Click(object sender, EventArgs e)
        {
            LimpiarTxts();
        }

        #endregion

        #region ValidacionesTextbox

        private void txtValUniIngreProd_TextChanged(object sender, EventArgs e)
        {
            if (Cp_MetodGlobal.validarCampos(txtValUniIngreProd) == true)
            {
                error.SetError(txtValUniIngreProd, "Solo numeros.");
            }
            else
            {
                error.SetError(txtValUniIngreProd, "");
            }
        }

        private void txtCantIngreProd_TextChanged(object sender, EventArgs e)
        {
            if (Cp_MetodGlobal.validarCampos(txtCantIngreProd) == true)
            {
                error.SetError(txtCantIngreProd, "Solo numeros.");
            }
            else
            {
                error.SetError(txtCantIngreProd, "");
            }
        }

        private void txtValUniActProd_TextChanged(object sender, EventArgs e)
        {
            if (Cp_MetodGlobal.validarCampos(txtValUniActProd) == true)
            {
                error.SetError(txtValUniActProd, "Solo numeros.");
            }
            else
            {
                error.SetError(txtValUniActProd, "");
            }
        }

        private void txtCantActProd_TextChanged(object sender, EventArgs e)
        {
            if (Cp_MetodGlobal.validarCampos(txtCantActProd) == true)
            {
                error.SetError(txtCantActProd, "Solo numeros.");
            }
            else
            {
                error.SetError(txtCantActProd, "");
            }
        }

        private void txtCodIngreProd_TextChanged(object sender, EventArgs e)
        {
            if (Cp_MetodGlobal.validarCampos(txtCodIngreProd) == true)
            {
                error.SetError(txtCodIngreProd, "Solo numeros.");
            }
            else
            {
                error.SetError(txtCodIngreProd, "");
            }
        }

        #endregion

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            Cp_MetodGlobal.ExportarExcel(dgvProductos);
        }
    }
}
