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
    public class ProveedorNegocio
    {
        public List<Proveedor> ListarProveedores()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Proveedor> listado = new List<Proveedor>();
            Proveedor nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT P.ID, P.RAZON_SOCIAL, P.CUIT, P.TELEFONO, P.CELULAR, P.MAIL, P.WEB, D.CALLE, D.NUMERO," +
                    " D.PISO, D.DEPARTAMENTO, D.LOCALIDAD, D.CODIGO_POSTAL FROM PROVEEDORES P, DIRECCIONES_PROVEEDORES D WHERE P.ID = D.ID";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Proveedor();
                    nuevo.Id = lector.GetInt32(0);
                    nuevo.RazónSocial = lector.GetString(1);
                    nuevo.Cuit = lector.GetInt64(2);
                    nuevo.Teléfono = lector.GetInt64(3);
                    nuevo.Celular = lector.GetInt64(4);
                    nuevo.Mail = lector.GetString(5);
                    nuevo.Web = lector.GetString(6);
                    nuevo.Calle = lector.GetString(7);
                    nuevo.Número = lector.GetInt32(8);
                    nuevo.Piso = lector.GetInt32(9);
                    nuevo.Departamento = lector.GetString(10);
                    nuevo.Localidad = lector.GetString(11);
                    nuevo.CódigoPostal = lector.GetInt32(12);
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

        public void agregarProveedor(Proveedor nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into PROVEEDORES (RAZON_SOCIAL, CUIT, TELEFONO, CELULAR, MAIL, WEB) values";
                comando.CommandText += "('" + nuevo.RazónSocial + "', '" + nuevo.Cuit + "', '" + nuevo.Teléfono + "'," +
                    " '" + nuevo.Celular + "', '" + nuevo.Mail + "', '" + nuevo.Web + "')";
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

        public void agregarDirección(Proveedor nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into DIRECCIONES_PROVEEDORES (CALLE, NUMERO, PISO, DEPARTAMENTO, LOCALIDAD, CODIGO_POSTAL) values";
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

        public void modificarProveedor(Proveedor modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearConsulta("update PROVEEDORES Set Razon_Social=@Razon_Social, Cuit=@Cuit, Telefono=@Telefono," +
                    " Celular=@Celular, Mail=@Mail, Web=@Web Where Id=" + modificar.Id.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Razon_Social", modificar.RazónSocial);
                accesoDatos.Comando.Parameters.AddWithValue("@Cuit", modificar.Cuit);
                accesoDatos.Comando.Parameters.AddWithValue("@Telefono", modificar.Teléfono);
                accesoDatos.Comando.Parameters.AddWithValue("@Celular", modificar.Celular);
                accesoDatos.Comando.Parameters.AddWithValue("@Mail", modificar.Mail);
                accesoDatos.Comando.Parameters.AddWithValue("@Web", modificar.Web);
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

        public void modificarDirección(Proveedor modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearConsulta("update DIRECCIONES_PROVEEDORES Set Calle=@Calle, Numero=@Numero, Piso=@Piso, Departamento=@Departamento," +
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
