using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public string code { get; set; }
        public string name { get; set; }
        public int idMarca { get; set; }
        public int idCategoria { get; set; }
        public string imagen { get; set; }
        public decimal precio { get; set; }
        public string desc { get; set; }

    }
}
