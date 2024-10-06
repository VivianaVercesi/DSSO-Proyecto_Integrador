using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegradorForm.Entidades
{
    internal class E_Cliente
    {
        public int idCliente { get; set; }
        public string dniCliente { get; set; }
        public string nombreCliente { get; set; }
        public string apellidoCliente { get; set; }
        //agrego el campo tipoCliente para diferenciar socio y no socio
        public string tipoCliente { get; set; }
    }
}
