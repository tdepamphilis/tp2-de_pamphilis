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


        }

        private void LoadSliders()
        {
            MarcaBusiness marcaBusiness = new MarcaBusiness();
            CategoriaBusiness categoriabusiness = new CategoriaBusiness();
            comboBox_Categoria.DataSource = categoriabusiness.listar();
            comboBox_Marca.DataSource = marcaBusiness.listar();
        }
    }
}
