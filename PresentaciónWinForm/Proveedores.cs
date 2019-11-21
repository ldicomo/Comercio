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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            DatosProveedor ventana1 = new DatosProveedor();
            ventana1.ShowDialog();
            DireccionProveedor ventana2 = new DireccionProveedor();
            ventana2.ShowDialog();
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            ProveedorNegocio Proveedor = new ProveedorNegocio();
            try
            {
                dgvProveedores.DataSource = Proveedor.ListarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                DatosProveedor modificar1 = new DatosProveedor((Proveedor)dgvProveedores.CurrentRow.DataBoundItem);
                modificar1.ShowDialog();
                DireccionProveedor modificar2 = new DireccionProveedor((Proveedor)dgvProveedores.CurrentRow.DataBoundItem);
                modificar2.ShowDialog();
                cargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnContactosProveedor_Click(object sender, EventArgs e)
        {
            Contactos ventana1 = new Contactos();
            ventana1.Show();
        }

        private void btnCorredoresProveedor_Click(object sender, EventArgs e)
        {
            Corredores ventana2 = new Corredores();
            ventana2.Show();
        }
    }
}
