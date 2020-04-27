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
        AccesoDatos accesoDatos = new AccesoDatos();
        //------------LECTURA-------------
        public Marca buscar(int id)
        {
            Marca marca = new Marca();
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader lector;
            try
            {
                connection.ConnectionString = accesoDatos.rutaDatos();
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

                return marca;
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
                connection.ConnectionString = accesoDatos.rutaDatos();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select Descripcion, Id from Marcas";
                command.Connection = connection;
                connection.Open();
                lector = command.ExecuteReader();
                while (lector.Read())
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

        //------------ESCRITURA-------------
        public void delete(int id)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            try
            {
                connection.ConnectionString = accesoDatos.rutaDatos();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "delete from MARCAS where Id = @cod";

                command.Parameters.AddWithValue("@cod", id);
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public void add(string name)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            try
            {
                connection.ConnectionString = accesoDatos.rutaDatos();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "insert into MARCAS values (@name)";
                command.Parameters.AddWithValue("@name", name);
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        
        public void modify(string name, int id)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            try
            {
                connection.ConnectionString = accesoDatos.rutaDatos();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE MARCAS set descripcion = @name where Id = @code";
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@code", id);
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }




    }
    
}
