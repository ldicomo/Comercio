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
    public partial class DireccionCliente : Form
    {
        private Cliente clienteLocal = null;

        public DireccionCliente()
        {
            InitializeComponent();
        }

        public DireccionCliente(Cliente cliente)
        {
            InitializeComponent();
            clienteLocal = cliente;
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

        private void txtCódigoPostalDirección_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnAceptarDirección_Click(object sender, EventArgs e)
        {
            ClienteNegocio negocio1 = new ClienteNegocio();
            try
            {
                if (clienteLocal == null)
                    clienteLocal = new Cliente();

                clienteLocal.Calle = txtCalleDirección.Text;
                clienteLocal.Número = Convert.ToInt32(txtNúmeroDirección.Text);
                clienteLocal.Piso = Convert.ToInt32(txtPisoDirección.Text);
                clienteLocal.Departamento = txtDepartamentoDirección.Text;
                clienteLocal.Localidad = txtLocalidadDirección.Text;
                clienteLocal.CódigoPostal = Convert.ToInt32(txtCódigoPostalDirección.Text);

                if (clienteLocal.Id != 0)
                {
                    negocio1.modificarDirección(clienteLocal);
                }
                else
                {
                    negocio1.agregarDirección(clienteLocal);
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

        private void Dirección_Load(object sender, EventArgs e)
        {
            try
            {
                if (clienteLocal != null)
                {
                    txtCalleDirección.Text = clienteLocal.Calle;
                    txtNúmeroDirección.Text = clienteLocal.Número.ToString();
                    txtPisoDirección.Text = clienteLocal.Piso.ToString();
                    txtDepartamentoDirección.Text = clienteLocal.Departamento;
                    txtLocalidadDirección.Text = clienteLocal.Localidad;
                    txtCódigoPostalDirección.Text = clienteLocal.CódigoPostal.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtCalleDirección_TextChanged(object sender, EventArgs e)
        {

        }

        private void labNúmeroDirección_Click(object sender, EventArgs e)
        {

        }

        private void txtNúmeroDirección_TextChanged(object sender, EventArgs e)
        {

        }

        private void labPisoDirección_Click(object sender, EventArgs e)
        {

        }

        private void txtPisoDirección_TextChanged(object sender, EventArgs e)
        {

        }

        private void labDepartamentoDirección_Click(object sender, EventArgs e)
        {

        }

        private void txtDepartamentoDirección_TextChanged(object sender, EventArgs e)
        {

        }

        private void labLocalidadDirección_Click(object sender, EventArgs e)
        {

        }

        private void txtLocalidadDirección_TextChanged(object sender, EventArgs e)
        {

        }

        private void labCódigoPostalDirección_Click(object sender, EventArgs e)
        {

        }

        private void txtCódigoPostalDirección_TextChanged(object sender, EventArgs e)
        {

        }

        private void labCalleDirección_Click(object sender, EventArgs e)
        {

        }
    }
}
