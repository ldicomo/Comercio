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
    public class ProductoNegocio
    {
        public List<Producto> ListarProductos()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Producto> listado = new List<Producto>();
            Producto nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT ID, DESCRIPCION, TIPO, MARCA, STOCK, STOCK_MINIMO, PRECIO_COMPRA, PRECIO_VENTA, PORCENTAJE " +
                    " FROM PRODUCTOS";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Producto();
                    nuevo.Id = lector.GetInt32(0);
                    nuevo.Descripción = lector.GetString(1);
                    nuevo.Tipo = lector.GetString(2);
                    nuevo.Marca = lector.GetString(3);
                    nuevo.Stock = lector.GetInt32(4);
                    if (!Convert.IsDBNull(lector.GetInt32(5)))
                        nuevo.StockMínimo = lector.GetInt32(5);
                    if (!Convert.IsDBNull(lector.GetDecimal(6)))
                        nuevo.PrecioCompra = lector.GetDecimal(6);
                    if (!Convert.IsDBNull(lector.GetDecimal(7)))
                        nuevo.PrecioVenta = lector.GetDecimal(7);
                    if (!Convert.IsDBNull(lector.GetDecimal(8)))
                        nuevo.Porcentaje = lector.GetDecimal(8);
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

        public void agregarProducto(Producto nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into PRODUCTOS (DESCRIPCION, TIPO, MARCA, STOCK, STOCK_MINIMO, PRECIO_COMPRA, PRECIO_VENTA," +
                    " PORCENTAJE) values";
                comando.CommandText += "('" + nuevo.Descripción + "', '" + nuevo.Tipo + "', '" + nuevo.Marca + "', '" + nuevo.Stock + "'," +
                    " '" + nuevo.StockMínimo + "', '" + nuevo.PrecioCompra + "', '" + nuevo.PrecioVenta + "', '" + nuevo.Porcentaje + "')";
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

        public void modificarProducto(Producto modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearConsulta("update Productos Set Descripcion=@Descripcion, Tipo=@Tipo, Marca=@Marca, Stock=@Stock," +
                    " Stock_Minimo=@Stock_Minimo, Precio_Compra=@Precio_Compra, Precio_Venta=@Precio_Venta, Porcentaje=@Porcentaje" +
                    " Where Id=" + modificar.Id.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Descripcion", modificar.Descripción);
                accesoDatos.Comando.Parameters.AddWithValue("@Tipo", modificar.Tipo);
                accesoDatos.Comando.Parameters.AddWithValue("@Marca", modificar.Marca);
                accesoDatos.Comando.Parameters.AddWithValue("@Stock", modificar.Stock);
                accesoDatos.Comando.Parameters.AddWithValue("@Stock_Minimo", modificar.StockMínimo);
                accesoDatos.Comando.Parameters.AddWithValue("@Precio_Compra", modificar.PrecioCompra);
                accesoDatos.Comando.Parameters.AddWithValue("@Precio_Venta", modificar.PrecioVenta);
                accesoDatos.Comando.Parameters.AddWithValue("@Porcentaje", modificar.Porcentaje);
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
