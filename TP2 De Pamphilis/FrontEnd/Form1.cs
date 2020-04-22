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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Startgrid();
            StartFilter();

            
        }

        private void dataGridView_Main_SelectionChanged(object sender, EventArgs e)
        {
            UpdateInfo();

        }

        private void comboBox_FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }
        private void button_Filter_Click(object sender, EventArgs e)
        {
            FilterData();
        }
        private void button_Newproduct_Click(object sender, EventArgs e)
        {
            Form_Alta newform = new Form_Alta();
            newform.Show();
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Desea eliminar el producto?", "Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                delete();
                FilterData();
            }          
        }
        private void Form1_Enter(object sender, EventArgs e)
        {
            Startgrid();
        }
        
        //-----------------FUNCIONES DE CARGA-------------
        
        public void Startgrid()
        {
            // inicializa la tabla
            ProductoBusiness productoBusiness = new ProductoBusiness();
            dataGridView_Main.DataSource = productoBusiness.listar(0,0);
            dataGridView_Main.Columns[2].Visible = false;
            dataGridView_Main.Columns[3].Visible = false;
            dataGridView_Main.Columns[4].Visible = false;

        }
        
        private void StartFilter()
        {
            comboBox_FilterBy.Items.Add("-");
            comboBox_FilterBy.Items.Add("Categoria");
            comboBox_FilterBy.Items.Add("Marca");
            comboBox_FilterBy.SelectedIndex = 0;

        }

        private void UpdateInfo()
        {
            Producto producto;
            Marca marca;
            Categoria categoria;
            MarcaBusiness marcaBusiness = new MarcaBusiness();
            CategoriaBusiness categoriaBusiness = new CategoriaBusiness();
            // se instancia el producto seleccionado
            producto = (Producto)dataGridView_Main.CurrentRow.DataBoundItem;
            // se instancia la marca y categoria del producto seleccionado 
            marca = marcaBusiness.buscar(producto.idMarca);
            categoria = (Categoria)categoriaBusiness.buscar(producto.idCategoria);


            // Se escribe la info de las instancias
            textBox_desc.Text = "Categoria: " + categoria.name + Environment.NewLine +"Marca: " + marca.name + Environment.NewLine + "Descripcion: " + producto.desc;
            // pictureBox_Product.Load(producto.imagen);

        }

        private void UpdateFilter()
        {
            
            // Funcion que actualiza la lista desplegable de filtro -- FALTA AGREGAR CATEGORIAS
            if(comboBox_FilterBy.SelectedIndex == 0)
            {
                comboBox_Filter.DataSource = null;
            } else if(comboBox_FilterBy.SelectedIndex == 1)
            {
                CategoriaBusiness categoriaBusiness = new CategoriaBusiness();
                comboBox_Filter.DataSource = categoriaBusiness.listar();
            } else if(comboBox_FilterBy.SelectedIndex ==2)
            {
                MarcaBusiness marcaBusiness = new MarcaBusiness();
                comboBox_Filter.DataSource = marcaBusiness.listar();
            }
        }

        private void FilterData()
        {

            ProductoBusiness productoBusiness = new ProductoBusiness();
            
            if(comboBox_FilterBy.SelectedIndex == 0)
            {
                if(textBox_Search.Text == "")
                {
                    // se muestra todo
                    Startgrid();
                } else
                {
                    // Se muestra segun criterio
                    dataGridView_Main.DataSource = productoBusiness.listarCriterio(textBox_Search.Text,0,0);
                }
            } else if(comboBox_FilterBy.SelectedIndex == 1)
            {
                if(textBox_Search.Text == "")
                {
                    // se muestran todos los de la categoria
                    dataGridView_Main.DataSource = productoBusiness.listar(1, comboBox_Filter.SelectedIndex +1);
                } else
                {
                    // se busca segun criterio en la categoria
                    dataGridView_Main.DataSource = productoBusiness.listarCriterio(textBox_Search.Text, 1, comboBox_Filter.SelectedIndex + 1);
                }
            } else if(comboBox_FilterBy.SelectedIndex == 2)
            {
                if(textBox_Search.Text == "")
                {
                    // Se buscan todos los de la marca
                    dataGridView_Main.DataSource = productoBusiness.listar(2, comboBox_Filter.SelectedIndex +1);
                } else
                {
                    // Se busca segun criterio en la Marca
                    dataGridView_Main.DataSource = productoBusiness.listarCriterio(textBox_Search.Text, 2, comboBox_Filter.SelectedIndex + 1);
                }

            }
        }

        //-------------Operacines---------------------
        private void delete()
        {
            Producto producto;
            ProductoBusiness productoBusiness = new ProductoBusiness();
            producto = (Producto)dataGridView_Main.CurrentRow.DataBoundItem;
            productoBusiness.delete(producto.code);

        }

    }
}
