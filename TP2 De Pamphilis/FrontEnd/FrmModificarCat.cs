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
    public partial class FrmModificarCat : Form
    {
        int tipo;
        public FrmModificarCat(int tipo)
        {
            this.tipo = tipo;
            if (tipo == 0)
                this.Text = "Modificar categoria";
            else if (tipo == 1)
                this.Text = "Modificar marca";
            InitializeComponent();
        }

        private void FrmModificarCat_Load(object sender, EventArgs e)
        {
            startslider();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Acept_Click(object sender, EventArgs e)
        {
            if (tipo == 0)
                updateCat();
            else if (tipo == 1)
                updateMarca();
        }
       
        //---------------VALIDACION---------------------------
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text == "" && e.KeyChar == 32)
                e.Handled = true;
        }
    //------------------CARGA-------------------------------
        private void startslider()
        {
            if(tipo == 0)
            {
            CategoriaBusiness categoriaBusiness = new CategoriaBusiness();
            comboBox1.DataSource = categoriaBusiness.listar();
            } else if (tipo == 1)
            {
                MarcaBusiness marcaBusiness = new MarcaBusiness();
                comboBox1.DataSource = marcaBusiness.listar();
            }
            
        }
    //----------------PROCESO------------------------
        
        private void updateCat()
        {
            Categoria categoria = (Categoria)comboBox1.SelectedItem;
            CategoriaBusiness categoriaBusiness = new CategoriaBusiness();
            if (textBox1.Text != "")
            {
                categoriaBusiness.modify(textBox1.Text, categoria.code);
                this.Close();
            }
            else
                MessageBox.Show("Escriba un nombre");
        }

        private void updateMarca()
        {
            Marca marca = (Marca)comboBox1.SelectedItem;
            MarcaBusiness marcaBusiness = new MarcaBusiness();
            if (textBox1.Text != "")
            {
                marcaBusiness.modify(textBox1.Text, marca.code);
                this.Close();
            }
            else
                MessageBox.Show("Escriba un nombre");
        }

    }
}
