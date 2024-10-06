using MySql.Data.MySqlClient;
using ProyectoIntegradorForm.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegradorForm.Datos
{
    internal class Pago
    {
        public string? Nuevo_Pago(E_Pago pago)
        {   
            string? salida;

            MySqlConnection sqlCon = new();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand query = new MySqlCommand("CrearPago", sqlCon);
                query.CommandType = CommandType.StoredProcedure;

                query.Parameters.Add("Id", MySqlDbType.Int16).Value = pago.idCliente;
                query.Parameters.Add("Monto", MySqlDbType.Int16).Value = pago.monto;
                query.Parameters.Add("Fecha", MySqlDbType.Date).Value = pago.fecha;
                query.Parameters.Add("Tipo", MySqlDbType.VarChar).Value = pago.tipo;

                MySqlParameter PIdPago = new();
                PIdPago.ParameterName = "ID_Pago";
                PIdPago.MySqlDbType = MySqlDbType.Int32;
                PIdPago.Direction = ParameterDirection.Output;
                query.Parameters.Add(PIdPago);


                sqlCon.Open();
                query.ExecuteNonQuery();
                if (PIdPago.Value.Equals(-1))
                {
                    throw new Exception($"No existe un cliente con el ID {pago.idCliente}");
                }
                salida = Convert.ToString(PIdPago.Value);
            }
            catch (Exception ex)
            {
                salida = "Error: " + ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) { sqlCon.Close(); }
            }
            return salida;
        }
    }
}
