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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            cargarGrilla();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            DatosCliente ventana1 = new DatosCliente();
            ventana1.ShowDialog();
            DireccionCliente ventana2 = new DireccionCliente();
            ventana2.ShowDialog();
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            ClienteNegocio Cliente = new ClienteNegocio();
            try
            {
                dgvClientes.DataSource = Cliente.ListarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                DatosCliente modificar1 = new DatosCliente((Cliente)dgvClientes.CurrentRow.DataBoundItem);
                modificar1.ShowDialog();
                DireccionCliente modificar2 = new DireccionCliente((Cliente)dgvClientes.CurrentRow.DataBoundItem);
                modificar2.ShowDialog();
                cargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
