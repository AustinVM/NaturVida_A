using CapaEntidades;
using CapaNegocios;
using CapaPresentacion.Global;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion.Facturas
{
    public partial class AggFactura : Form
    {
        Cn_Clientes oCn_Clientes = new Cn_Clientes();
        Ce_Cliente oCe_MostrarCliente = new Ce_Cliente();
        Cn_Productos oCn_Productos = new Cn_Productos();
        Ce_Productos oCe_MostrarProducto = new Ce_Productos();
        Cn_Factura oCn_Factura = new Cn_Factura();
        ErrorProvider error = new ErrorProvider();
        private double acum = 0;

        public AggFactura()
        {
            InitializeComponent();
        }

        private void AggFactura_Load(object sender, EventArgs e)
        {
            llenarCMbs();
        }

        private void btnAggProd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantFactProd.Text))
            {
                MessageBox.Show("Campo cantidad vacio.");
            }
            else
            {
                llenarDgv();
            }
        }

        private void btnTerminarFactura_Click(object sender, EventArgs e)
        {
            if (dgvFacturas.Rows.Count == 0)
            {
                MessageBox.Show("Ingrese un registro");
            }
            else
            {
                enviaBD();
            }
        }

        #region MisMetodos

        private void llenarCMbs()
        {
            cmbFactClien.DataSource = oCn_Clientes.MostrarCliente(oCe_MostrarCliente);
            cmbFactClien.ValueMember = "Documento";
            cmbFactClien.DisplayMember = "Nombre";

            cmbFactProd.DataSource = oCn_Productos.MostrarProducto(oCe_MostrarProducto);
            cmbFactProd.ValueMember = "Codigo";
            cmbFactProd.DisplayMember = "Descripción";
        }

        private void llenarDgv()
        {
            if (valCantidad() == true)
            {
                MessageBox.Show("El campo de cantidad no puede contener letras.");
            }
            else
            {
                Ce_Productos valUni = new Ce_Productos();
                valUni.Codigo = Convert.ToInt32(cmbFactProd.SelectedValue);
                DataTable dt = oCn_Productos.MostrarProducto(valUni);

                if (Convert.ToInt32(txtCantFactProd.Text) <= 0)
                {
                    MessageBox.Show("Cantidad invalida");
                }
                else if (Convert.ToInt32(dt.Rows[0]["Cantidad"]) - Convert.ToInt32(txtCantFactProd.Text) < 0)
                {
                    MessageBox.Show("No es posible vender más de la cantidad en inventario.");
                }
                else
                {
                    string[] registro = new string[]
                    {
                        DateTime.Today.ToShortDateString(), cmbFactClien.SelectedValue.ToString(),
                        Cp_VarGlobal.codVendedor.ToString(), cmbFactProd.SelectedValue.ToString(),
                        txtCantFactProd.Text, dt.Rows[0]["Valor_Unidad"].ToString()
                    };

                    dgvFacturas.Rows.Add(registro);
                    totalFact();
                }
            }
        }

        private void totalFact()
        {
            int totalFact = 0;

            foreach (DataGridViewRow c in dgvFacturas.Rows)
            {
                totalFact = Convert.ToInt32(c.Cells[4].Value) * Convert.ToInt32(c.Cells[5].Value);
                acum += totalFact;
            }

            txtTotalFact.Text = acum.ToString();
        }

        private void enviaBD()
        {
            Ce_Factura enviaBD = new Ce_Factura();
            Ce_FactutaDetalles enviaBDDtF = new Ce_FactutaDetalles();

            enviaBD.Fecha = Convert.ToDateTime(dgvFacturas.CurrentRow.Cells[0].Value);
            enviaBD.Documento_Cliente = Convert.ToInt32(dgvFacturas.CurrentRow.Cells[1].Value);
            enviaBD.Codigo_Vendedor = Cp_VarGlobal.codVendedor;

            oCn_Factura.InsertarFactura(enviaBD);

            foreach (DataGridViewRow registro in dgvFacturas.Rows)
            {
                Cn_FacturaDetalles oCn_FacturaDetalles = new Cn_FacturaDetalles();
                enviaBDDtF.Codigo_Productos = Convert.ToInt32(registro.Cells[3].Value);
                enviaBDDtF.Cantidad = Convert.ToInt32(registro.Cells[4].Value);
                enviaBDDtF.Valor_Unidad = Convert.ToInt32(registro.Cells[5].Value);
                oCn_FacturaDetalles.InsertarFacturaDetalles(enviaBDDtF);
            }

            MessageBox.Show("Factura Terminada corrextamente.");
            dgvFacturas.Rows.Clear();
        }

        // El dynamic es como si retornase un var 'private dynamic ValProductos()'
        private bool ValProductos()  // Metodo que valida si un producto ya fue ingresado
        {
            bool val = true;

            foreach (DataGridViewRow fila in dgvFacturas.Rows)
            {
                if (Convert.ToInt32(cmbFactProd.SelectedValue) == Convert.ToInt32(fila.Cells[3].Value))
                {
                    MessageBox.Show("Producto ya ingresado.");
                    val = false;
                    break;
                }
            }
            if (string.IsNullOrEmpty(txtCantFactProd.Text))
            {
                val = false;
            }

            return val;
        }

        private bool valCantidad()
        {
            bool error = false;

            foreach (char c in txtCantFactProd.Text)
            {
                if (!char.IsDigit(c))
                {
                    error = true;
                    break;
                }
            }

            return error;
        }

        //if (ValProductos() == false)
        //{
        //    lblAdventecia.Visible = true;
        //    lblAdventecia.Text = "POR FAVOR VERIFIQUE LOS DATOS.";
        //}

        /*Convert.ToInt32(txtCantFactProd.Text) >= Convert.ToInt32(dt.Rows[0]["Cantidad"]) ||*/

        #endregion

        private void txtCantFactProd_TextChanged(object sender, EventArgs e)
        {
            if (Cp_MetodGlobal.validarCampos(txtCantFactProd) == true)
            {
                error.SetError(txtCantFactProd, "Solo numeros.");
            }
            else
            {
                error.SetError(txtCantFactProd, "");
            }
        }
    }
}
