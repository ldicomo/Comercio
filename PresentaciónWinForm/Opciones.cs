using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentaciónWinForm
{
    public partial class Opciones : Form
    {
        public Opciones()
        {
            InitializeComponent();
        }

        private void tsmiProveedores_Click(object sender, EventArgs e)
        {
            Proveedores ventana1 = new Proveedores();
            ventana1.Show();
        }

        private void tsmiClientes_Click(object sender, EventArgs e)
        {
            Clientes ventana1 = new Clientes();
            ventana1.Show();
        }

        private void tsmiProductos_Click(object sender, EventArgs e)
        {
            Productos ventana1 = new Productos();
            ventana1.Show();
        }

        private void Opciones_Load(object sender, EventArgs e)
        {

        }
    }
}
