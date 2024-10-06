using MySql.Data.MySqlClient;
using ProyectoIntegradorForm.Datos;
using ProyectoIntegradorForm.Documentos;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoIntegradorForm.Entidades;

namespace ProyectoIntegradorForm
{
    public partial class frmRegistrarPago : Form
    {
        public frmRegistrarPago(string? idUsuario)
        {
            InitializeComponent();
            txtNroId.Text = idUsuario;
        }


        private void btnPagar_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtNroId.Text, out int result))
            {
                MessageBox.Show("Por favor ingrese un id válido.");
            }
            else if (!int.TryParse(txtMonto.Text, out result))
            {
                MessageBox.Show("Por favor ingrese un monto válido.");
            }
            else
            {
                Cliente cliente = new Cliente();
                E_Cliente eCliente = new E_Cliente();
                eCliente = cliente.BuscarClientePorId(int.Parse(txtNroId.Text));



                if (eCliente == null)
                {
                    MessageBox.Show($"No existe un cliente con el ID {txtNroId.Text}");
                }
                else
                {
                    E_Pago nuevoPago = new E_Pago();

                    nuevoPago.idCliente = int.Parse(txtNroId.Text);
                    nuevoPago.monto = int.Parse(txtMonto.Text);
                    nuevoPago.fecha = DateTime.Today;
                    nuevoPago.tipo = eCliente.tipoCliente == "Socio" ? "Cuota" : "Unico";
                    Datos.Pago pago = new Datos.Pago();
                    string? idNuevoPago = pago.Nuevo_Pago(nuevoPago);


                    if (idNuevoPago is null)
                    {
                        //* Mostrar error generico  *//
                        MessageBox.Show("Algo fallo");
                    }
                    else if (idNuevoPago.StartsWith("Error"))
                    {
                        //* Mostrar error manejado  *//
                        MessageBox.Show(idNuevoPago);
                    }
                    else
                    {

                        //Crear y mostrar comprobante

                        nuevoPago.idPago = int.Parse(idNuevoPago);
                        frmComprobanteDePago comprobante = new frmComprobanteDePago();

                        comprobante.CargarDataPago(nuevoPago, eCliente);

                        comprobante.ShowDialog();


                        //* Limpiar el formulario *//
                        txtNroId.Clear();
                        txtMonto.Clear();
                    }
                }
            }
        }
    }
}
