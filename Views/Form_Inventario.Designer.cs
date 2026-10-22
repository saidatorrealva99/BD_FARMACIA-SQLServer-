namespace Farmacia.Views
{
    partial class Form_Inventario
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
            this.button_Salir = new System.Windows.Forms.Button();
            this.button_ExportarExcel = new System.Windows.Forms.Button();
            this.ExportarPDF = new System.Windows.Forms.Button();
            this.dataGridView_MostrarInventario = new System.Windows.Forms.DataGridView();
            this.button_Modificar = new System.Windows.Forms.Button();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Nuevo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_BuscarInventario = new System.Windows.Forms.Button();
            this.textBox_BuscarInventario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_VerInventario = new System.Windows.Forms.Button();
            this.textBox_StockActual = new System.Windows.Forms.TextBox();
            this.textBox_CodigoInventario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LOTE = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_StockMinimo = new System.Windows.Forms.TextBox();
            this.comboBox_Sucursal = new System.Windows.Forms.ComboBox();
            this.comboBox_Lote = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_Fecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_UbicacionPasillo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_StockMaximo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MostrarInventario)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Salir
            // 
            this.button_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Salir.Location = new System.Drawing.Point(846, 550);
            this.button_Salir.Margin = new System.Windows.Forms.Padding(2);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(112, 39);
            this.button_Salir.TabIndex = 22;
            this.button_Salir.Text = "SALIR";
            this.button_Salir.UseVisualStyleBackColor = false;
            // 
            // button_ExportarExcel
            // 
            this.button_ExportarExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_ExportarExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ExportarExcel.Location = new System.Drawing.Point(646, 550);
            this.button_ExportarExcel.Margin = new System.Windows.Forms.Padding(2);
            this.button_ExportarExcel.Name = "button_ExportarExcel";
            this.button_ExportarExcel.Size = new System.Drawing.Size(153, 39);
            this.button_ExportarExcel.TabIndex = 21;
            this.button_ExportarExcel.Text = "EXPORTAR EXCEL";
            this.button_ExportarExcel.UseVisualStyleBackColor = false;
            // 
            // ExportarPDF
            // 
            this.ExportarPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ExportarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportarPDF.Location = new System.Drawing.Point(454, 550);
            this.ExportarPDF.Margin = new System.Windows.Forms.Padding(2);
            this.ExportarPDF.Name = "ExportarPDF";
            this.ExportarPDF.Size = new System.Drawing.Size(133, 39);
            this.ExportarPDF.TabIndex = 20;
            this.ExportarPDF.Text = "EXPORTAR PDF";
            this.ExportarPDF.UseVisualStyleBackColor = false;
            // 
            // dataGridView_MostrarInventario
            // 
            this.dataGridView_MostrarInventario.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView_MostrarInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MostrarInventario.Location = new System.Drawing.Point(24, 420);
            this.dataGridView_MostrarInventario.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_MostrarInventario.Name = "dataGridView_MostrarInventario";
            this.dataGridView_MostrarInventario.RowHeadersWidth = 51;
            this.dataGridView_MostrarInventario.RowTemplate.Height = 24;
            this.dataGridView_MostrarInventario.Size = new System.Drawing.Size(934, 103);
            this.dataGridView_MostrarInventario.TabIndex = 19;
            // 
            // button_Modificar
            // 
            this.button_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_Modificar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Modificar.Location = new System.Drawing.Point(846, 320);
            this.button_Modificar.Margin = new System.Windows.Forms.Padding(2);
            this.button_Modificar.Name = "button_Modificar";
            this.button_Modificar.Size = new System.Drawing.Size(98, 35);
            this.button_Modificar.TabIndex = 16;
            this.button_Modificar.Text = "MODIFICAR";
            this.button_Modificar.UseVisualStyleBackColor = false;
            // 
            // button_Guardar
            // 
            this.button_Guardar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Guardar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Guardar.Location = new System.Drawing.Point(454, 320);
            this.button_Guardar.Margin = new System.Windows.Forms.Padding(2);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(98, 35);
            this.button_Guardar.TabIndex = 17;
            this.button_Guardar.Text = "GUARDAR";
            this.button_Guardar.UseVisualStyleBackColor = false;
            // 
            // button_Nuevo
            // 
            this.button_Nuevo.BackColor = System.Drawing.Color.LightGreen;
            this.button_Nuevo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Nuevo.Location = new System.Drawing.Point(35, 320);
            this.button_Nuevo.Margin = new System.Windows.Forms.Padding(2);
            this.button_Nuevo.Name = "button_Nuevo";
            this.button_Nuevo.Size = new System.Drawing.Size(98, 35);
            this.button_Nuevo.TabIndex = 18;
            this.button_Nuevo.Text = "NUEVO";
            this.button_Nuevo.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button_BuscarInventario);
            this.panel2.Controls.Add(this.textBox_BuscarInventario);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(23, 359);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 48);
            this.panel2.TabIndex = 15;
            // 
            // button_BuscarInventario
            // 
            this.button_BuscarInventario.BackColor = System.Drawing.Color.Thistle;
            this.button_BuscarInventario.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BuscarInventario.Location = new System.Drawing.Point(764, 11);
            this.button_BuscarInventario.Margin = new System.Windows.Forms.Padding(2);
            this.button_BuscarInventario.Name = "button_BuscarInventario";
            this.button_BuscarInventario.Size = new System.Drawing.Size(98, 33);
            this.button_BuscarInventario.TabIndex = 2;
            this.button_BuscarInventario.Text = "BUSCAR";
            this.button_BuscarInventario.UseVisualStyleBackColor = false;
            // 
            // textBox_BuscarInventario
            // 
            this.textBox_BuscarInventario.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BuscarInventario.Location = new System.Drawing.Point(308, 15);
            this.textBox_BuscarInventario.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_BuscarInventario.Name = "textBox_BuscarInventario";
            this.textBox_BuscarInventario.Size = new System.Drawing.Size(426, 22);
            this.textBox_BuscarInventario.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "BUSCAR POR: SUCURSAL, LOTE, PASILLO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox_StockMaximo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox_UbicacionPasillo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateTimePicker_Fecha);
            this.panel1.Controls.Add(this.comboBox_Lote);
            this.panel1.Controls.Add(this.comboBox_Sucursal);
            this.panel1.Controls.Add(this.textBox_StockMinimo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.LOTE);
            this.panel1.Controls.Add(this.button_VerInventario);
            this.panel1.Controls.Add(this.textBox_StockActual);
            this.panel1.Controls.Add(this.textBox_CodigoInventario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(23, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 259);
            this.panel1.TabIndex = 14;
            // 
            // button_VerInventario
            // 
            this.button_VerInventario.BackColor = System.Drawing.Color.Thistle;
            this.button_VerInventario.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_VerInventario.Location = new System.Drawing.Point(764, 125);
            this.button_VerInventario.Margin = new System.Windows.Forms.Padding(2);
            this.button_VerInventario.Name = "button_VerInventario";
            this.button_VerInventario.Size = new System.Drawing.Size(154, 74);
            this.button_VerInventario.TabIndex = 5;
            this.button_VerInventario.Text = "VER INVENTARIO";
            this.button_VerInventario.UseVisualStyleBackColor = false;
            // 
            // textBox_StockActual
            // 
            this.textBox_StockActual.Location = new System.Drawing.Point(195, 138);
            this.textBox_StockActual.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_StockActual.Name = "textBox_StockActual";
            this.textBox_StockActual.Size = new System.Drawing.Size(226, 20);
            this.textBox_StockActual.TabIndex = 4;
            // 
            // textBox_CodigoInventario
            // 
            this.textBox_CodigoInventario.Location = new System.Drawing.Point(195, 26);
            this.textBox_CodigoInventario.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_CodigoInventario.Name = "textBox_CodigoInventario";
            this.textBox_CodigoInventario.Size = new System.Drawing.Size(226, 20);
            this.textBox_CodigoInventario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CODIGO DE INVENTARIO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "SUCURSAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "FORMULARIO DE INVENTARIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LOTE
            // 
            this.LOTE.AutoSize = true;
            this.LOTE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOTE.Location = new System.Drawing.Point(8, 103);
            this.LOTE.Name = "LOTE";
            this.LOTE.Size = new System.Drawing.Size(40, 15);
            this.LOTE.TabIndex = 6;
            this.LOTE.Text = "LOTE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "STOCK ACTUAL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "STOCK MINIMO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(470, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "FECHA  ACTUALIZADA";
            // 
            // textBox_StockMinimo
            // 
            this.textBox_StockMinimo.Location = new System.Drawing.Point(195, 179);
            this.textBox_StockMinimo.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_StockMinimo.Name = "textBox_StockMinimo";
            this.textBox_StockMinimo.Size = new System.Drawing.Size(226, 20);
            this.textBox_StockMinimo.TabIndex = 10;
            // 
            // comboBox_Sucursal
            // 
            this.comboBox_Sucursal.FormattingEnabled = true;
            this.comboBox_Sucursal.Location = new System.Drawing.Point(195, 63);
            this.comboBox_Sucursal.Name = "comboBox_Sucursal";
            this.comboBox_Sucursal.Size = new System.Drawing.Size(226, 21);
            this.comboBox_Sucursal.TabIndex = 11;
            // 
            // comboBox_Lote
            // 
            this.comboBox_Lote.FormattingEnabled = true;
            this.comboBox_Lote.Location = new System.Drawing.Point(195, 101);
            this.comboBox_Lote.Name = "comboBox_Lote";
            this.comboBox_Lote.Size = new System.Drawing.Size(226, 21);
            this.comboBox_Lote.TabIndex = 12;
            // 
            // dateTimePicker_Fecha
            // 
            this.dateTimePicker_Fecha.Location = new System.Drawing.Point(640, 65);
            this.dateTimePicker_Fecha.Name = "dateTimePicker_Fecha";
            this.dateTimePicker_Fecha.Size = new System.Drawing.Size(240, 20);
            this.dateTimePicker_Fecha.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(470, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "UBICACION DE PASILLO";
            // 
            // textBox_UbicacionPasillo
            // 
            this.textBox_UbicacionPasillo.Location = new System.Drawing.Point(640, 21);
            this.textBox_UbicacionPasillo.Name = "textBox_UbicacionPasillo";
            this.textBox_UbicacionPasillo.Size = new System.Drawing.Size(238, 20);
            this.textBox_UbicacionPasillo.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "STOCK MAXIMO";
            // 
            // textBox_StockMaximo
            // 
            this.textBox_StockMaximo.Location = new System.Drawing.Point(195, 218);
            this.textBox_StockMaximo.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_StockMaximo.Name = "textBox_StockMaximo";
            this.textBox_StockMaximo.Size = new System.Drawing.Size(226, 20);
            this.textBox_StockMaximo.TabIndex = 17;
            // 
            // Form_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(971, 592);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.button_ExportarExcel);
            this.Controls.Add(this.ExportarPDF);
            this.Controls.Add(this.dataGridView_MostrarInventario);
            this.Controls.Add(this.button_Modificar);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.button_Nuevo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form_Inventario";
            this.Text = "Form_Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MostrarInventario)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Salir;
        private System.Windows.Forms.Button button_ExportarExcel;
        private System.Windows.Forms.Button ExportarPDF;
        private System.Windows.Forms.DataGridView dataGridView_MostrarInventario;
        private System.Windows.Forms.Button button_Modificar;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Nuevo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_BuscarInventario;
        private System.Windows.Forms.TextBox textBox_BuscarInventario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_VerInventario;
        private System.Windows.Forms.TextBox textBox_StockActual;
        private System.Windows.Forms.TextBox textBox_CodigoInventario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LOTE;
        private System.Windows.Forms.ComboBox comboBox_Lote;
        private System.Windows.Forms.ComboBox comboBox_Sucursal;
        private System.Windows.Forms.TextBox textBox_StockMinimo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_StockMaximo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_UbicacionPasillo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Fecha;
    }
}