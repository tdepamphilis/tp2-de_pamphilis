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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_desc = new System.Windows.Forms.TextBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.imagelist = new System.Windows.Forms.ImageList(this.components);
            this.button_Modify = new System.Windows.Forms.Button();
            this.dataGridView_Main = new System.Windows.Forms.DataGridView();
            this.pictureBox_Product = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBox_Filter = new System.Windows.Forms.ComboBox();
            this.comboBox_FilterBy = new System.Windows.Forms.ComboBox();
            this.button_Filter = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Newproduct = new System.Windows.Forms.Button();
            this.groupBox_Filtros = new System.Windows.Forms.GroupBox();
            this.groupBox_Producto = new System.Windows.Forms.GroupBox();
            this.button_DeleteCat = new System.Windows.Forms.Button();
            this.button_NuevaCat = new System.Windows.Forms.Button();
            this.button_ModCat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_NuevaMarca = new System.Windows.Forms.Button();
            this.button_DelMarca = new System.Windows.Forms.Button();
            this.button_ModMarca = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_test = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Product)).BeginInit();
            this.groupBox_Filtros.SuspendLayout();
            this.groupBox_Producto.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_desc
            // 
            this.textBox_desc.Location = new System.Drawing.Point(678, 343);
            this.textBox_desc.Multiline = true;
            this.textBox_desc.Name = "textBox_desc";
            this.textBox_desc.Size = new System.Drawing.Size(369, 235);
            this.textBox_desc.TabIndex = 1;
            // 
            // button_Delete
            // 
            this.button_Delete.ImageIndex = 4;
            this.button_Delete.ImageList = this.imagelist;
            this.button_Delete.Location = new System.Drawing.Point(76, 18);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(52, 51);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // imagelist
            // 
            this.imagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagelist.ImageStream")));
            this.imagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.imagelist.Images.SetKeyName(0, "Search1.png");
            this.imagelist.Images.SetKeyName(1, "add.png");
            this.imagelist.Images.SetKeyName(2, "ADD2.png");
            this.imagelist.Images.SetKeyName(3, "Modify.png");
            this.imagelist.Images.SetKeyName(4, "Trash.png");
            // 
            // button_Modify
            // 
            this.button_Modify.ImageIndex = 3;
            this.button_Modify.ImageList = this.imagelist;
            this.button_Modify.Location = new System.Drawing.Point(134, 18);
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.Size = new System.Drawing.Size(51, 51);
            this.button_Modify.TabIndex = 3;
            this.button_Modify.UseVisualStyleBackColor = true;
            this.button_Modify.Click += new System.EventHandler(this.button_Modify_Click);
            // 
            // dataGridView_Main
            // 
            this.dataGridView_Main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Main.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Main.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Main.Location = new System.Drawing.Point(25, 193);
            this.dataGridView_Main.MultiSelect = false;
            this.dataGridView_Main.Name = "dataGridView_Main";
            this.dataGridView_Main.Size = new System.Drawing.Size(606, 385);
            this.dataGridView_Main.TabIndex = 4;
            this.dataGridView_Main.SelectionChanged += new System.EventHandler(this.dataGridView_Main_SelectionChanged);
            // 
            // pictureBox_Product
            // 
            this.pictureBox_Product.Location = new System.Drawing.Point(693, 87);
            this.pictureBox_Product.Name = "pictureBox_Product";
            this.pictureBox_Product.Size = new System.Drawing.Size(342, 231);
            this.pictureBox_Product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Product.TabIndex = 5;
            this.pictureBox_Product.TabStop = false;
            this.pictureBox_Product.Click += new System.EventHandler(this.pictureBox_Product_Click);
            // 
            // comboBox_Filter
            // 
            this.comboBox_Filter.FormattingEnabled = true;
            this.comboBox_Filter.Location = new System.Drawing.Point(179, 26);
            this.comboBox_Filter.Name = "comboBox_Filter";
            this.comboBox_Filter.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Filter.TabIndex = 6;
            // 
            // comboBox_FilterBy
            // 
            this.comboBox_FilterBy.FormattingEnabled = true;
            this.comboBox_FilterBy.Location = new System.Drawing.Point(42, 26);
            this.comboBox_FilterBy.Name = "comboBox_FilterBy";
            this.comboBox_FilterBy.Size = new System.Drawing.Size(121, 21);
            this.comboBox_FilterBy.TabIndex = 7;
            this.comboBox_FilterBy.SelectedIndexChanged += new System.EventHandler(this.comboBox_FilterBy_SelectedIndexChanged);
            // 
            // button_Filter
            // 
            this.button_Filter.ImageIndex = 0;
            this.button_Filter.ImageList = this.imagelist;
            this.button_Filter.Location = new System.Drawing.Point(141, 88);
            this.button_Filter.Name = "button_Filter";
            this.button_Filter.Size = new System.Drawing.Size(58, 56);
            this.button_Filter.TabIndex = 8;
            this.button_Filter.UseVisualStyleBackColor = true;
            this.button_Filter.Click += new System.EventHandler(this.button_Filter_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(42, 62);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(258, 20);
            this.textBox_Search.TabIndex = 9;
            // 
            // button_Newproduct
            // 
            this.button_Newproduct.ImageIndex = 2;
            this.button_Newproduct.ImageList = this.imagelist;
            this.button_Newproduct.Location = new System.Drawing.Point(17, 18);
            this.button_Newproduct.Name = "button_Newproduct";
            this.button_Newproduct.Size = new System.Drawing.Size(53, 51);
            this.button_Newproduct.TabIndex = 10;
            this.button_Newproduct.UseVisualStyleBackColor = true;
            this.button_Newproduct.Click += new System.EventHandler(this.button_Newproduct_Click);
            // 
            // groupBox_Filtros
            // 
            this.groupBox_Filtros.Controls.Add(this.textBox_Search);
            this.groupBox_Filtros.Controls.Add(this.button_Filter);
            this.groupBox_Filtros.Controls.Add(this.comboBox_FilterBy);
            this.groupBox_Filtros.Controls.Add(this.comboBox_Filter);
            this.groupBox_Filtros.Location = new System.Drawing.Point(25, 25);
            this.groupBox_Filtros.Name = "groupBox_Filtros";
            this.groupBox_Filtros.Size = new System.Drawing.Size(335, 150);
            this.groupBox_Filtros.TabIndex = 11;
            this.groupBox_Filtros.TabStop = false;
            this.groupBox_Filtros.Text = "Filtrar";
            // 
            // groupBox_Producto
            // 
            this.groupBox_Producto.Controls.Add(this.button_Newproduct);
            this.groupBox_Producto.Controls.Add(this.button_Modify);
            this.groupBox_Producto.Controls.Add(this.button_Delete);
            this.groupBox_Producto.Location = new System.Drawing.Point(25, 584);
            this.groupBox_Producto.Name = "groupBox_Producto";
            this.groupBox_Producto.Size = new System.Drawing.Size(214, 82);
            this.groupBox_Producto.TabIndex = 12;
            this.groupBox_Producto.TabStop = false;
            this.groupBox_Producto.Text = "Productos";
            // 
            // button_DeleteCat
            // 
            this.button_DeleteCat.ImageIndex = 4;
            this.button_DeleteCat.ImageList = this.imagelist;
            this.button_DeleteCat.Location = new System.Drawing.Point(78, 18);
            this.button_DeleteCat.Name = "button_DeleteCat";
            this.button_DeleteCat.Size = new System.Drawing.Size(51, 51);
            this.button_DeleteCat.TabIndex = 13;
            this.button_DeleteCat.UseVisualStyleBackColor = true;
            this.button_DeleteCat.Click += new System.EventHandler(this.button_DeleteCat_Click);
            // 
            // button_NuevaCat
            // 
            this.button_NuevaCat.ImageIndex = 2;
            this.button_NuevaCat.ImageList = this.imagelist;
            this.button_NuevaCat.Location = new System.Drawing.Point(21, 18);
            this.button_NuevaCat.Name = "button_NuevaCat";
            this.button_NuevaCat.Size = new System.Drawing.Size(51, 51);
            this.button_NuevaCat.TabIndex = 14;
            this.button_NuevaCat.UseVisualStyleBackColor = true;
            this.button_NuevaCat.Click += new System.EventHandler(this.button_NuevaCat_Click);
            // 
            // button_ModCat
            // 
            this.button_ModCat.ImageIndex = 3;
            this.button_ModCat.ImageList = this.imagelist;
            this.button_ModCat.Location = new System.Drawing.Point(135, 18);
            this.button_ModCat.Name = "button_ModCat";
            this.button_ModCat.Size = new System.Drawing.Size(51, 51);
            this.button_ModCat.TabIndex = 15;
            this.button_ModCat.UseVisualStyleBackColor = true;
            this.button_ModCat.Click += new System.EventHandler(this.button_ModCat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_ModCat);
            this.groupBox2.Controls.Add(this.button_NuevaCat);
            this.groupBox2.Controls.Add(this.button_DeleteCat);
            this.groupBox2.Location = new System.Drawing.Point(245, 584);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 82);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categorias";
            // 
            // button_NuevaMarca
            // 
            this.button_NuevaMarca.ImageIndex = 2;
            this.button_NuevaMarca.ImageList = this.imagelist;
            this.button_NuevaMarca.Location = new System.Drawing.Point(13, 18);
            this.button_NuevaMarca.Name = "button_NuevaMarca";
            this.button_NuevaMarca.Size = new System.Drawing.Size(51, 51);
            this.button_NuevaMarca.TabIndex = 17;
            this.button_NuevaMarca.UseVisualStyleBackColor = true;
            this.button_NuevaMarca.Click += new System.EventHandler(this.button_NuevaMarca_Click);
            // 
            // button_DelMarca
            // 
            this.button_DelMarca.ImageIndex = 4;
            this.button_DelMarca.ImageList = this.imagelist;
            this.button_DelMarca.Location = new System.Drawing.Point(70, 18);
            this.button_DelMarca.Name = "button_DelMarca";
            this.button_DelMarca.Size = new System.Drawing.Size(51, 51);
            this.button_DelMarca.TabIndex = 18;
            this.button_DelMarca.UseVisualStyleBackColor = true;
            this.button_DelMarca.Click += new System.EventHandler(this.button_DelMarca_Click);
            // 
            // button_ModMarca
            // 
            this.button_ModMarca.ImageIndex = 3;
            this.button_ModMarca.ImageList = this.imagelist;
            this.button_ModMarca.Location = new System.Drawing.Point(127, 18);
            this.button_ModMarca.Name = "button_ModMarca";
            this.button_ModMarca.Size = new System.Drawing.Size(51, 51);
            this.button_ModMarca.TabIndex = 19;
            this.button_ModMarca.UseVisualStyleBackColor = true;
            this.button_ModMarca.Click += new System.EventHandler(this.button_ModMarca_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_NuevaMarca);
            this.groupBox1.Controls.Add(this.button_ModMarca);
            this.groupBox1.Controls.Add(this.button_DelMarca);
            this.groupBox1.Location = new System.Drawing.Point(469, 584);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 82);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marcas";
            // 
            // button_test
            // 
            this.button_test.Location = new System.Drawing.Point(446, 84);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(75, 23);
            this.button_test.TabIndex = 21;
            this.button_test.Text = "button1";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 688);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_Producto);
            this.Controls.Add(this.groupBox_Filtros);
            this.Controls.Add(this.pictureBox_Product);
            this.Controls.Add(this.dataGridView_Main);
            this.Controls.Add(this.textBox_desc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Gestor de productos";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Product)).EndInit();
            this.groupBox_Filtros.ResumeLayout(false);
            this.groupBox_Filtros.PerformLayout();
            this.groupBox_Producto.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.ImageList imagelist;
        private System.Windows.Forms.GroupBox groupBox_Filtros;
        private System.Windows.Forms.GroupBox groupBox_Producto;
        private System.Windows.Forms.Button button_DeleteCat;
        private System.Windows.Forms.Button button_NuevaCat;
        private System.Windows.Forms.Button button_ModCat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_NuevaMarca;
        private System.Windows.Forms.Button button_DelMarca;
        private System.Windows.Forms.Button button_ModMarca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_test;
    }
}

