using MySql.Data.MySqlClient;
using ProyectoIntegradorForm.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegradorForm
{
    public partial class frmVencimientosDiarios : Form
    {
        public frmVencimientosDiarios()
        {
            InitializeComponent();
        }

        private void VencimientosDiarios_Load(object sender, EventArgs e)
        {
            MySqlDataReader resultado;
            MySqlConnection sqlCon = new MySqlConnection();
            DataTable tablaVencimientos = new DataTable();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand
                ("VencimientosDiarios", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tablaVencimientos.Load(resultado);

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) { sqlCon.Close(); }
            }

            if (tablaVencimientos.Rows.Count > 0)
            {

                dataGridView.DataSource = tablaVencimientos;
                

            }
            else
            {
                MessageBox.Show("No se encontraron vencimientos para este día.");
                this.Close();
            }
        }
    }
}
