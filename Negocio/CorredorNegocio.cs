using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using AccesoDatos;

namespace Negocio
{
    public class CorredorNegocio
    {
        public List<Corredor> ListarCorredores()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Corredor> listado = new List<Corredor>();
            Corredor nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT C.ID_PROVEEDOR, C.NUMERO, C.NOMBRE, C.APELLIDO, C.TELEFONO, C.CELULAR, C.MAIL FROM CORREDORES C";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Corredor();
                    nuevo.Id_Proveedor = lector.GetInt32(0);
                    nuevo.Número = lector.GetString(1);
                    nuevo.Nombre = lector.GetString(2);
                    nuevo.Apellido = lector.GetString(3);
                    nuevo.Teléfono = lector.GetInt64(4);
                    nuevo.Celular = lector.GetInt64(5);
                    nuevo.Mail = lector.GetString(6);
                    listado.Add(nuevo);
                }

                return listado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void agregarCorredor(Corredor nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into CORREDORES (ID_PROVEEDOR, NUMERO, NOMBRE, APELLIDO, TELEFONO, CELULAR, MAIL) values";
                comando.CommandText += "('" + nuevo.Id_Proveedor + "','" + nuevo.Número + "', '" + nuevo.Nombre + "'," +
                    " '" + nuevo.Apellido + "', '" + nuevo.Teléfono + "', '" + nuevo.Celular + "', '" + nuevo.Mail + "')";
                comando.Connection = conexion;
                conexion.Open();

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void modificarCorredor(Corredor modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearConsulta("update CORREDORES Set Id_Proveedor=@Id_Proveedor, Numero=@Numero, Nombre=@Nombre," +
                    " Apellido=@Apellido, Telefono=@Telefono, Celular=@Celular, Mail=@Mail " +
                    " Where Id_Proveedor=" + modificar.Id_Proveedor.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Id_Proveedor", modificar.Id_Proveedor);
                accesoDatos.Comando.Parameters.AddWithValue("@Numero", modificar.Número);
                accesoDatos.Comando.Parameters.AddWithValue("@Nombre", modificar.Nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@Apellido", modificar.Apellido);
                accesoDatos.Comando.Parameters.AddWithValue("@Telefono", modificar.Teléfono);
                accesoDatos.Comando.Parameters.AddWithValue("@Celular", modificar.Celular);
                accesoDatos.Comando.Parameters.AddWithValue("@Mail", modificar.Mail);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }
    }
}
