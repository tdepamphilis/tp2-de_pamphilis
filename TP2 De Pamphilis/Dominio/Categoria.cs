using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dominio
{
    public class Categoria
    {

        

        public int code { get; set; }
        public string name { get; set; }

        public Categoria()
        {
            code = -1;
            name = "No encontrado";
        }
        
        public override string ToString()
        {
            return name;
        }

    }
}
