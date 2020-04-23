namespace FrontEnd
{
    partial class BajaCategoria
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
            this.comboBox_Cat = new System.Windows.Forms.ComboBox();
            this.button_Eliminar = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_Cat
            // 
            this.comboBox_Cat.FormattingEnabled = true;
            this.comboBox_Cat.Location = new System.Drawing.Point(92, 70);
            this.comboBox_Cat.Name = "comboBox_Cat";
            this.comboBox_Cat.Size = new System.Drawing.Size(183, 21);
            this.comboBox_Cat.TabIndex = 0;
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.Location = new System.Drawing.Point(212, 156);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(155, 38);
            this.button_Eliminar.TabIndex = 1;
            this.button_Eliminar.Text = "Eliminar";
            this.button_Eliminar.UseVisualStyleBackColor = true;
            this.button_Eliminar.Click += new System.EventHandler(this.button_Eliminar_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(36, 156);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(155, 38);
            this.button_Cancel.TabIndex = 2;
            this.button_Cancel.Text = "Cancelar";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // BajaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Eliminar);
            this.Controls.Add(this.comboBox_Cat);
            this.Name = "BajaCategoria";
            this.Text = "BajaCategoria";
            this.Load += new System.EventHandler(this.BajaCategoria_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Cat;
        private System.Windows.Forms.Button button_Eliminar;
        private System.Windows.Forms.Button button_Cancel;
    }
}