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
    public partial class Corredores : Form
    {
        private Corredor corredorLocal = null;
        int pos;

        public Corredores()
        {
            InitializeComponent();
        }

        public Corredores(Corredor corredor)
        {
            InitializeComponent();
            corredorLocal = corredor;
        }

        private void Corredores_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void txtIdProveedorCorredor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNúmeroCorredor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNombreCorredor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtApellidoCorredor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTelCorredor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCelularCorredor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtMailCorredor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dgvCorredor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se posiciona en la fila actual.
            pos = dgvCorredor.CurrentRow.Index;
            txtIdProveedorCorredor.Text = dgvCorredor[0, pos].Value.ToString();
            txtNúmeroCorredor.Text = dgvCorredor[1, pos].Value.ToString();
            txtNombreCorredor.Text = dgvCorredor[2, pos].Value.ToString();
            txtApellidoCorredor.Text = dgvCorredor[3, pos].Value.ToString();
            txtTelCorredor.Text = dgvCorredor[4, pos].Value.ToString();
            txtCelularCorredor.Text = dgvCorredor[5, pos].Value.ToString();
            txtMailCorredor.Text = dgvCorredor[6, pos].Value.ToString();
        }

        private void btnCancelarCorredor_Click(object sender, EventArgs e)
        {
            txtIdProveedorCorredor.Text = "";
            txtNúmeroCorredor.Text = "";
            txtNombreCorredor.Text = "";
            txtApellidoCorredor.Text = "";
            txtTelCorredor.Text = "";
            txtCelularCorredor.Text = "";
            txtMailCorredor.Text = "";
        }

        private void btnModificarCorredor_Click(object sender, EventArgs e)
        {
            dgvCorredor[0, pos].Value = txtIdProveedorCorredor.Text;
            dgvCorredor[1, pos].Value = txtNúmeroCorredor.Text;
            dgvCorredor[2, pos].Value = txtNombreCorredor.Text;
            dgvCorredor[3, pos].Value = txtApellidoCorredor.Text;
            dgvCorredor[4, pos].Value = txtTelCorredor.Text;
            dgvCorredor[5, pos].Value = txtCelularCorredor.Text;
            dgvCorredor[6, pos].Value = txtMailCorredor.Text;

            CorredorNegocio negocio = new CorredorNegocio();
            try
            {
                corredorLocal = new Corredor();
                corredorLocal.Id_Proveedor = Convert.ToInt32(txtIdProveedorCorredor.Text);
                corredorLocal.Número = txtNúmeroCorredor.Text;
                corredorLocal.Nombre = txtNombreCorredor.Text;
                corredorLocal.Apellido = txtApellidoCorredor.Text;
                corredorLocal.Teléfono = Convert.ToInt64(txtTelCorredor.Text);
                corredorLocal.Celular = Convert.ToInt64(txtCelularCorredor.Text);
                corredorLocal.Mail = txtMailCorredor.Text;

                negocio.modificarCorredor(corredorLocal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarCorredor_Click(object sender, EventArgs e)
        {
            CorredorNegocio negocio = new CorredorNegocio();
            try
            {
                corredorLocal = new Corredor();
                corredorLocal.Id_Proveedor = Convert.ToInt32(txtIdProveedorCorredor.Text);
                corredorLocal.Número = txtNúmeroCorredor.Text;
                corredorLocal.Nombre = txtNombreCorredor.Text;
                corredorLocal.Apellido = txtApellidoCorredor.Text;
                corredorLocal.Teléfono = Convert.ToInt64(txtTelCorredor.Text);
                corredorLocal.Celular = Convert.ToInt64(txtCelularCorredor.Text);
                corredorLocal.Mail = txtMailCorredor.Text;

                negocio.agregarCorredor(corredorLocal);
                cargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarGrilla()
        {
            CorredorNegocio Corredores = new CorredorNegocio();
            try
            {
                dgvCorredor.DataSource = Corredores.ListarCorredores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
