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
        int tipo;
        public NuevaCategoria(int tipo)
        {
            this.tipo = tipo;
            if (tipo == 0)
                this.Text = "Nueva categoria";
            else if (tipo == 1)
                this.Text = "Nueva marca";
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
            MarcaBusiness marcaBusiness = new MarcaBusiness();
            if (textBox1.Text != "")
            {
                if (tipo == 0)
                    categoriaBusiness.add(textBox1.Text);
                else if (tipo == 1)
                    marcaBusiness.add(textBox1.Text);

                this.Close();
            }
            else
                MessageBox.Show("Agregue nombre");
        
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


}
