using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Business
{
    public class AccesoDatos
    {
        public string rutaDatos()
        {

            string aux = System.Configuration.ConfigurationManager.AppSettings["ruta"];
            return aux;
            


        }

        public SqlConnection connection()
        {
            SqlConnection aux = new SqlConnection();
            aux.ConnectionString = System.Configuration.ConfigurationManager.AppSettings["ruta"];
            return aux;


        }
    }
}
