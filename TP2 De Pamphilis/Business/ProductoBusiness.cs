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
        // Lista todos los articulos , en donde range implica (0-2) indica si se filtra y search es la id del filtro a aplicar
		public List<Producto> listar(int range, int search)
        {
			List<Producto> lista = new List<Producto>();
			SqlConnection connection = new SqlConnection();
			SqlCommand command = new SqlCommand();
			SqlDataReader lector;
			
			try
			{
				connection.ConnectionString = "data source = DESKTOP-9SD09P6\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi ";
				command.CommandType = System.Data.CommandType.Text;
				switch(range)
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
				while(lector.Read())
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
				connection.ConnectionString = "data source = DESKTOP-9SD09P6\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi ";
				command.CommandType = System.Data.CommandType.Text;				
				switch(range)
				{
					case 0:
						command.CommandText = "select Nombre, Codigo, Descripcion, ImagenUrl, IdCategoria, IdMarca, Precio from ARTICULOS where Nombre like '%" +criterio+ "%'";
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

	}
}
