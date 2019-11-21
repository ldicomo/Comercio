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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            DatosProducto ventana1 = new DatosProducto();
            ventana1.ShowDialog();
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            ProductoNegocio producto = new ProductoNegocio();
            try
            {
                dgvProductos.DataSource = producto.ListarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                DatosProducto modificar = new DatosProducto((Producto)dgvProductos.CurrentRow.DataBoundItem);
                modificar.ShowDialog();
                cargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
