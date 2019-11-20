using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {
        public int Id_Proveedor { set; get; }
        public string Número { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public long Teléfono { set; get; }
        public long Celular { set; get; }
        public string Mail { set; get; }
    }
}
