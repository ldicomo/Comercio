using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public int Id { set; get; }
        public string Descripción { set; get; }
        public string Tipo { set; get; }
        public string Marca { set; get; }
        public int Stock { set; get; }
        public int StockMínimo { set; get; }
        public decimal PrecioCompra { set; get; }
        public decimal PrecioVenta { set; get; }
        public decimal Porcentaje { set; get; }
    }
}
