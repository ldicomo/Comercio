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
    public class CompraNegocio
    {
        public List<Compra> ListarCompras()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Compra> listado = new List<Compra>();
            Compra nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT DetalleCompra, Producto, PrecioUnitario, CantidadParcial, Precio FROM COMPRAS";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Compra();
                    nuevo.DetalleCompra = lector.GetString(0);
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
