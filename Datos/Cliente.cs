using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using ProyectoIntegradorForm.Entidades;

namespace ProyectoIntegradorForm.Datos
{
    internal class Cliente
    {
        public string? Nuevo_Cliente(E_Cliente cliente)
        {
            string? salida;

            MySqlConnection sqlCon = new();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand query = new MySqlCommand("CrearCliente", sqlCon);
                query.CommandType = CommandType.StoredProcedure;

                query.Parameters.Add("DNI", MySqlDbType.VarChar).Value = cliente.dniCliente;
                query.Parameters.Add("Nombre", MySqlDbType.VarChar).Value = cliente.nombreCliente;
                query.Parameters.Add("Apellido", MySqlDbType.VarChar).Value = cliente.apellidoCliente;
                query.Parameters.Add("Tipo", MySqlDbType.VarChar).Value = cliente.tipoCliente;
                
                MySqlParameter PIdCliente = new();
                PIdCliente.ParameterName = "id";
                PIdCliente.MySqlDbType = MySqlDbType.Int32;
                PIdCliente.Direction = ParameterDirection.Output;
                query.Parameters.Add(PIdCliente);

                sqlCon.Open();
                query.ExecuteNonQuery();
                if (PIdCliente.Value.Equals(-1))
                {
                    throw new Exception($"Ya existe un cliente con el DNI {cliente.dniCliente}");
                }
                salida = Convert.ToString(PIdCliente.Value);
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

        public E_Cliente? BuscarClientePorId(int id)
        {
            

            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand
                ("BuscarClientePorId", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("Id", MySqlDbType.Int16).Value = id;
                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                if (tabla.Rows.Count > 0)
                {
                    E_Cliente cliente = new E_Cliente();
                    cliente.idCliente = id;
                    cliente.dniCliente = tabla.Rows[0]["dniCliente"].ToString();
                    cliente.nombreCliente = tabla.Rows[0]["nombreCliente"].ToString();
                    cliente.apellidoCliente = tabla.Rows[0]["apellidoCliente"].ToString();
                    cliente.tipoCliente = tabla.Rows[0]["tipoCliente"].ToString();
                    return cliente;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }



            
        }

    }
}
