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
    public partial class NuevaCategoria : Form
    {
        public NuevaCategoria()
        {
            InitializeComponent();
        }


        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            aceptar();
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //--------VALIDACIONES-------------------


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (textBox1.Text == "" && e.KeyChar == 32)
                e.Handled = true;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
      
        //------------PROCESOS-----------------------
        private void aceptar()
        {
            CategoriaBusiness categoriaBusiness = new CategoriaBusiness();
            if (textBox1.Text != "")
                categoriaBusiness.add(textBox1.Text);
            else
                MessageBox.Show("Agregue nombre");
        
        
        }


    }


}
