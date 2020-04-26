using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Business
{
    public class AccesoDatos
    {
        public string rutaDatos()
        {

            string aux = System.Configuration.ConfigurationManager.AppSettings["ruta"];
            // return aux;
            return "data source = DESKTOP-9SD09P6\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi";

        }
    }
}
