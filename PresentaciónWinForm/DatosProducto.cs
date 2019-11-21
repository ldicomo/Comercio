using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace PresentaciónWinForm
{
    public partial class DatosProducto : Form
    {
        private Producto productoLocal = null;

        public DatosProducto()
        {
            InitializeComponent();
        }

        public DatosProducto(Producto producto)
        {
            InitializeComponent();
            productoLocal = producto;
        }

        private void txtTipoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Valida solo letras, backspace y espacio.
            if (!(e.KeyChar > 64 && e.KeyChar < 91) && !(e.KeyChar > 96 && e.KeyChar < 123)
                && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;
        }

        private void txtStockProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtStockMínimoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtPorcentajeProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 46)
                e.Handled = true;
        }

        private void txtPrecioCompraProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 46)
                e.Handled = true;
        }

        private void txtPrecioVentaProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 46)
                e.Handled = true;
        }

        private void btnAceptarProducto_Click(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            try
            {

                if (productoLocal == null)
                    productoLocal = new Producto();

                productoLocal.Descripción = txtDescripciónProducto.Text;
                productoLocal.Tipo = txtTipoProducto.Text;
                productoLocal.Marca = txtMarcaProducto.Text;
                productoLocal.Stock = Convert.ToInt32(txtStockProducto.Text);
                productoLocal.StockMínimo = Convert.ToInt32(txtStockMínimoProducto.Text);
                productoLocal.PrecioCompra = Convert.ToDecimal(txtPrecioCompraProducto.Text);
                productoLocal.PrecioVenta = Convert.ToDecimal(txtPrecioVentaProducto.Text);
                productoLocal.Porcentaje = Convert.ToDecimal(txtPorcentajeProducto.Text);

                if (productoLocal.Id != 0)
                {
                    negocio.modificarProducto(productoLocal);
                }
                else
                {
                    negocio.agregarProducto(productoLocal);
                }

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            txtDescripciónProducto.Text = "";
            txtTipoProducto.Text = "";
            txtMarcaProducto.Text = "";
            txtStockProducto.Text = "";
            txtStockMínimoProducto.Text = "";
            txtPorcentajeProducto.Text = "";
            txtPrecioCompraProducto.Text = "";
            txtPrecioVentaProducto.Text = "";
        }

        private void DatosProducto_Load(object sender, EventArgs e)
        {
            try
            {
                if (productoLocal != null)
                {
                    txtDescripciónProducto.Text = productoLocal.Descripción;
                    txtTipoProducto.Text = productoLocal.Tipo;
                    txtMarcaProducto.Text = productoLocal.Marca;
                    txtStockProducto.Text = productoLocal.Stock.ToString();
                    txtStockMínimoProducto.Text = productoLocal.StockMínimo.ToString();
                    txtPorcentajeProducto.Text = productoLocal.PrecioCompra.ToString();
                    txtPrecioCompraProducto.Text = productoLocal.PrecioVenta.ToString();
                    txtPrecioVentaProducto.Text = productoLocal.Porcentaje.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

