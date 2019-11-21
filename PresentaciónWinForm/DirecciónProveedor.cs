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
    public partial class DireccionProveedor : Form
    {
        private Proveedor proveedorLocal = null;

        public DireccionProveedor()
        {
            InitializeComponent();
        }

        public DireccionProveedor(Proveedor proveedor)
        {
            InitializeComponent();
            proveedorLocal = proveedor;
        }

        private void txtCalleDirección_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNúmeroDirección_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtPisoDirección_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtDepartamentoDirección_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtLocalidadDirección_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCóigoPostalDirección_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnAceptarDirección_Click(object sender, EventArgs e)
        {
            ProveedorNegocio negocio = new ProveedorNegocio();
            try
            {
                if (proveedorLocal == null)
                    proveedorLocal = new Proveedor();

                proveedorLocal.Calle = txtCalleDirección.Text;
                proveedorLocal.Número = Convert.ToInt32(txtNúmeroDirección.Text);
                proveedorLocal.Piso = Convert.ToInt32(txtPisoDirección.Text);
                proveedorLocal.Departamento = txtDepartamentoDirección.Text;
                proveedorLocal.Localidad = txtLocalidadDirección.Text;
                proveedorLocal.CódigoPostal = Convert.ToInt32(txtCódigoPostalDirección.Text);

                if (proveedorLocal.Id != 0)
                {
                    negocio.modificarDirección(proveedorLocal);
                }
                else
                {
                    negocio.agregarDirección(proveedorLocal);
                }

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarDirección_Click(object sender, EventArgs e)
        {
            txtCalleDirección.Text = "";
            txtNúmeroDirección.Text = "";
            txtPisoDirección.Text = "";
            txtDepartamentoDirección.Text = "";
            txtLocalidadDirección.Text = "";
            txtCódigoPostalDirección.Text = "";
        }

        private void DireccionProveedor_Load(object sender, EventArgs e)
        {
            try
            {
                if (proveedorLocal != null)
                {
                    txtCalleDirección.Text = proveedorLocal.Calle;
                    txtNúmeroDirección.Text = proveedorLocal.Número.ToString();
                    txtPisoDirección.Text = proveedorLocal.Piso.ToString();
                    txtDepartamentoDirección.Text = proveedorLocal.Departamento;
                    txtLocalidadDirección.Text = proveedorLocal.Localidad;
                    txtCódigoPostalDirección.Text = proveedorLocal.CódigoPostal.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
