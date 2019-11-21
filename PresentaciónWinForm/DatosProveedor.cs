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
    public partial class DatosProveedor : Form
    {
        private Proveedor proveedorLocal = null;

        public DatosProveedor()
        {
            InitializeComponent();
        }

        public DatosProveedor(Proveedor proveedor)
        {
            InitializeComponent();
            proveedorLocal = proveedor;
        }

        private void txtRazónSocialProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCuitProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTelProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCelularProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtMailProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtWebProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnAceptarProveedor_Click(object sender, EventArgs e)
        {
            ProveedorNegocio negocio = new ProveedorNegocio();
            try
            {
                if (proveedorLocal == null)
                    proveedorLocal = new Proveedor();

                proveedorLocal.RazónSocial = txtRazónSocialProveedor.Text;
                proveedorLocal.Cuit = Convert.ToInt64(txtCuitProveedor.Text);
                proveedorLocal.Teléfono = Convert.ToInt64(txtTelProveedor.Text);
                proveedorLocal.Celular = Convert.ToInt64(txtCelularProveedor.Text);
                proveedorLocal.Mail = txtMailProveedor.Text;
                proveedorLocal.Web = txtWebProveedor.Text;

                if (proveedorLocal.Id != 0)
                {
                    negocio.modificarProveedor(proveedorLocal);
                }
                else
                {
                    negocio.agregarProveedor(proveedorLocal);
                }

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarProveedor_Click(object sender, EventArgs e)
        {
            txtRazónSocialProveedor.Text = "";
            txtCuitProveedor.Text = "";
            txtTelProveedor.Text = "";
            txtCelularProveedor.Text = "";
            txtMailProveedor.Text = "";
            txtWebProveedor.Text = "";
        }

        private void DatosProveedor_Load(object sender, EventArgs e)
        {
            try
            {
                if (proveedorLocal != null)
                {
                    txtRazónSocialProveedor.Text = proveedorLocal.RazónSocial;
                    txtCuitProveedor.Text = proveedorLocal.Cuit.ToString();
                    txtTelProveedor.Text = proveedorLocal.Teléfono.ToString();
                    txtCelularProveedor.Text = proveedorLocal.Celular.ToString();
                    txtMailProveedor.Text = proveedorLocal.Mail;
                    txtWebProveedor.Text = proveedorLocal.Web;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
