using CapaEntidades;
using CapaNegocios;
using CapaPresentacion.Global;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion.Principal
{
    public partial class Login : Form
    {
        Cn_Vendedor oCn_Vendedor = new Cn_Vendedor();
        Ce_Vendedor AutenticarVendedor = new Ce_Vendedor();

        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            AutenticarVendedor.Usuario = txtUsuario.Text;
            AutenticarVendedor.Contraseña = txtContrasenia.Text;
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasenia.Text))
            {
                MessageBox.Show("Campos vacios.");
            }
            else
            {
                switch (oCn_Vendedor.AutenticarVendedor(AutenticarVendedor))
                {
                    case 1:
                        AsignarVarGlobal();
                        MenuPrincipal MenPrin = new MenuPrincipal();
                        MenPrin.Show();
                        this.Hide();
                        break;
                    case 2:
                        MessageBox.Show("Usuario y/o contraseña incorrectos.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        break;
                    case 3:
                        MessageBox.Show("El usuario no existe.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AsignarVarGlobal()
        {
            Ce_Vendedor AutenticarVendedor = new Ce_Vendedor();
            DataTable dt = oCn_Vendedor.MostrarVendedor(AutenticarVendedor);
            Cp_VarGlobal.UsuarioVendedor = txtUsuario.Text;
            Cp_VarGlobal.codVendedor = Convert.ToInt32(dt.Rows[0]["Codigo"]);
        }
    }
}
