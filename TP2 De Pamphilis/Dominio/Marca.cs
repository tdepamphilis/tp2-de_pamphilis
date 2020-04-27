using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        public int code { get; set; }
        public String name { get; set; }

        public Marca()
        {
            code = -1;
            name = "no encontrado";
        }

        public override string ToString()
        {
            return name;
        }
    }
}
