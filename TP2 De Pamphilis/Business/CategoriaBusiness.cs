using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Business
{
    public class CategoriaBusiness
    {
     
        //-------------LECTURA----------------- 
        public Categoria buscar(int id)
        {
            Categoria categoria;
            categoria = new Categoria();
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader lector;
            try
            {
                connection.ConnectionString = "data source = DESKTOP-9SD09P6\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi ";
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select Descripcion, Id from CATEGORIAS where Id = @numero ";
                command.Parameters.AddWithValue("@numero", id);
                command.Connection = connection;
                connection.Open();
                lector = command.ExecuteReader();
                lector.Read();
                categoria.code = (int)lector["Id"];
                categoria.name = (string)lector["Descripcion"];
                connection.Close();
                return categoria;


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader lector;
            try
            {
                connection.ConnectionString = "data source = DESKTOP-9SD09P6\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi ";
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select Descripcion, Id from Categorias";
                command.Connection = connection;
                connection.Open();
                lector = command.ExecuteReader();
                while (lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.code = (int)lector["Id"];
                    aux.name = (string)lector["Descripcion"];
                    lista.Add(aux);
                }
                connection.Close();
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        
        //-------------ESCRITURA-------------

        public void delete(int id)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            try
            {
                connection.ConnectionString = "data source = DESKTOP-9SD09P6\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi ";
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "delete from CATEGORIAS where Id = @cod";

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
                connection.ConnectionString = "data source = DESKTOP-9SD09P6\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi ";
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "insert into CATEGORIAS values (@name)";
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
                connection.ConnectionString = "data source = DESKTOP-9SD09P6\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi ";
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE CATEGORIAS set descripcion = @name where Id = @code";
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
