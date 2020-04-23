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
        public BajaCategoria()
        {
            InitializeComponent();
        }

       //---------------EVENTOS-----------------
        private void BajaCategoria_Load(object sender, EventArgs e)
        {
            startSlider();
        }
        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            delete();
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
    //-----------------CARGA----------------
        private void startSlider()
        {
            CategoriaBusiness categoriaBusiness = new CategoriaBusiness();
            comboBox_Cat.DataSource = categoriaBusiness.listar();

        }

        private void delete()
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

    }
}
