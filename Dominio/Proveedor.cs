using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Proveedor
    {
        public int Id { set; get; }
        public string RazónSocial { set; get; }
        public long Cuit { set; get; }
        public long Teléfono { set; get; }
        public long Celular { set; get; }
        public string Mail { set; get; }
        public string Web { set; get; }
        public string Calle { set; get; }
        public int Número { set; get; }
        public int Piso { set; get; }
        public string Departamento { set; get; }
        public string Localidad { set; get; }
        public int CódigoPostal { set; get; }
    }
}
