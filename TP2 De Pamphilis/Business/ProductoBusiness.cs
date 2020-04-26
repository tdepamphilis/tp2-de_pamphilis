using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;


namespace Business
{
	public class ProductoBusiness
	{
		AccesoDatos accesoDatos = new AccesoDatos();
		//-----------------------LECTURA-------------------------
		
		// Lista todos los articulos , en donde range implica (0-2) indica si se filtra y search es la id del filtro a aplicar
		public List<Producto> listar(int range, int search)
		{
			List<Producto> lista = new List<Producto>();
			SqlConnection connection = new SqlConnection();
			SqlCommand command = new SqlCommand();
			SqlDataReader lector;

			try
			{
				connection.ConnectionString = accesoDatos.rutaDatos();
				command.CommandType = System.Data.CommandType.Text;
				switch (range)
				{
					case 0:
						command.CommandText = "select Nombre, Codigo, Descripcion, ImagenUrl, IdCategoria, IdMarca, Precio from ARTICULOS";
						break;
					case 1:
						command.CommandText = "select Nombre, Codigo, Descripcion, ImagenUrl, IdCategoria, IdMarca, Precio from ARTICULOS where IdCategoria =" + search;
						break;
					case 2:
						command.CommandText = "select Nombre, Codigo, Descripcion, ImagenUrl, IdCategoria, IdMarca, Precio from ARTICULOS where IdMarca =" + search;
						break;
				}
				command.Connection = connection;
				connection.Open();
				lector = command.ExecuteReader();
				while (lector.Read())
				{
					Producto aux = new Producto();
					aux.name = (string)lector["Nombre"];
					aux.code = (string)lector["Codigo"];
					aux.desc = (string)lector["Descripcion"];
					aux.imagen = (string)lector["ImagenUrl"];
					aux.idCategoria = (int)lector["IdCategoria"];
					aux.idMarca = (int)lector["IdMarca"];
					aux.precio = (decimal)lector["Precio"];
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

		public List<Producto> listarCriterio(string criterio, int range, int search)
		{
			List<Producto> lista = new List<Producto>();
			SqlConnection connection = new SqlConnection();
			SqlCommand command = new SqlCommand();
			SqlDataReader lector;
			try
			{
				connection.ConnectionString = accesoDatos.rutaDatos();
				command.CommandType = System.Data.CommandType.Text;
				switch (range)
				{
					case 0:
						command.CommandText = "select Nombre, Codigo, Descripcion, ImagenUrl, IdCategoria, IdMarca, Precio from ARTICULOS where Nombre like '%" + criterio + "%'";
						break;
					case 1:
						command.CommandText = "select Nombre, Codigo, Descripcion, ImagenUrl, IdCategoria, IdMarca, Precio from ARTICULOS where Nombre like '%" + criterio + "%' and Idcategoria = @search";
						break;
					case 2:
						command.CommandText = "select Nombre, Codigo, Descripcion, ImagenUrl, IdCategoria, IdMarca, Precio from ARTICULOS where Nombre like '%" + criterio + "%' and IdMarca = @search";
						break;
				}
				command.Parameters.AddWithValue("@search", search);
				command.Connection = connection;
				connection.Open();
				lector = command.ExecuteReader();
				while (lector.Read())
				{
					Producto aux = new Producto();
					aux.name = (string)lector["Nombre"];
					aux.code = (string)lector["Codigo"];
					aux.desc = (string)lector["Descripcion"];
					aux.imagen = (string)lector["ImagenUrl"];
					aux.idCategoria = (int)lector["IdCategoria"];
					aux.idMarca = (int)lector["IdMarca"];
					aux.precio = (decimal)lector["Precio"];
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

		//------------------ESCRITURA ----------------------------
		
		public void agregar(Producto producto)
		{
			SqlConnection connection = new SqlConnection();
			SqlCommand command = new SqlCommand();
			try
			{
				connection.ConnectionString = accesoDatos.rutaDatos();
				command.CommandType = System.Data.CommandType.Text;
				command.CommandText = "insert into ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio) " +
									  "values(@cod, @nombre, @desc, @marca, @cat, @imagen, @precio)";
				command.Parameters.AddWithValue("@cod", producto.code);
				command.Parameters.AddWithValue("@nombre",producto.name);
				command.Parameters.AddWithValue("@desc",producto.desc);
				command.Parameters.AddWithValue("@marca",producto.idMarca);
				command.Parameters.AddWithValue("@cat",producto.idCategoria);
				command.Parameters.AddWithValue("@imagen",producto.imagen);
				command.Parameters.AddWithValue("@precio",producto.precio);
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

		public void delete(string code)
		{
			SqlConnection connection = new SqlConnection();
			SqlCommand command = new SqlCommand();
			try
			{
				connection.ConnectionString = accesoDatos.rutaDatos();
				command.CommandType = System.Data.CommandType.Text;
				command.CommandText = "delete from ARTICULOS where Codigo = @cod";
									
				command.Parameters.AddWithValue("@cod",code);
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

		public void deleteCategoty(int idCategoria)
		{
			SqlConnection connection = new SqlConnection();
			SqlCommand command = new SqlCommand();
			try
			{
				connection.ConnectionString = accesoDatos.rutaDatos();
				command.CommandType = System.Data.CommandType.Text;
				command.CommandText = "delete from ARTICULOS where IdCategoria = @cod";

				command.Parameters.AddWithValue("@cod", idCategoria);
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

		public void deleteMarca(int idMarca)
		{
			SqlConnection connection = new SqlConnection();
			SqlCommand command = new SqlCommand();
			try
			{
				connection.ConnectionString = accesoDatos.rutaDatos();
				command.CommandType = System.Data.CommandType.Text;
				command.CommandText = "delete from ARTICULOS where IdMarca = @cod";

				command.Parameters.AddWithValue("@cod", idMarca);
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


		//-------------- Generacion de codigo----------------------
		private bool CheckCode(string code)
		{
			List<Producto> lista = new List<Producto>();
			SqlConnection connection = new SqlConnection();
			SqlCommand command = new SqlCommand();
			SqlDataReader lector;

			try
			{
				connection.ConnectionString = accesoDatos.rutaDatos();
				command.CommandType = System.Data.CommandType.Text;
				command.CommandText = "select Nombre, Codigo, Descripcion, ImagenUrl, IdCategoria, IdMarca, Precio from ARTICULOS";
				command.Connection = connection;
				connection.Open();
				lector = command.ExecuteReader();
				while (lector.Read())
				{
					Producto aux = new Producto();
					aux.code = (string)lector["Codigo"];
					lista.Add(aux);
				}
				connection.Close();


			}
			catch (Exception)
			{

				return false;
				throw;
			}

			foreach (Producto producto in lista)
			{
				if (producto.code == code)
				{
					return false;
				}

			}
			return true;

		}

		public string GenerateCode()
		{
			while(true)
			{
			var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			var stringChars = new Char[5];
			Random random = new Random();
			for(int i = 0; i < stringChars.Length; i++)
			{
				stringChars[i] = chars[random.Next(chars.Length)];
			}
			string result = new string(stringChars);
			
			if(CheckCode(result))
				{
					return result;

				}
			}
			

		}

	}
	
}
