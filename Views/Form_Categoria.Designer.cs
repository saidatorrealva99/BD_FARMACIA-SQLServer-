namespace Farmacia.Views
{
    partial class Form_Categoria
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_VerCategoria = new System.Windows.Forms.Button();
            this.textBox_NombreCategoria = new System.Windows.Forms.TextBox();
            this.textBox_CodigoCategoria = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.textBox_BuscarCategoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Nuevo = new System.Windows.Forms.Button();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Modificar = new System.Windows.Forms.Button();
            this.dataGridView_MostrarCategoria = new System.Windows.Forms.DataGridView();
            this.ExportarPDF = new System.Windows.Forms.Button();
            this.button_ExportarExcel = new System.Windows.Forms.Button();
            this.button_Salir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MostrarCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORMULARIO DE CATEGORIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CODIGO DE CATEGORIA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOMBRE DE CATEGORIA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_VerCategoria);
            this.panel1.Controls.Add(this.textBox_NombreCategoria);
            this.panel1.Controls.Add(this.textBox_CodigoCategoria);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(90, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 145);
            this.panel1.TabIndex = 3;
            // 
            // button_VerCategoria
            // 
            this.button_VerCategoria.BackColor = System.Drawing.Color.Thistle;
            this.button_VerCategoria.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_VerCategoria.Location = new System.Drawing.Point(569, 30);
            this.button_VerCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_VerCategoria.Name = "button_VerCategoria";
            this.button_VerCategoria.Size = new System.Drawing.Size(154, 74);
            this.button_VerCategoria.TabIndex = 5;
            this.button_VerCategoria.Text = "VER CATEGORIA";
            this.button_VerCategoria.UseVisualStyleBackColor = false;
            // 
            // textBox_NombreCategoria
            // 
            this.textBox_NombreCategoria.Location = new System.Drawing.Point(202, 84);
            this.textBox_NombreCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_NombreCategoria.Name = "textBox_NombreCategoria";
            this.textBox_NombreCategoria.Size = new System.Drawing.Size(226, 20);
            this.textBox_NombreCategoria.TabIndex = 4;
            // 
            // textBox_CodigoCategoria
            // 
            this.textBox_CodigoCategoria.Location = new System.Drawing.Point(202, 25);
            this.textBox_CodigoCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_CodigoCategoria.Name = "textBox_CodigoCategoria";
            this.textBox_CodigoCategoria.Size = new System.Drawing.Size(226, 20);
            this.textBox_CodigoCategoria.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button_Buscar);
            this.panel2.Controls.Add(this.textBox_BuscarCategoria);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(90, 267);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 48);
            this.panel2.TabIndex = 4;
            // 
            // button_Buscar
            // 
            this.button_Buscar.BackColor = System.Drawing.Color.Thistle;
            this.button_Buscar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Buscar.Location = new System.Drawing.Point(622, 8);
            this.button_Buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(98, 33);
            this.button_Buscar.TabIndex = 2;
            this.button_Buscar.Text = "BUSCAR";
            this.button_Buscar.UseVisualStyleBackColor = false;
            // 
            // textBox_BuscarCategoria
            // 
            this.textBox_BuscarCategoria.Location = new System.Drawing.Point(308, 15);
            this.textBox_BuscarCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_BuscarCategoria.Name = "textBox_BuscarCategoria";
            this.textBox_BuscarCategoria.Size = new System.Drawing.Size(282, 20);
            this.textBox_BuscarCategoria.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "INGRESE EL NOMBRE DE LA CATEGORIA";
            // 
            // button_Nuevo
            // 
            this.button_Nuevo.BackColor = System.Drawing.Color.LightGreen;
            this.button_Nuevo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Nuevo.Location = new System.Drawing.Point(102, 227);
            this.button_Nuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Nuevo.Name = "button_Nuevo";
            this.button_Nuevo.Size = new System.Drawing.Size(98, 35);
            this.button_Nuevo.TabIndex = 7;
            this.button_Nuevo.Text = "NUEVO";
            this.button_Nuevo.UseVisualStyleBackColor = false;
            // 
            // button_Guardar
            // 
            this.button_Guardar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Guardar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Guardar.Location = new System.Drawing.Point(421, 228);
            this.button_Guardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(98, 35);
            this.button_Guardar.TabIndex = 7;
            this.button_Guardar.Text = "GUARDAR";
            this.button_Guardar.UseVisualStyleBackColor = false;
            // 
            // button_Modificar
            // 
            this.button_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_Modificar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Modificar.Location = new System.Drawing.Point(716, 228);
            this.button_Modificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Modificar.Name = "button_Modificar";
            this.button_Modificar.Size = new System.Drawing.Size(98, 35);
            this.button_Modificar.TabIndex = 7;
            this.button_Modificar.Text = "MODIFICAR";
            this.button_Modificar.UseVisualStyleBackColor = false;
            // 
            // dataGridView_MostrarCategoria
            // 
            this.dataGridView_MostrarCategoria.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView_MostrarCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MostrarCategoria.Location = new System.Drawing.Point(91, 329);
            this.dataGridView_MostrarCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_MostrarCategoria.Name = "dataGridView_MostrarCategoria";
            this.dataGridView_MostrarCategoria.RowHeadersWidth = 51;
            this.dataGridView_MostrarCategoria.RowTemplate.Height = 24;
            this.dataGridView_MostrarCategoria.Size = new System.Drawing.Size(720, 142);
            this.dataGridView_MostrarCategoria.TabIndex = 8;
            // 
            // ExportarPDF
            // 
            this.ExportarPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ExportarPDF.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportarPDF.Location = new System.Drawing.Point(371, 486);
            this.ExportarPDF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExportarPDF.Name = "ExportarPDF";
            this.ExportarPDF.Size = new System.Drawing.Size(136, 39);
            this.ExportarPDF.TabIndex = 9;
            this.ExportarPDF.Text = "EXPORTAR PDF";
            this.ExportarPDF.UseVisualStyleBackColor = false;
            // 
            // button_ExportarExcel
            // 
            this.button_ExportarExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_ExportarExcel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ExportarExcel.Location = new System.Drawing.Point(534, 486);
            this.button_ExportarExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_ExportarExcel.Name = "button_ExportarExcel";
            this.button_ExportarExcel.Size = new System.Drawing.Size(147, 39);
            this.button_ExportarExcel.TabIndex = 11;
            this.button_ExportarExcel.Text = "EXPORTAR EXCEL";
            this.button_ExportarExcel.UseVisualStyleBackColor = false;
            // 
            // button_Salir
            // 
            this.button_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Salir.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Salir.Location = new System.Drawing.Point(699, 486);
            this.button_Salir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(112, 39);
            this.button_Salir.TabIndex = 12;
            this.button_Salir.Text = "SALIR";
            this.button_Salir.UseVisualStyleBackColor = false;
            // 
            // Form_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(865, 572);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.button_ExportarExcel);
            this.Controls.Add(this.ExportarPDF);
            this.Controls.Add(this.dataGridView_MostrarCategoria);
            this.Controls.Add(this.button_Modificar);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.button_Nuevo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Categoria";
            this.Text = "Form_Categoria";
            this.Load += new System.EventHandler(this.Form_Categoria_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MostrarCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_VerCategoria;
        private System.Windows.Forms.TextBox textBox_NombreCategoria;
        private System.Windows.Forms.TextBox textBox_CodigoCategoria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Nuevo;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Modificar;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.TextBox textBox_BuscarCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView_MostrarCategoria;
        private System.Windows.Forms.Button ExportarPDF;
        private System.Windows.Forms.Button button_ExportarExcel;
        private System.Windows.Forms.Button button_Salir;
    }
}