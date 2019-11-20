using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public long Dni { set; get; }
        public string FechaNacimiento { set; get; }
        public long Teléfono { set; get; }
        public long Celular { set; get; }
        public string Mail { set; get; }
        public string Calle { set; get; }
        public int Número { set; get; }
        public int Piso { set; get; }
        public string Departamento { set; get; }
        public string Localidad { set; get; }
        public int CódigoPostal { set; get; }
    }
}
