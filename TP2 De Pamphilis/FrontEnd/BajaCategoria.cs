using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Dominio;

namespace FrontEnd
{
    public partial class BajaCategoria : Form
    {
        int tipo;
        public BajaCategoria(int tipo)
        {
            this.tipo = tipo;
            if (tipo == 0)
                this.Text = "Eliminar categoria";
            else if (tipo == 1)
                this.Text = "Eliminar marca";
            InitializeComponent();
        }

       //---------------EVENTOS-----------------
        private void BajaCategoria_Load(object sender, EventArgs e)
        {
            startSlider();
        }
        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            if(tipo == 0)
            {
                deleteCategoria();
            } else if(tipo == 1)
            {
                deleteMarca();
            }
            this.Close();
                

            
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
    //-----------------CARGA----------------
        private void startSlider()
        {
            CategoriaBusiness categoriaBusiness = new CategoriaBusiness();
            MarcaBusiness marcaBusiness = new MarcaBusiness();
            if (tipo == 0)
                comboBox_Cat.DataSource = categoriaBusiness.listar();
            else if(tipo == 1)
                comboBox_Cat.DataSource = marcaBusiness.listar();
        }

        private void deleteCategoria()
        {
            
            CategoriaBusiness categoriaBusiness = new CategoriaBusiness();
            ProductoBusiness productoBusiness = new ProductoBusiness();
            Categoria categoria = (Categoria)comboBox_Cat.SelectedItem;            
            List<Producto> lista = productoBusiness.listar(1, categoria.code);
            var result = MessageBox.Show("hay " + lista.Count + " productos en la categoria, si acepta los eliminara tambien", "Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                productoBusiness.deleteCategoty(categoria.code);
                categoriaBusiness.delete(categoria.code);
                
            } else
            {
                this.Close();
            }

        }

        private void deleteMarca()
        {
            MarcaBusiness marcaBusiness = new MarcaBusiness();
            ProductoBusiness productoBusiness = new ProductoBusiness();
            Marca marca = (Marca)comboBox_Cat.SelectedItem;
            List<Producto> lista = productoBusiness.listar(2, marca.code);
            var result = MessageBox.Show("hay " + lista.Count + " productos en la marca, si acepta los eliminara tambien", "Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                productoBusiness.deleteMarca(marca.code);
                marcaBusiness.delete(marca.code);

            }
            else
            {
                this.Close();
            }

        }
    
    }
}
