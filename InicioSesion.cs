using MySql.Data.MySqlClient;
using System.Data;

namespace ProyectoIntegradorForm
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }


        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "usuario")
            {
                txtUsuario.Text = "";
            }
        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "usuario";
            }
        }
        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == "contraseña")
            {
                txtClave.Text = "";
                txtClave.UseSystemPasswordChar = true;
            }
        }
        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {
                txtClave.Text = "contraseña";
                txtClave.UseSystemPasswordChar = false;
            }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable();
            Datos.Usuario dato = new Datos.Usuario();
            try
            {
                tablaLogin = dato.Log_Usu(L_Usu: txtUsuario.Text,
                                          txtClave.Text);
                if (tablaLogin.Rows.Count > 0)
                {
                    MessageBox.Show("Ingreso exitoso");
                    Form formulario = new frmMenuAdministrador();
                    formulario.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Usuario y/o password incorrecto");
                }
            }
            catch (Exception ex)
            {
                string titulo = "Error inesperado";
                if (ex is MySqlException)
                {
                    titulo = "Error de conexion";
                }
                MessageBox.Show(ex.Message, titulo, 0, MessageBoxIcon.Error);
            }
        }


    }
}


