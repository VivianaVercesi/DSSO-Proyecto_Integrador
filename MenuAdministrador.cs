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
    public partial class frmMenuAdministrador : Form
    {
        public frmMenuAdministrador()
        {
            InitializeComponent();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            Form formulario = new frmRegistrarCliente();
            formulario.ShowDialog();
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            Form formulario = new frmRegistrarPago(null);
            formulario.ShowDialog();
        }

        private void btnObtenerVencimientos_Click(object sender, EventArgs e)
        {
            Form formulario = new frmVencimientosDiarios();
            formulario.ShowDialog();
        }
    }
}
