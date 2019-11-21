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
    public partial class Contactos : Form
    {
        private Contacto contactoLocal = null;
        int pos;

        public Contactos()
        {
            InitializeComponent();
        }

        public Contactos(Contacto contacto)
        {
            InitializeComponent();
            contactoLocal = contacto;
        }

        private void Contactos_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void txtIdProveedorContacto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNúmeroContacto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNombreContacto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtApellidoContacto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTelContacto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCelularContacto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtMailContacto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dgvContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se posiciona en la fila actual.
            pos = dgvContactos.CurrentRow.Index;
            txtIdProveedorContacto.Text = dgvContactos[0, pos].Value.ToString();
            txtNúmeroContacto.Text = dgvContactos[1, pos].Value.ToString();
            txtNombreContacto.Text = dgvContactos[2, pos].Value.ToString();
            txtApellidoContacto.Text = dgvContactos[3, pos].Value.ToString();
            txtTelContacto.Text = dgvContactos[4, pos].Value.ToString();
            txtCelularContacto.Text = dgvContactos[5, pos].Value.ToString();
            txtMailContacto.Text = dgvContactos[6, pos].Value.ToString();
        }

        private void btnCancelarContacto_Click(object sender, EventArgs e)
        {
            txtIdProveedorContacto.Text = "";
            txtNúmeroContacto.Text = "";
            txtNombreContacto.Text = "";
            txtApellidoContacto.Text = "";
            txtTelContacto.Text = "";
            txtCelularContacto.Text = "";
            txtMailContacto.Text = "";
        }

        private void btnModificarContacto_Click(object sender, EventArgs e)
        {
            dgvContactos[0, pos].Value = txtIdProveedorContacto.Text;
            dgvContactos[1, pos].Value = txtNúmeroContacto.Text;
            dgvContactos[2, pos].Value = txtNombreContacto.Text;
            dgvContactos[3, pos].Value = txtApellidoContacto.Text;
            dgvContactos[4, pos].Value = txtTelContacto.Text;
            dgvContactos[5, pos].Value = txtCelularContacto.Text;
            dgvContactos[6, pos].Value = txtMailContacto.Text;

            ContactoNegocio negocio = new ContactoNegocio();
            try
            {
                contactoLocal = new Contacto();
                contactoLocal.Id_Proveedor = Convert.ToInt32(txtIdProveedorContacto.Text);
                contactoLocal.Número = txtNúmeroContacto.Text;
                contactoLocal.Nombre = txtNombreContacto.Text;
                contactoLocal.Apellido = txtApellidoContacto.Text;
                contactoLocal.Teléfono = Convert.ToInt64(txtTelContacto.Text);
                contactoLocal.Celular = Convert.ToInt64(txtCelularContacto.Text);
                contactoLocal.Mail = txtMailContacto.Text;

                negocio.modificarContacto(contactoLocal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarContacto_Click(object sender, EventArgs e)
        {
            ContactoNegocio negocio = new ContactoNegocio();
            try
            {
                contactoLocal = new Contacto();
                contactoLocal.Id_Proveedor = Convert.ToInt32(txtIdProveedorContacto.Text);
                contactoLocal.Número = txtNúmeroContacto.Text;
                contactoLocal.Nombre = txtNombreContacto.Text;
                contactoLocal.Apellido = txtApellidoContacto.Text;
                contactoLocal.Teléfono = Convert.ToInt64(txtTelContacto.Text);
                contactoLocal.Celular = Convert.ToInt64(txtCelularContacto.Text);
                contactoLocal.Mail = txtMailContacto.Text;

                negocio.agregarContacto(contactoLocal);
                cargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarGrilla()
        {
            ContactoNegocio contactos = new ContactoNegocio();
            try
            {
                dgvContactos.DataSource = contactos.ListarContactos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
