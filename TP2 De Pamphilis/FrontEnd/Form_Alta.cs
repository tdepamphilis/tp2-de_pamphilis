using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Business;

namespace FrontEnd
{
    public partial class Form_Alta : Form
    {
        private Producto producto;
        bool esAlta;
        //-------------CONSTRUCTORES---------------------------
        public Form_Alta()
        {
            InitializeComponent();
            producto = new Producto();
            esAlta = true;
            this.Text = "Nuevo producto";
            

            
            
        }

        public Form_Alta(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            esAlta = false;
            this.Text = "Modificar producto";

        }

        //-------------------EVENTOS-------------------------------
        private void Form_Alta_Load(object sender, EventArgs e)
        {
            LoadSliders();
            if (esAlta)
                GenerateCode();
            else
                cargarCampos();


          
        }


        private void button_Aceptar_Click(object sender, EventArgs e)
        {

            alta();
            
        }

        // --------------------VALIDACIONES------------------------------------
     
        private void textBox_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox_Name.Text == "" && e.KeyChar == 32)
                e.Handled = true;
        }

        private void textBox_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            } else if(!(e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 32)
            {
                e.Handled = true;
            }

        }

        private void textBox_Imagen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox_Name.Text == "" && e.KeyChar == 32)
                e.Handled = true;
        }

        private void textBox_Desc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox_Name.Text == "" && e.KeyChar == 32)
                e.Handled = true;
        }
    
        //-----------------FUNCIONES DE CARGA--------------------------------
        private void LoadSliders()
        {
            MarcaBusiness marcaBusiness = new MarcaBusiness();
            CategoriaBusiness categoriabusiness = new CategoriaBusiness();
            comboBox_Categoria.DataSource = categoriabusiness.listar();
            comboBox_Marca.DataSource = marcaBusiness.listar();
        }
        private void GenerateCode()
        {
            ProductoBusiness productoBusiness = new ProductoBusiness();
            textBox_Code.Text = productoBusiness.GenerateCode();
        }


        private void cargarCampos()
        {
            
            textBox_Name.Text = producto.name;
            textBox_Desc.Text = producto.desc;
            textBox_Precio.Text = producto.precio.ToString();
            textBox_Imagen.Text = producto.imagen;
            textBox_Code.Text = producto.code;
            
            comboBox_Categoria.SelectedIndex = producto.idCategoria - 1;
            comboBox_Marca.SelectedIndex = producto.idMarca - 1;
        }

        //----------------PROCESOS----------------------------------------

        private void alta()
        {
            if (!(textBox_Name.Text == "" || textBox_Desc.Text == "" || textBox_Name.Text == "" || textBox_Imagen.Text == "" || textBox_Precio.Text == ""))
            {
                ProductoBusiness productoBusiness = new ProductoBusiness();
                Categoria categoria;
                Marca marca;

                decimal auxprice;
                decimal.TryParse(textBox_Precio.Text, out auxprice);
                producto.desc = textBox_Desc.Text;
                producto.name = textBox_Name.Text;
                producto.imagen = textBox_Imagen.Text;
                producto.code = textBox_Code.Text;
                producto.precio = auxprice;
                categoria = (Categoria)comboBox_Categoria.SelectedItem;
                producto.idCategoria = categoria.code;
                marca = (Marca)comboBox_Marca.SelectedItem;
                producto.idMarca = marca.code;

                if (!esAlta)
                    productoBusiness.delete(producto.code);
                productoBusiness.agregar(producto);

                
                Close();


            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos");
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
