namespace FrontEnd
{
    partial class Form_Alta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.comboBox_Categoria = new System.Windows.Forms.ComboBox();
            this.comboBox_Marca = new System.Windows.Forms.ComboBox();
            this.textBox_Desc = new System.Windows.Forms.TextBox();
            this.textBox_Imagen = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Cat = new System.Windows.Forms.Label();
            this.label_Marca = new System.Windows.Forms.Label();
            this.label_Url = new System.Windows.Forms.Label();
            this.label_Desc = new System.Windows.Forms.Label();
            this.button_Aceptar = new System.Windows.Forms.Button();
            this.textBox_Precio = new System.Windows.Forms.TextBox();
            this.label_Price = new System.Windows.Forms.Label();
            this.label_Code = new System.Windows.Forms.Label();
            this.textBox_Code = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(111, 29);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(196, 20);
            this.textBox_Name.TabIndex = 0;
            this.textBox_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Name_KeyPress);
            // 
            // comboBox_Categoria
            // 
            this.comboBox_Categoria.FormattingEnabled = true;
            this.comboBox_Categoria.Location = new System.Drawing.Point(111, 64);
            this.comboBox_Categoria.Name = "comboBox_Categoria";
            this.comboBox_Categoria.Size = new System.Drawing.Size(127, 21);
            this.comboBox_Categoria.TabIndex = 1;
            // 
            // comboBox_Marca
            // 
            this.comboBox_Marca.FormattingEnabled = true;
            this.comboBox_Marca.Location = new System.Drawing.Point(111, 101);
            this.comboBox_Marca.Name = "comboBox_Marca";
            this.comboBox_Marca.Size = new System.Drawing.Size(138, 21);
            this.comboBox_Marca.TabIndex = 2;
            // 
            // textBox_Desc
            // 
            this.textBox_Desc.Location = new System.Drawing.Point(111, 220);
            this.textBox_Desc.Multiline = true;
            this.textBox_Desc.Name = "textBox_Desc";
            this.textBox_Desc.Size = new System.Drawing.Size(230, 69);
            this.textBox_Desc.TabIndex = 3;
            this.textBox_Desc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Desc_KeyPress);
            // 
            // textBox_Imagen
            // 
            this.textBox_Imagen.Location = new System.Drawing.Point(111, 184);
            this.textBox_Imagen.Name = "textBox_Imagen";
            this.textBox_Imagen.Size = new System.Drawing.Size(230, 20);
            this.textBox_Imagen.TabIndex = 4;
            this.textBox_Imagen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Imagen_KeyPress);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(28, 32);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(57, 13);
            this.label_Name.TabIndex = 5;
            this.label_Name.Text = "NOMBRE:";
            // 
            // label_Cat
            // 
            this.label_Cat.AutoSize = true;
            this.label_Cat.Location = new System.Drawing.Point(28, 72);
            this.label_Cat.Name = "label_Cat";
            this.label_Cat.Size = new System.Drawing.Size(72, 13);
            this.label_Cat.TabIndex = 6;
            this.label_Cat.Text = "CATEGORIA:";
            // 
            // label_Marca
            // 
            this.label_Marca.AutoSize = true;
            this.label_Marca.Location = new System.Drawing.Point(28, 109);
            this.label_Marca.Name = "label_Marca";
            this.label_Marca.Size = new System.Drawing.Size(48, 13);
            this.label_Marca.TabIndex = 7;
            this.label_Marca.Text = "MARCA:";
            // 
            // label_Url
            // 
            this.label_Url.AutoSize = true;
            this.label_Url.Location = new System.Drawing.Point(28, 184);
            this.label_Url.Name = "label_Url";
            this.label_Url.Size = new System.Drawing.Size(72, 13);
            this.label_Url.TabIndex = 8;
            this.label_Url.Text = "Url de imagen";
            // 
            // label_Desc
            // 
            this.label_Desc.AutoSize = true;
            this.label_Desc.Location = new System.Drawing.Point(22, 223);
            this.label_Desc.Name = "label_Desc";
            this.label_Desc.Size = new System.Drawing.Size(83, 13);
            this.label_Desc.TabIndex = 9;
            this.label_Desc.Text = "DESCRIPCION:";
            // 
            // button_Aceptar
            // 
            this.button_Aceptar.Location = new System.Drawing.Point(210, 361);
            this.button_Aceptar.Name = "button_Aceptar";
            this.button_Aceptar.Size = new System.Drawing.Size(131, 32);
            this.button_Aceptar.TabIndex = 10;
            this.button_Aceptar.Text = "Aceptar";
            this.button_Aceptar.UseVisualStyleBackColor = true;
            this.button_Aceptar.Click += new System.EventHandler(this.button_Aceptar_Click);
            // 
            // textBox_Precio
            // 
            this.textBox_Precio.Location = new System.Drawing.Point(111, 145);
            this.textBox_Precio.Name = "textBox_Precio";
            this.textBox_Precio.Size = new System.Drawing.Size(118, 20);
            this.textBox_Precio.TabIndex = 11;
            this.textBox_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Precio_KeyPress);
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Location = new System.Drawing.Point(39, 152);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(37, 13);
            this.label_Price.TabIndex = 12;
            this.label_Price.Text = "Precio";
            // 
            // label_Code
            // 
            this.label_Code.AutoSize = true;
            this.label_Code.Location = new System.Drawing.Point(36, 326);
            this.label_Code.Name = "label_Code";
            this.label_Code.Size = new System.Drawing.Size(40, 13);
            this.label_Code.TabIndex = 13;
            this.label_Code.Text = "Codigo";
            // 
            // textBox_Code
            // 
            this.textBox_Code.Location = new System.Drawing.Point(111, 323);
            this.textBox_Code.Name = "textBox_Code";
            this.textBox_Code.ReadOnly = true;
            this.textBox_Code.Size = new System.Drawing.Size(118, 20);
            this.textBox_Code.TabIndex = 14;
            // 
            // Form_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 433);
            this.Controls.Add(this.textBox_Code);
            this.Controls.Add(this.label_Code);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.textBox_Precio);
            this.Controls.Add(this.button_Aceptar);
            this.Controls.Add(this.label_Desc);
            this.Controls.Add(this.label_Url);
            this.Controls.Add(this.label_Marca);
            this.Controls.Add(this.label_Cat);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.textBox_Imagen);
            this.Controls.Add(this.textBox_Desc);
            this.Controls.Add(this.comboBox_Marca);
            this.Controls.Add(this.comboBox_Categoria);
            this.Controls.Add(this.textBox_Name);
            this.Name = "Form_Alta";
            this.Text = "Form_Alta";
            this.Load += new System.EventHandler(this.Form_Alta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.ComboBox comboBox_Categoria;
        private System.Windows.Forms.ComboBox comboBox_Marca;
        private System.Windows.Forms.TextBox textBox_Desc;
        private System.Windows.Forms.TextBox textBox_Imagen;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Cat;
        private System.Windows.Forms.Label label_Marca;
        private System.Windows.Forms.Label label_Url;
        private System.Windows.Forms.Label label_Desc;
        private System.Windows.Forms.Button button_Aceptar;
        private System.Windows.Forms.TextBox textBox_Precio;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label label_Code;
        private System.Windows.Forms.TextBox textBox_Code;
    }
}