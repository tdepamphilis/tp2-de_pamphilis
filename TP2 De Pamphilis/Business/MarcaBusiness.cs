using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
namespace Business
{
    public class MarcaBusiness
    {
        public Marca buscar(int id)
        {
            Marca marca = new Marca();
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader lector;
            try
            {
                connection.ConnectionString = "data source = DESKTOP-9SD09P6\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi ";
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select Descripcion, Id from Marcas where Id = @numero";
                command.Parameters.AddWithValue("@numero", id);
                command.Connection = connection;
                connection.Open();
                lector = command.ExecuteReader();
                lector.Read();
                marca.code = (int)lector["Id"];
                marca.name = (string)lector["Descripcion"];
                connection.Close();
                return marca;
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        public List<Marca> listar()
        {
            List<Marca> list = new List<Marca>();
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader lector;
            try
            {
                connection.ConnectionString = "data source = DESKTOP-9SD09P6\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi ";
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select Descripcion, Id from Marcas";
                command.Connection = connection;
                connection.Open();
                lector = command.ExecuteReader();
                while(lector.Read())
                {
                    Marca aux = new Marca();
                    aux.code = (int)lector["Id"];
                    aux.name = (string)lector["Descripcion"];
                    list.Add(aux);
                }

                connection.Close();
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
