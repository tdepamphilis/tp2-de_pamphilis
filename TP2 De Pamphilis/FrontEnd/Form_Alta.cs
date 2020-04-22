﻿using System;
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
        //-------------------EVENTOS-------------------------------
        private void Form_Alta_Load(object sender, EventArgs e)
        {
            LoadSliders();
            GenerateCode();

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

        //----------------PROCESOS----------------------------------------

        private void alta()
        {
            if (!(textBox_Name.Text == "" || textBox_Desc.Text == "" || textBox_Name.Text == "" || textBox_Imagen.Text == "" || textBox_Precio.Text == ""))
            {
                ProductoBusiness productoBusiness = new ProductoBusiness();
                Producto producto = new Producto();

                decimal auxprice;
                decimal.TryParse(textBox_Precio.Text, out auxprice);
                producto.desc = textBox_Desc.Text;
                producto.name = textBox_Name.Text;
                producto.imagen = textBox_Imagen.Text;
                producto.code = textBox_Code.Text;
                producto.precio = auxprice;
                producto.idCategoria = comboBox_Categoria.SelectedIndex +1;
                producto.idMarca = comboBox_Marca.SelectedIndex +1;

                productoBusiness.agregar(producto);

                
                Close();


            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos");
            }
        }
    }
}
