using ProyectoIntegradorForm.Documentos;
using ProyectoIntegradorForm.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegradorForm
{
    public partial class frmRegistrarCliente : Form
    {
        private object Public;

        public frmRegistrarCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //* Validar data del formulario  *//
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor. Ingrese un nombre");
            }
            else if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Por favor. Ingrese un apellido");
            }
            else if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("Por favor. Ingrese un DNI");
            }
            else if(!chbAptoFisico.Checked)
            {
                MessageBox.Show("Para registrar un cliente tiene que tener aprobado el apto físico", "Apto físico", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //* Recopilar la data del formulario  *//
                E_Cliente nuevoCliente = new E_Cliente();
                nuevoCliente.nombreCliente = txtNombre.Text;
                nuevoCliente.apellidoCliente = txtApellido.Text;
                nuevoCliente.dniCliente = txtDNI.Text;
                nuevoCliente.tipoCliente = chbSocio.Checked ? "Socio" : "No socio" ;

                //* Registrar el cliente en la BBDD *//
                Datos.Cliente cliente = new Datos.Cliente();
                string? idNuevoCliente = cliente.Nuevo_Cliente(nuevoCliente);
                
                if (idNuevoCliente is null)
                {
                    //* Mostrar error generico  *//
                    MessageBox.Show("Algo fallo");
                }
                else if (idNuevoCliente.StartsWith("Error"))
                {
                    //* Mostrar error manejado  *//
                    MessageBox.Show(idNuevoCliente);
                }
                else
                {
                    if (nuevoCliente.tipoCliente == "Socio")
                    {
                        frmRegistrarPago formulario = new frmRegistrarPago(idNuevoCliente);

                        formulario.ShowDialog();
                    }

                    //* Crear y mostrar carnet *//
                    frmCarnet carnet = new frmCarnet();
                    nuevoCliente.idCliente = int.Parse(idNuevoCliente);
                    carnet.CargarDataCliente(nuevoCliente);
                    carnet.ShowDialog();


                    //* Limpiar el formulario *//
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtDNI.Clear();
                    chbSocio.Checked = false;
                    chbAptoFisico.Checked = false;
                }
            }
        }
    }
}


