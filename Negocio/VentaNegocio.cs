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
    public class VentaNegocio
    {
        public List<Venta> ListarVentas()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Venta> listado = new List<Venta>();
            Venta nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT DetalleVenta, Producto, PrecioUnitario, CantidadParcial, Precio FROM VENTAS";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Venta();
                    nuevo.DetalleVenta = lector.GetString(0);
                    nuevo.Producto = lector.GetString(1);
                    nuevo.PrecioUnitario = lector.GetDecimal(2);
                    nuevo.CantidadParcial = lector.GetInt32(3);
                    nuevo.Precio = lector.GetDecimal(4);
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
    }
}
