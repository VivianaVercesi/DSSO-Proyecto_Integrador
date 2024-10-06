using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegradorForm.Entidades
{
    internal class E_Pago
    {
        public int idPago { get; set; }
        public int idCliente { get; set; }
        public int monto { get; set; }
        public DateTime fecha { get; set; }
        public string tipo { get; set; }
        //agrego el campo tipoCliente para diferenciar socio y no socio

    }
}
