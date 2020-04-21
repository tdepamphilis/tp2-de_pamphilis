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
        public Form_Alta()
        {
            InitializeComponent();
        }

        private void Form_Alta_Load(object sender, EventArgs e)
        {
            LoadSliders();

        }


        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            if (!(textBox_Name.Text == "" || textBox_Desc.Text == "" || textBox_Name.Text == "" || textBox_Imagen.Text == "" || textBox_Precio.Text == ""))
            {
                Producto producto = new Producto();
                decimal auxprice;
                decimal.TryParse(textBox_Precio.Text, out auxprice);
                producto.desc = textBox_Desc.Text;
                producto.name = textBox_Name.Text;
                producto.imagen = textBox_Imagen.Text;
                producto.precio = auxprice;
                producto.idCategoria = comboBox_Categoria.SelectedIndex;
                producto.idMarca = comboBox_Marca.SelectedIndex;
                



            } else
            {
                MessageBox.Show("Por favor complete todos los campos");
            }
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



    }
}
