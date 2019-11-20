using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Compra
    {
        public string DetalleCompra { set; get; }
        public string Producto { set; get; }
        public decimal PrecioUnitario { set; get; }
        public int CantidadParcial { set; get; }
        public decimal Precio { set; get; }
    }
}
