namespace FrontEnd
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_desc = new System.Windows.Forms.TextBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Modify = new System.Windows.Forms.Button();
            this.dataGridView_Main = new System.Windows.Forms.DataGridView();
            this.pictureBox_Product = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBox_Filter = new System.Windows.Forms.ComboBox();
            this.comboBox_FilterBy = new System.Windows.Forms.ComboBox();
            this.button_Filter = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Newproduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_desc
            // 
            this.textBox_desc.Location = new System.Drawing.Point(677, 369);
            this.textBox_desc.Multiline = true;
            this.textBox_desc.Name = "textBox_desc";
            this.textBox_desc.Size = new System.Drawing.Size(369, 235);
            this.textBox_desc.TabIndex = 1;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(723, 610);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(129, 51);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Eliminar";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Modify
            // 
            this.button_Modify.Location = new System.Drawing.Point(895, 610);
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.Size = new System.Drawing.Size(129, 51);
            this.button_Modify.TabIndex = 3;
            this.button_Modify.Text = "Modificar";
            this.button_Modify.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Main
            // 
            this.dataGridView_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Main.Location = new System.Drawing.Point(25, 219);
            this.dataGridView_Main.Name = "dataGridView_Main";
            this.dataGridView_Main.Size = new System.Drawing.Size(606, 385);
            this.dataGridView_Main.TabIndex = 4;
            this.dataGridView_Main.SelectionChanged += new System.EventHandler(this.dataGridView_Main_SelectionChanged);
            // 
            // pictureBox_Product
            // 
            this.pictureBox_Product.Location = new System.Drawing.Point(693, 115);
            this.pictureBox_Product.Name = "pictureBox_Product";
            this.pictureBox_Product.Size = new System.Drawing.Size(342, 231);
            this.pictureBox_Product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Product.TabIndex = 5;
            this.pictureBox_Product.TabStop = false;
            // 
            // comboBox_Filter
            // 
            this.comboBox_Filter.FormattingEnabled = true;
            this.comboBox_Filter.Location = new System.Drawing.Point(229, 115);
            this.comboBox_Filter.Name = "comboBox_Filter";
            this.comboBox_Filter.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Filter.TabIndex = 6;
            // 
            // comboBox_FilterBy
            // 
            this.comboBox_FilterBy.FormattingEnabled = true;
            this.comboBox_FilterBy.Location = new System.Drawing.Point(85, 115);
            this.comboBox_FilterBy.Name = "comboBox_FilterBy";
            this.comboBox_FilterBy.Size = new System.Drawing.Size(121, 21);
            this.comboBox_FilterBy.TabIndex = 7;
            this.comboBox_FilterBy.SelectedIndexChanged += new System.EventHandler(this.comboBox_FilterBy_SelectedIndexChanged);
            // 
            // button_Filter
            // 
            this.button_Filter.Location = new System.Drawing.Point(85, 59);
            this.button_Filter.Name = "button_Filter";
            this.button_Filter.Size = new System.Drawing.Size(137, 37);
            this.button_Filter.TabIndex = 8;
            this.button_Filter.Text = "Filtrar";
            this.button_Filter.UseVisualStyleBackColor = true;
            this.button_Filter.Click += new System.EventHandler(this.button_Filter_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(95, 158);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(212, 20);
            this.textBox_Search.TabIndex = 9;
            // 
            // button_Newproduct
            // 
            this.button_Newproduct.Location = new System.Drawing.Point(504, 146);
            this.button_Newproduct.Name = "button_Newproduct";
            this.button_Newproduct.Size = new System.Drawing.Size(154, 42);
            this.button_Newproduct.TabIndex = 10;
            this.button_Newproduct.Text = "Nuevo producto";
            this.button_Newproduct.UseVisualStyleBackColor = true;
            this.button_Newproduct.Click += new System.EventHandler(this.button_Newproduct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 688);
            this.Controls.Add(this.button_Newproduct);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.button_Filter);
            this.Controls.Add(this.comboBox_FilterBy);
            this.Controls.Add(this.comboBox_Filter);
            this.Controls.Add(this.pictureBox_Product);
            this.Controls.Add(this.dataGridView_Main);
            this.Controls.Add(this.button_Modify);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.textBox_desc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_desc;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Modify;
        private System.Windows.Forms.DataGridView dataGridView_Main;
        private System.Windows.Forms.PictureBox pictureBox_Product;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox comboBox_Filter;
        private System.Windows.Forms.ComboBox comboBox_FilterBy;
        private System.Windows.Forms.Button button_Filter;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Newproduct;
    }
}

