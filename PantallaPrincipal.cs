﻿using System;
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
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            Form formulario = new frmInicioSesion();
            formulario.ShowDialog();


        }
    }
}
