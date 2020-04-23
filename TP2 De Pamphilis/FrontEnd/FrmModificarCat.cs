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
        public FrmModificarCat()
        {
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
            update();
        }
    //------------------CARGA-------------------------------
        private void startslider()
        {
            CategoriaBusiness categoriaBusiness = new CategoriaBusiness();
            comboBox1.DataSource = categoriaBusiness.listar();
        }
    //----------------PROCESO------------------------
        
        private void update()
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

    }
}
