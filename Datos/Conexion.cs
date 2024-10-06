

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ProyectoIntegradorForm.Datos
{
    public class Conexion
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        private Conexion()
        {
            bool correcto = false;
            int mensaje;

            string T_servidor = "localhost";
            string T_puerto = "3306";
            string T_usuario = "root";
            string T_clave = "";

            while (!correcto)
            {
                T_servidor = Microsoft.VisualBasic.Interaction.InputBox("Ingrese servidor", "Datos de instalacion MySQL", T_servidor);
                T_puerto = Microsoft.VisualBasic.Interaction.InputBox("Ingrese puerto", "Datos de instalacion MySQL", T_puerto);
                T_usuario = Microsoft.VisualBasic.Interaction.InputBox("Ingrese usuario", "Datos de instalacion MySQL", T_usuario);
                T_clave = Microsoft.VisualBasic.Interaction.InputBox("Ingrese clave", "Datos de instalacion MySQL", T_clave);

                mensaje = (int)MessageBox.Show($"Su ingreso: \n SERVIDOR= {T_servidor} \n PUERTO= {T_puerto} \n" +
                    $" USUARIO= {T_usuario} \n CLAVE= {T_clave}", "Aviso del sistema",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mensaje != 6)
                {
                    MessageBox.Show("Ingrese nuevamente los datos");
                    correcto = false;
                } else
                {
                    correcto = true;
                }
            }

            this.baseDatos = "Proyecto";
            this.servidor = T_servidor;
            this.clave = T_clave;
            this.puerto = T_puerto;
            this.usuario = T_usuario;

        }
        public MySqlConnection CrearConexion()
        {
            MySqlConnection? cadena = new MySqlConnection();
            try
            { cadena.ConnectionString = "datasource=" + this.servidor +
                                        ";port=" + this.puerto +
                                        ";username=" + this.usuario +
                                        ";password=" + this.clave +
                                        ";Database=" + this.baseDatos;
                                        }
            catch (Exception ex)
            {
                cadena=null;
                throw;
            }
            return cadena;
        }
        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }

        public static void eliminarInstancia()
        {
            if (con != null) con = null;
        }
    }
}
