namespace Farmacia.Views
{
    partial class Form_Venta
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
            this.button_DarBaja = new System.Windows.Forms.Button();
            this.dataGridView_MostrarVentas = new System.Windows.Forms.DataGridView();
            this.button_Modificar = new System.Windows.Forms.Button();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Nuevo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.textBox_BuscarVentas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker_Fecha = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LOTE = new System.Windows.Forms.Label();
            this.button_VerVentas = new System.Windows.Forms.Button();
            this.textBox_CodigoVenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Salir = new System.Windows.Forms.Button();
            this.button_ExportarExcel = new System.Windows.Forms.Button();
            this.ExportarPDF = new System.Windows.Forms.Button();
            this.comboBox_Cliente = new System.Windows.Forms.ComboBox();
            this.comboBox_metodoPago = new System.Windows.Forms.ComboBox();
            this.comboBox_TipoComprobante = new System.Windows.Forms.ComboBox();
            this.comboBox_Personal = new System.Windows.Forms.ComboBox();
            this.comboBox_Sucursal = new System.Windows.Forms.ComboBox();
            this.comboBox_Receta = new System.Windows.Forms.ComboBox();
            this.textBox_SerieComprobante = new System.Windows.Forms.TextBox();
            this.textBox_NumeroComprobante = new System.Windows.Forms.TextBox();
            this.textBox_TotalVenta = new System.Windows.Forms.TextBox();
            this.button_VerVentasAnuladas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MostrarVentas)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_DarBaja
            // 
            this.button_DarBaja.BackColor = System.Drawing.Color.Silver;
            this.button_DarBaja.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DarBaja.Location = new System.Drawing.Point(1041, 368);
            this.button_DarBaja.Margin = new System.Windows.Forms.Padding(2);
            this.button_DarBaja.Name = "button_DarBaja";
            this.button_DarBaja.Size = new System.Drawing.Size(98, 35);
            this.button_DarBaja.TabIndex = 41;
            this.button_DarBaja.Text = "DAR DE BAJA";
            this.button_DarBaja.UseVisualStyleBackColor = false;
            // 
            // dataGridView_MostrarVentas
            // 
            this.dataGridView_MostrarVentas.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView_MostrarVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MostrarVentas.Location = new System.Drawing.Point(70, 479);
            this.dataGridView_MostrarVentas.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_MostrarVentas.Name = "dataGridView_MostrarVentas";
            this.dataGridView_MostrarVentas.RowHeadersWidth = 51;
            this.dataGridView_MostrarVentas.RowTemplate.Height = 24;
            this.dataGridView_MostrarVentas.Size = new System.Drawing.Size(1100, 103);
            this.dataGridView_MostrarVentas.TabIndex = 40;
            // 
            // button_Modificar
            // 
            this.button_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_Modificar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Modificar.Location = new System.Drawing.Point(711, 368);
            this.button_Modificar.Margin = new System.Windows.Forms.Padding(2);
            this.button_Modificar.Name = "button_Modificar";
            this.button_Modificar.Size = new System.Drawing.Size(98, 35);
            this.button_Modificar.TabIndex = 37;
            this.button_Modificar.Text = "MODIFICAR";
            this.button_Modificar.UseVisualStyleBackColor = false;
            // 
            // button_Guardar
            // 
            this.button_Guardar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Guardar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Guardar.Location = new System.Drawing.Point(394, 368);
            this.button_Guardar.Margin = new System.Windows.Forms.Padding(2);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(98, 35);
            this.button_Guardar.TabIndex = 38;
            this.button_Guardar.Text = "GUARDAR";
            this.button_Guardar.UseVisualStyleBackColor = false;
            // 
            // button_Nuevo
            // 
            this.button_Nuevo.BackColor = System.Drawing.Color.LightGreen;
            this.button_Nuevo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Nuevo.Location = new System.Drawing.Point(80, 368);
            this.button_Nuevo.Margin = new System.Windows.Forms.Padding(2);
            this.button_Nuevo.Name = "button_Nuevo";
            this.button_Nuevo.Size = new System.Drawing.Size(98, 35);
            this.button_Nuevo.TabIndex = 39;
            this.button_Nuevo.Text = "NUEVO";
            this.button_Nuevo.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button_Buscar);
            this.panel2.Controls.Add(this.textBox_BuscarVentas);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(70, 407);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 48);
            this.panel2.TabIndex = 36;
            // 
            // button_Buscar
            // 
            this.button_Buscar.BackColor = System.Drawing.Color.Thistle;
            this.button_Buscar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Buscar.Location = new System.Drawing.Point(970, 7);
            this.button_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(98, 33);
            this.button_Buscar.TabIndex = 2;
            this.button_Buscar.Text = "BUSCAR";
            this.button_Buscar.UseVisualStyleBackColor = false;
            // 
            // textBox_BuscarVentas
            // 
            this.textBox_BuscarVentas.Location = new System.Drawing.Point(486, 11);
            this.textBox_BuscarVentas.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_BuscarVentas.Name = "textBox_BuscarVentas";
            this.textBox_BuscarVentas.Size = new System.Drawing.Size(453, 20);
            this.textBox_BuscarVentas.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(453, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "BUSCAR POR: CODIGO, CLIENTE, METODO, COMPROBANTE, SUCURSAL...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_VerVentasAnuladas);
            this.panel1.Controls.Add(this.textBox_TotalVenta);
            this.panel1.Controls.Add(this.textBox_NumeroComprobante);
            this.panel1.Controls.Add(this.textBox_SerieComprobante);
            this.panel1.Controls.Add(this.comboBox_Receta);
            this.panel1.Controls.Add(this.comboBox_Sucursal);
            this.panel1.Controls.Add(this.comboBox_Personal);
            this.panel1.Controls.Add(this.comboBox_TipoComprobante);
            this.panel1.Controls.Add(this.comboBox_metodoPago);
            this.panel1.Controls.Add(this.comboBox_Cliente);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dateTimePicker_Fecha);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.LOTE);
            this.panel1.Controls.Add(this.button_VerVentas);
            this.panel1.Controls.Add(this.textBox_CodigoVenta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(67, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 307);
            this.panel1.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(471, 150);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 15);
            this.label15.TabIndex = 31;
            this.label15.Text = "TOTAL DE VENTA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(471, 111);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(182, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "NUMERO DE COMPROBANTE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(471, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "SERIE COMPROBANTE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "RECETA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "SUCURSAL";
            // 
            // dateTimePicker_Fecha
            // 
            this.dateTimePicker_Fecha.Location = new System.Drawing.Point(667, 26);
            this.dateTimePicker_Fecha.Name = "dateTimePicker_Fecha";
            this.dateTimePicker_Fecha.Size = new System.Drawing.Size(240, 20);
            this.dateTimePicker_Fecha.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(471, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "FECHA  DE VENTA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "PERSONAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = " TIPO DE COMPROBANTE";
            // 
            // LOTE
            // 
            this.LOTE.AutoSize = true;
            this.LOTE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOTE.Location = new System.Drawing.Point(8, 111);
            this.LOTE.Name = "LOTE";
            this.LOTE.Size = new System.Drawing.Size(119, 15);
            this.LOTE.TabIndex = 6;
            this.LOTE.Text = "METODO DE PAGO";
            // 
            // button_VerVentas
            // 
            this.button_VerVentas.BackColor = System.Drawing.Color.Thistle;
            this.button_VerVentas.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_VerVentas.Location = new System.Drawing.Point(927, 16);
            this.button_VerVentas.Margin = new System.Windows.Forms.Padding(2);
            this.button_VerVentas.Name = "button_VerVentas";
            this.button_VerVentas.Size = new System.Drawing.Size(154, 74);
            this.button_VerVentas.TabIndex = 5;
            this.button_VerVentas.Text = "VER VENTAS";
            this.button_VerVentas.UseVisualStyleBackColor = false;
            // 
            // textBox_CodigoVenta
            // 
            this.textBox_CodigoVenta.Location = new System.Drawing.Point(195, 26);
            this.textBox_CodigoVenta.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_CodigoVenta.Name = "textBox_CodigoVenta";
            this.textBox_CodigoVenta.Size = new System.Drawing.Size(238, 20);
            this.textBox_CodigoVenta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CODIGO DE VENTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = " CLIENTE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 22);
            this.label1.TabIndex = 34;
            this.label1.Text = "FORMULARIO DE VENTA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_Salir
            // 
            this.button_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Salir.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Salir.Location = new System.Drawing.Point(1041, 598);
            this.button_Salir.Margin = new System.Windows.Forms.Padding(2);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(112, 39);
            this.button_Salir.TabIndex = 44;
            this.button_Salir.Text = "SALIR";
            this.button_Salir.UseVisualStyleBackColor = false;
            // 
            // button_ExportarExcel
            // 
            this.button_ExportarExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_ExportarExcel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ExportarExcel.Location = new System.Drawing.Point(817, 598);
            this.button_ExportarExcel.Margin = new System.Windows.Forms.Padding(2);
            this.button_ExportarExcel.Name = "button_ExportarExcel";
            this.button_ExportarExcel.Size = new System.Drawing.Size(133, 39);
            this.button_ExportarExcel.TabIndex = 43;
            this.button_ExportarExcel.Text = "EXPORTAR EXCEL";
            this.button_ExportarExcel.UseVisualStyleBackColor = false;
            // 
            // ExportarPDF
            // 
            this.ExportarPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ExportarPDF.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportarPDF.Location = new System.Drawing.Point(604, 598);
            this.ExportarPDF.Margin = new System.Windows.Forms.Padding(2);
            this.ExportarPDF.Name = "ExportarPDF";
            this.ExportarPDF.Size = new System.Drawing.Size(112, 39);
            this.ExportarPDF.TabIndex = 42;
            this.ExportarPDF.Text = "EXPORTAR PDF";
            this.ExportarPDF.UseVisualStyleBackColor = false;
            // 
            // comboBox_Cliente
            // 
            this.comboBox_Cliente.FormattingEnabled = true;
            this.comboBox_Cliente.Location = new System.Drawing.Point(195, 69);
            this.comboBox_Cliente.Name = "comboBox_Cliente";
            this.comboBox_Cliente.Size = new System.Drawing.Size(238, 21);
            this.comboBox_Cliente.TabIndex = 34;
            // 
            // comboBox_metodoPago
            // 
            this.comboBox_metodoPago.FormattingEnabled = true;
            this.comboBox_metodoPago.Location = new System.Drawing.Point(195, 105);
            this.comboBox_metodoPago.Name = "comboBox_metodoPago";
            this.comboBox_metodoPago.Size = new System.Drawing.Size(238, 21);
            this.comboBox_metodoPago.TabIndex = 35;
            // 
            // comboBox_TipoComprobante
            // 
            this.comboBox_TipoComprobante.FormattingEnabled = true;
            this.comboBox_TipoComprobante.Location = new System.Drawing.Point(195, 141);
            this.comboBox_TipoComprobante.Name = "comboBox_TipoComprobante";
            this.comboBox_TipoComprobante.Size = new System.Drawing.Size(238, 21);
            this.comboBox_TipoComprobante.TabIndex = 36;
            // 
            // comboBox_Personal
            // 
            this.comboBox_Personal.FormattingEnabled = true;
            this.comboBox_Personal.Location = new System.Drawing.Point(195, 179);
            this.comboBox_Personal.Name = "comboBox_Personal";
            this.comboBox_Personal.Size = new System.Drawing.Size(238, 21);
            this.comboBox_Personal.TabIndex = 37;
            // 
            // comboBox_Sucursal
            // 
            this.comboBox_Sucursal.FormattingEnabled = true;
            this.comboBox_Sucursal.Location = new System.Drawing.Point(195, 217);
            this.comboBox_Sucursal.Name = "comboBox_Sucursal";
            this.comboBox_Sucursal.Size = new System.Drawing.Size(238, 21);
            this.comboBox_Sucursal.TabIndex = 38;
            // 
            // comboBox_Receta
            // 
            this.comboBox_Receta.FormattingEnabled = true;
            this.comboBox_Receta.Location = new System.Drawing.Point(195, 256);
            this.comboBox_Receta.Name = "comboBox_Receta";
            this.comboBox_Receta.Size = new System.Drawing.Size(238, 21);
            this.comboBox_Receta.TabIndex = 39;
            // 
            // textBox_SerieComprobante
            // 
            this.textBox_SerieComprobante.Location = new System.Drawing.Point(667, 70);
            this.textBox_SerieComprobante.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_SerieComprobante.Name = "textBox_SerieComprobante";
            this.textBox_SerieComprobante.Size = new System.Drawing.Size(238, 20);
            this.textBox_SerieComprobante.TabIndex = 40;
            // 
            // textBox_NumeroComprobante
            // 
            this.textBox_NumeroComprobante.Location = new System.Drawing.Point(667, 106);
            this.textBox_NumeroComprobante.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_NumeroComprobante.Name = "textBox_NumeroComprobante";
            this.textBox_NumeroComprobante.Size = new System.Drawing.Size(238, 20);
            this.textBox_NumeroComprobante.TabIndex = 41;
            // 
            // textBox_TotalVenta
            // 
            this.textBox_TotalVenta.Location = new System.Drawing.Point(667, 145);
            this.textBox_TotalVenta.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TotalVenta.Name = "textBox_TotalVenta";
            this.textBox_TotalVenta.Size = new System.Drawing.Size(238, 20);
            this.textBox_TotalVenta.TabIndex = 42;
            // 
            // button_VerVentasAnuladas
            // 
            this.button_VerVentasAnuladas.BackColor = System.Drawing.Color.Thistle;
            this.button_VerVentasAnuladas.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_VerVentasAnuladas.Location = new System.Drawing.Point(927, 141);
            this.button_VerVentasAnuladas.Margin = new System.Windows.Forms.Padding(2);
            this.button_VerVentasAnuladas.Name = "button_VerVentasAnuladas";
            this.button_VerVentasAnuladas.Size = new System.Drawing.Size(154, 74);
            this.button_VerVentasAnuladas.TabIndex = 43;
            this.button_VerVentasAnuladas.Text = "VER VENTAS ANULADAS";
            this.button_VerVentasAnuladas.UseVisualStyleBackColor = false;
            // 
            // Form_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1214, 645);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.button_ExportarExcel);
            this.Controls.Add(this.ExportarPDF);
            this.Controls.Add(this.button_DarBaja);
            this.Controls.Add(this.dataGridView_MostrarVentas);
            this.Controls.Add(this.button_Modificar);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.button_Nuevo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form_Venta";
            this.Text = "Form_Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MostrarVentas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_DarBaja;
        private System.Windows.Forms.DataGridView dataGridView_MostrarVentas;
        private System.Windows.Forms.Button button_Modificar;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Nuevo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.TextBox textBox_BuscarVentas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Fecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LOTE;
        private System.Windows.Forms.Button button_VerVentas;
        private System.Windows.Forms.TextBox textBox_CodigoVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Salir;
        private System.Windows.Forms.Button button_ExportarExcel;
        private System.Windows.Forms.Button ExportarPDF;
        private System.Windows.Forms.TextBox textBox_TotalVenta;
        private System.Windows.Forms.TextBox textBox_NumeroComprobante;
        private System.Windows.Forms.TextBox textBox_SerieComprobante;
        private System.Windows.Forms.ComboBox comboBox_Receta;
        private System.Windows.Forms.ComboBox comboBox_Sucursal;
        private System.Windows.Forms.ComboBox comboBox_Personal;
        private System.Windows.Forms.ComboBox comboBox_TipoComprobante;
        private System.Windows.Forms.ComboBox comboBox_metodoPago;
        private System.Windows.Forms.ComboBox comboBox_Cliente;
        private System.Windows.Forms.Button button_VerVentasAnuladas;
    }
}