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
    public partial class DatosCliente : Form
    {
        private Cliente clienteLocal = null;

        public DatosCliente()
        {
            InitializeComponent();
        }

        public DatosCliente(Cliente cliente)
        {
            InitializeComponent();
            clienteLocal = cliente;
        }

        private void txtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Valida solo letras, backspace y espacio.
            if (!(e.KeyChar > 64 && e.KeyChar < 91) && !(e.KeyChar > 96 && e.KeyChar < 123)
                && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;
        }

        private void txtApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Valida solo letras, backspace y espacio.
            if (!(e.KeyChar > 64 && e.KeyChar < 91) && !(e.KeyChar > 96 && e.KeyChar < 123)
                && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;
        }

        private void txtDniCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtFechaNacimientoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTelCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCelularCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtMailCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnAceptarCliente_Click(object sender, EventArgs e)
        {
            ClienteNegocio negocio = new ClienteNegocio();
            try
            {
                if (clienteLocal == null)
                    clienteLocal = new Cliente();

                clienteLocal.Nombre = txtNombreCliente.Text;
                clienteLocal.Apellido = txtApellidoCliente.Text;
                clienteLocal.Dni = Convert.ToInt64(txtDniCliente.Text);
                clienteLocal.FechaNacimiento = txtFechaNacimientoCliente.Text;
                clienteLocal.Teléfono = Convert.ToInt64(txtTelCliente.Text);
                clienteLocal.Celular = Convert.ToInt64(txtCelularCliente.Text);
                clienteLocal.Mail = txtMailCliente.Text;

                if (clienteLocal.Id != 0)
                {
                    negocio.modificarCliente(clienteLocal);
                }
                else
                {
                    negocio.agregarCliente(clienteLocal);
                }

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            txtNombreCliente.Text = "";
            txtApellidoCliente.Text = "";
            txtDniCliente.Text = "";
            txtTelCliente.Text = "";
            txtCelularCliente.Text = "";
            txtMailCliente.Text = "";
        }

        private void DatosCliente_Load(object sender, EventArgs e)
        {
            try
            {
                if (clienteLocal != null)
                {
                    txtNombreCliente.Text = clienteLocal.Nombre;
                    txtApellidoCliente.Text = clienteLocal.Apellido;
                    txtDniCliente.Text = clienteLocal.Dni.ToString();
                    txtFechaNacimientoCliente.Text = clienteLocal.FechaNacimiento;
                    txtTelCliente.Text = clienteLocal.Teléfono.ToString();
                    txtCelularCliente.Text = clienteLocal.Celular.ToString();
                    txtMailCliente.Text = clienteLocal.Mail;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
