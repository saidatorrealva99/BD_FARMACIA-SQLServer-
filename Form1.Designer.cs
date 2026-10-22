namespace Farmacia
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
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.button_ExportarExcel = new System.Windows.Forms.Button();
            this.ExportarPDF = new System.Windows.Forms.Button();
            this.dataGridView_MostrarCategoria = new System.Windows.Forms.DataGridView();
            this.button_Modificar = new System.Windows.Forms.Button();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Nuevo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_BuscarCategoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_VerCategoria = new System.Windows.Forms.Button();
            this.textBox_NombreCategoria = new System.Windows.Forms.TextBox();
            this.textBox_CodigoCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MostrarCategoria)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(838, 534);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(150, 48);
            this.button_Cerrar.TabIndex = 22;
            this.button_Cerrar.Text = "CERRAR";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            // 
            // button_ExportarExcel
            // 
            this.button_ExportarExcel.Location = new System.Drawing.Point(643, 534);
            this.button_ExportarExcel.Name = "button_ExportarExcel";
            this.button_ExportarExcel.Size = new System.Drawing.Size(150, 48);
            this.button_ExportarExcel.TabIndex = 21;
            this.button_ExportarExcel.Text = "EXPORTAR EXCEL";
            this.button_ExportarExcel.UseVisualStyleBackColor = true;
            // 
            // ExportarPDF
            // 
            this.ExportarPDF.Location = new System.Drawing.Point(435, 534);
            this.ExportarPDF.Name = "ExportarPDF";
            this.ExportarPDF.Size = new System.Drawing.Size(150, 48);
            this.ExportarPDF.TabIndex = 20;
            this.ExportarPDF.Text = "EXPORTAR PDF";
            this.ExportarPDF.UseVisualStyleBackColor = true;
            // 
            // dataGridView_MostrarCategoria
            // 
            this.dataGridView_MostrarCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MostrarCategoria.Location = new System.Drawing.Point(78, 343);
            this.dataGridView_MostrarCategoria.Name = "dataGridView_MostrarCategoria";
            this.dataGridView_MostrarCategoria.RowHeadersWidth = 51;
            this.dataGridView_MostrarCategoria.RowTemplate.Height = 24;
            this.dataGridView_MostrarCategoria.Size = new System.Drawing.Size(910, 175);
            this.dataGridView_MostrarCategoria.TabIndex = 19;
            // 
            // button_Modificar
            // 
            this.button_Modificar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Modificar.Location = new System.Drawing.Point(844, 215);
            this.button_Modificar.Name = "button_Modificar";
            this.button_Modificar.Size = new System.Drawing.Size(130, 43);
            this.button_Modificar.TabIndex = 16;
            this.button_Modificar.Text = "MODIFICAR";
            this.button_Modificar.UseVisualStyleBackColor = true;
            // 
            // button_Guardar
            // 
            this.button_Guardar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Guardar.Location = new System.Drawing.Point(466, 215);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(130, 43);
            this.button_Guardar.TabIndex = 17;
            this.button_Guardar.Text = "GUARDAR";
            this.button_Guardar.UseVisualStyleBackColor = true;
            // 
            // button_Nuevo
            // 
            this.button_Nuevo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Nuevo.Location = new System.Drawing.Point(93, 215);
            this.button_Nuevo.Name = "button_Nuevo";
            this.button_Nuevo.Size = new System.Drawing.Size(130, 43);
            this.button_Nuevo.TabIndex = 18;
            this.button_Nuevo.Text = "NUEVO";
            this.button_Nuevo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textBox_BuscarCategoria);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(78, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 59);
            this.panel2.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(765, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "BUSCAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox_BuscarCategoria
            // 
            this.textBox_BuscarCategoria.Location = new System.Drawing.Point(356, 19);
            this.textBox_BuscarCategoria.Name = "textBox_BuscarCategoria";
            this.textBox_BuscarCategoria.Size = new System.Drawing.Size(374, 22);
            this.textBox_BuscarCategoria.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "INGRESE EL NOMBRE DE LA CATEGORIA";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_VerCategoria);
            this.panel1.Controls.Add(this.textBox_NombreCategoria);
            this.panel1.Controls.Add(this.textBox_CodigoCategoria);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(78, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 178);
            this.panel1.TabIndex = 14;
            // 
            // button_VerCategoria
            // 
            this.button_VerCategoria.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_VerCategoria.Location = new System.Drawing.Point(670, 34);
            this.button_VerCategoria.Name = "button_VerCategoria";
            this.button_VerCategoria.Size = new System.Drawing.Size(205, 91);
            this.button_VerCategoria.TabIndex = 5;
            this.button_VerCategoria.Text = "VER CATEGORIA";
            this.button_VerCategoria.UseVisualStyleBackColor = true;
            // 
            // textBox_NombreCategoria
            // 
            this.textBox_NombreCategoria.Location = new System.Drawing.Point(269, 103);
            this.textBox_NombreCategoria.Name = "textBox_NombreCategoria";
            this.textBox_NombreCategoria.Size = new System.Drawing.Size(300, 22);
            this.textBox_NombreCategoria.TabIndex = 4;
            // 
            // textBox_CodigoCategoria
            // 
            this.textBox_CodigoCategoria.Location = new System.Drawing.Point(269, 31);
            this.textBox_CodigoCategoria.Name = "textBox_CodigoCategoria";
            this.textBox_CodigoCategoria.Size = new System.Drawing.Size(300, 22);
            this.textBox_CodigoCategoria.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "CODIGO DE CATEGORIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOMBRE DE CATEGORIA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, -27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "FORMULARIO DE CATEGORIA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 639);
            this.Controls.Add(this.button_Cerrar);
            this.Controls.Add(this.button_ExportarExcel);
            this.Controls.Add(this.ExportarPDF);
            this.Controls.Add(this.dataGridView_MostrarCategoria);
            this.Controls.Add(this.button_Modificar);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.button_Nuevo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MostrarCategoria)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.Button button_ExportarExcel;
        private System.Windows.Forms.Button ExportarPDF;
        private System.Windows.Forms.DataGridView dataGridView_MostrarCategoria;
        private System.Windows.Forms.Button button_Modificar;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Nuevo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_BuscarCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_VerCategoria;
        private System.Windows.Forms.TextBox textBox_NombreCategoria;
        private System.Windows.Forms.TextBox textBox_CodigoCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

