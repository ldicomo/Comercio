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
    public class ClienteNegocio
    {
        public List<Cliente> ListarClientes()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Cliente> listado = new List<Cliente>();
            Cliente nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT C.ID, C.NOMBRE, C.APELLIDO, C.DNI, C.FECHA_NACIMIENTO, C.TELEFONO, C.CELULAR, C.MAIL, " +
                    " D.CALLE, D.NUMERO, D.PISO, D.DEPARTAMENTO, D.LOCALIDAD, D.CODIGO_POSTAL FROM CLIENTES C, DIRECCIONES_CLIENTES D WHERE C.ID = D.ID";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Cliente();
                    nuevo.Id = lector.GetInt32(0);
                    nuevo.Nombre = lector.GetString(1);
                    nuevo.Apellido = lector.GetString(2);
                    nuevo.Dni = lector.GetInt64(3);
                    nuevo.FechaNacimiento = lector.GetString(4);
                    nuevo.Teléfono = lector.GetInt64(5);
                    nuevo.Celular = lector.GetInt64(6);
                    nuevo.Mail = lector.GetString(7);
                    nuevo.Calle = lector.GetString(8);
                    nuevo.Número = lector.GetInt32(9);
                    nuevo.Piso = lector.GetInt32(10);
                    nuevo.Departamento = lector.GetString(11);
                    nuevo.Localidad = lector.GetString(12);
                    nuevo.CódigoPostal = lector.GetInt32(13);
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

        public void agregarCliente(Cliente nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into CLIENTES (NOMBRE, APELLIDO, DNI, FECHA_NACIMIENTO, TELEFONO, CELULAR, MAIL) values";
                comando.CommandText += "('" + nuevo.Nombre + "', '" + nuevo.Apellido + "', '" + nuevo.Dni + "', '" + nuevo.FechaNacimiento + "'," +
                    " '" + nuevo.Teléfono + "', '" + nuevo.Celular + "', '" + nuevo.Mail + "')";
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

        public void agregarDirección(Cliente nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into DIRECCIONES_CLIENTES (CALLE, NUMERO, PISO, DEPARTAMENTO, LOCALIDAD, CODIGO_POSTAL) values";
                comando.CommandText += "('" + nuevo.Calle + "', '" + nuevo.Número + "', '" + nuevo.Piso + "', '" + nuevo.Departamento + "'," +
                    " '" + nuevo.Localidad + "', '" + nuevo.CódigoPostal + "')";
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

        public void modificarCliente(Cliente modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearConsulta("update CLIENTES Set Nombre=@Nombre, Apellido=@Apellido, Dni=@Dni, Fecha_Nacimiento=@Fecha_Nacimiento," +
                    " Telefono=@Telefono, Celular=@Celular, Mail=@Mail Where Id=" + modificar.Id.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Nombre", modificar.Nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@Apellido", modificar.Apellido);
                accesoDatos.Comando.Parameters.AddWithValue("@Dni", modificar.Dni);
                accesoDatos.Comando.Parameters.AddWithValue("@Fecha_Nacimiento", modificar.FechaNacimiento);
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

        public void modificarDirección(Cliente modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearConsulta("update DIRECCIONES_CLIENTES Set Calle=@Calle, Numero=@Numero, Piso=@Piso, Departamento=@Departamento," +
                    " Localidad=@Localidad, Codigo_Postal=@Codigo_Postal Where Id=" + modificar.Id.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Calle", modificar.Calle);
                accesoDatos.Comando.Parameters.AddWithValue("@Numero", modificar.Número);
                accesoDatos.Comando.Parameters.AddWithValue("@Piso", modificar.Piso);
                accesoDatos.Comando.Parameters.AddWithValue("@Departamento", modificar.Departamento);
                accesoDatos.Comando.Parameters.AddWithValue("@Localidad", modificar.Localidad);
                accesoDatos.Comando.Parameters.AddWithValue("@Codigo_Postal", modificar.CódigoPostal);
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
