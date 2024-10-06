using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoIntegradorForm.Entidades;

namespace ProyectoIntegradorForm.Documentos
{
    public partial class frmComprobanteDePago : Form
    {
        public frmComprobanteDePago()
        {
            InitializeComponent();
        }


        internal void CargarDataPago(E_Pago datosPago, E_Cliente datosCliente)
        {
            lblValorIdPago.Text = datosPago.idPago.ToString();
            lblValorIdCliente.Text = datosPago.idCliente.ToString();
            lblValorNombre.Text = datosCliente.apellidoCliente + ", " + datosCliente.nombreCliente;
            lblValorDNI.Text = datosCliente.dniCliente;
            lblValorTipo.Text = datosPago.tipo;
            lblValorMonto.Text = datosPago.monto.ToString();
            lblValorFecha.Text = datosPago.fecha.ToString("d");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            btnImprimir.Visible = false;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
            pd.Print();
            btnImprimir.Visible = true;
            MessageBox.Show("Operaación existosa", "AVISO DEL SISTEMA",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void ImprimirForm1(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }
    }
}


