namespace Sistema.Presentacion
{
    partial class FrmProducto
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
            panel2 = new Panel();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            BtnReporte = new Button();
            BtnActualizar = new Button();
            BtnEliminar = new Button();
            TxtBuscar = new TextBox();
            label4 = new Label();
            tabPage3 = new TabPage();
            LblTotal = new Label();
            DgvListado = new DataGridView();
            BtnBuscar = new Button();
            label3 = new Label();
            BtnCancelar = new Button();
            BtnRetornar = new Button();
            BtnGuardar = new Button();
            TabPrincipal = new TabControl();
            tabPage4 = new TabPage();
            BtnSeleccionarImagen = new Button();
            dgvPuntosVenta = new DataGridView();
            groupBox1 = new GroupBox();
            pictureBoxImagenProducto = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            TxtDescripcion = new TextBox();
            label1 = new Label();
            BtnNuevo = new Button();
            BtnSalir = new Button();
            TxtPrecio = new TextBox();
            TxtObservaciones = new TextBox();
            label9 = new Label();
            label8 = new Label();
            CmbAreaDespacho = new ComboBox();
            CmbMarca = new ComboBox();
            CmbSubFamilia = new ComboBox();
            CmbUnidadesMedida = new ComboBox();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListado).BeginInit();
            TabPrincipal.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPuntosVenta).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagenProducto).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(tabControl1);
            panel2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(19, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1241, 146);
            panel2.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(456, 51);
            label2.TabIndex = 1;
            label2.Text = "Modulo de Producto";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 152);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(281, 125);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 63);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(273, 58);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 63);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(273, 58);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnReporte
            // 
            BtnReporte.BackColor = Color.FromArgb(226, 246, 245);
            BtnReporte.FlatAppearance.BorderColor = Color.FromArgb(83, 198, 198);
            BtnReporte.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            BtnReporte.FlatStyle = FlatStyle.Flat;
            BtnReporte.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            BtnReporte.ForeColor = Color.Black;
            BtnReporte.Location = new Point(476, 537);
            BtnReporte.Name = "BtnReporte";
            BtnReporte.Size = new Size(114, 52);
            BtnReporte.TabIndex = 29;
            BtnReporte.Text = "Reporte";
            BtnReporte.UseVisualStyleBackColor = false;
            // 
            // BtnActualizar
            // 
            BtnActualizar.BackColor = Color.FromArgb(226, 246, 245);
            BtnActualizar.FlatAppearance.BorderColor = Color.FromArgb(83, 198, 198);
            BtnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            BtnActualizar.FlatStyle = FlatStyle.Flat;
            BtnActualizar.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            BtnActualizar.ForeColor = Color.Black;
            BtnActualizar.Location = new Point(175, 537);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(114, 52);
            BtnActualizar.TabIndex = 27;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = false;
            BtnActualizar.Click += BtnActualizar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.FromArgb(226, 246, 245);
            BtnEliminar.FlatAppearance.BorderColor = Color.FromArgb(83, 198, 198);
            BtnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            BtnEliminar.FlatStyle = FlatStyle.Flat;
            BtnEliminar.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            BtnEliminar.ForeColor = Color.Black;
            BtnEliminar.Location = new Point(324, 537);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(114, 52);
            BtnEliminar.TabIndex = 28;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtBuscar.Location = new Point(0, 6);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(804, 36);
            TxtBuscar.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 16);
            label4.Name = "label4";
            label4.Size = new Size(116, 21);
            label4.TabIndex = 10;
            label4.Text = "Producto(*):";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(LblTotal);
            tabPage3.Controls.Add(DgvListado);
            tabPage3.Controls.Add(BtnBuscar);
            tabPage3.Controls.Add(TxtBuscar);
            tabPage3.Location = new Point(4, 30);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1335, 345);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Consulta";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // LblTotal
            // 
            LblTotal.AutoSize = true;
            LblTotal.Location = new Point(990, 308);
            LblTotal.Name = "LblTotal";
            LblTotal.Size = new Size(138, 21);
            LblTotal.TabIndex = 4;
            LblTotal.Text = "Total Registros:";
            // 
            // DgvListado
            // 
            DgvListado.AllowUserToAddRows = false;
            DgvListado.AllowUserToDeleteRows = false;
            DgvListado.AllowUserToOrderColumns = true;
            DgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListado.Location = new Point(3, 48);
            DgvListado.Name = "DgvListado";
            DgvListado.ReadOnly = true;
            DgvListado.RowHeadersWidth = 51;
            DgvListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListado.Size = new Size(1230, 257);
            DgvListado.TabIndex = 3;
            DgvListado.CellDoubleClick += DgvListado_CellDoubleClick;
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackColor = Color.SteelBlue;
            BtnBuscar.FlatAppearance.BorderSize = 0;
            BtnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            BtnBuscar.FlatStyle = FlatStyle.Flat;
            BtnBuscar.ForeColor = SystemColors.ControlLightLight;
            BtnBuscar.Location = new Point(817, 6);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(94, 39);
            BtnBuscar.TabIndex = 1;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(213, 266);
            label3.Name = "label3";
            label3.Size = new Size(240, 17);
            label3.TabIndex = 9;
            label3.Text = "Los campos con (*) son obligatorios";
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.FromArgb(192, 0, 9);
            BtnCancelar.FlatAppearance.BorderColor = Color.FromArgb(83, 198, 198);
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            BtnCancelar.ForeColor = Color.White;
            BtnCancelar.Location = new Point(412, 293);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(114, 52);
            BtnCancelar.TabIndex = 8;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnRetornar
            // 
            BtnRetornar.BackColor = Color.Teal;
            BtnRetornar.FlatAppearance.BorderColor = Color.FromArgb(83, 198, 198);
            BtnRetornar.FlatAppearance.BorderSize = 0;
            BtnRetornar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            BtnRetornar.FlatStyle = FlatStyle.Flat;
            BtnRetornar.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            BtnRetornar.ForeColor = Color.White;
            BtnRetornar.Location = new Point(272, 290);
            BtnRetornar.Name = "BtnRetornar";
            BtnRetornar.Size = new Size(114, 52);
            BtnRetornar.TabIndex = 7;
            BtnRetornar.Text = "Retornar";
            BtnRetornar.UseVisualStyleBackColor = false;
            BtnRetornar.Click += BtnRetornar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.SteelBlue;
            BtnGuardar.FlatAppearance.BorderColor = Color.FromArgb(83, 198, 198);
            BtnGuardar.FlatAppearance.BorderSize = 0;
            BtnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            BtnGuardar.FlatStyle = FlatStyle.Flat;
            BtnGuardar.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            BtnGuardar.ForeColor = Color.White;
            BtnGuardar.Location = new Point(140, 290);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(114, 52);
            BtnGuardar.TabIndex = 6;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // TabPrincipal
            // 
            TabPrincipal.Controls.Add(tabPage3);
            TabPrincipal.Controls.Add(tabPage4);
            TabPrincipal.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabPrincipal.Location = new Point(19, 152);
            TabPrincipal.Name = "TabPrincipal";
            TabPrincipal.SelectedIndex = 0;
            TabPrincipal.Size = new Size(1343, 379);
            TabPrincipal.TabIndex = 25;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(BtnSeleccionarImagen);
            tabPage4.Controls.Add(dgvPuntosVenta);
            tabPage4.Controls.Add(groupBox1);
            tabPage4.Controls.Add(TxtPrecio);
            tabPage4.Controls.Add(TxtObservaciones);
            tabPage4.Controls.Add(CmbMarca);
            tabPage4.Controls.Add(CmbSubFamilia);
            tabPage4.Controls.Add(CmbAreaDespacho);
            tabPage4.Controls.Add(CmbUnidadesMedida);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(label4);
            tabPage4.Controls.Add(label3);
            tabPage4.Controls.Add(BtnCancelar);
            tabPage4.Controls.Add(BtnRetornar);
            tabPage4.Controls.Add(BtnGuardar);
            tabPage4.Controls.Add(TxtDescripcion);
            tabPage4.Controls.Add(label1);
            tabPage4.Location = new Point(4, 30);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1335, 345);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Mantenimiento";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // BtnSeleccionarImagen
            // 
            BtnSeleccionarImagen.BackColor = Color.Teal;
            BtnSeleccionarImagen.FlatAppearance.BorderColor = Color.FromArgb(83, 198, 198);
            BtnSeleccionarImagen.FlatAppearance.BorderSize = 0;
            BtnSeleccionarImagen.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            BtnSeleccionarImagen.FlatStyle = FlatStyle.Flat;
            BtnSeleccionarImagen.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            BtnSeleccionarImagen.ForeColor = Color.White;
            BtnSeleccionarImagen.Location = new Point(601, 287);
            BtnSeleccionarImagen.Name = "BtnSeleccionarImagen";
            BtnSeleccionarImagen.Size = new Size(114, 52);
            BtnSeleccionarImagen.TabIndex = 25;
            BtnSeleccionarImagen.Text = "Seleccionar Imagen";
            BtnSeleccionarImagen.UseVisualStyleBackColor = false;
            BtnSeleccionarImagen.Click += BtnSeleccionarImagen_Click;
            // 
            // dgvPuntosVenta
            // 
            dgvPuntosVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPuntosVenta.Location = new Point(952, 32);
            dgvPuntosVenta.Name = "dgvPuntosVenta";
            dgvPuntosVenta.RowHeadersWidth = 51;
            dgvPuntosVenta.Size = new Size(368, 257);
            dgvPuntosVenta.TabIndex = 24;
            dgvPuntosVenta.CellContentClick += dgvPuntosVenta_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBoxImagenProducto);
            groupBox1.Location = new Point(595, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 280);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Imagenes Producto";
            // 
            // pictureBoxImagenProducto
            // 
            pictureBoxImagenProducto.Location = new Point(6, 33);
            pictureBoxImagenProducto.Name = "pictureBoxImagenProducto";
            pictureBoxImagenProducto.Size = new Size(325, 234);
            pictureBoxImagenProducto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImagenProducto.TabIndex = 24;
            pictureBoxImagenProducto.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 161);
            label7.Name = "label7";
            label7.Size = new Size(174, 21);
            label7.TabIndex = 14;
            label7.Text = "Area Despacho(*):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 125);
            label6.Name = "label6";
            label6.Size = new Size(198, 21);
            label6.TabIndex = 13;
            label6.Text = "Unidad de Medida(*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 88);
            label5.Name = "label5";
            label5.Size = new Size(125, 21);
            label5.TabIndex = 12;
            label5.Text = "SubFamilia(*):";
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Location = new Point(213, 13);
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(354, 30);
            TxtDescripcion.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 53);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 0;
            label1.Text = "Marca(*):";
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackColor = Color.FromArgb(226, 246, 245);
            BtnNuevo.FlatAppearance.BorderColor = Color.FromArgb(83, 198, 198);
            BtnNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            BtnNuevo.FlatStyle = FlatStyle.Flat;
            BtnNuevo.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            BtnNuevo.ForeColor = Color.Black;
            BtnNuevo.Location = new Point(23, 537);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(114, 52);
            BtnNuevo.TabIndex = 26;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = false;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.FromArgb(226, 246, 245);
            BtnSalir.FlatAppearance.BorderColor = Color.FromArgb(83, 198, 198);
            BtnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            BtnSalir.ForeColor = Color.Black;
            BtnSalir.Location = new Point(624, 537);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(114, 52);
            BtnSalir.TabIndex = 30;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // TxtPrecio
            // 
            TxtPrecio.Location = new Point(213, 196);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(173, 30);
            TxtPrecio.TabIndex = 22;
            TxtPrecio.Text = "0.00";
            TxtPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtObservaciones
            // 
            TxtObservaciones.Location = new Point(213, 233);
            TxtObservaciones.Name = "TxtObservaciones";
            TxtObservaciones.Size = new Size(354, 30);
            TxtObservaciones.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 233);
            label9.Name = "label9";
            label9.Size = new Size(166, 21);
            label9.TabIndex = 16;
            label9.Text = "Observaciones(*):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(109, 196);
            label8.Name = "label8";
            label8.Size = new Size(89, 21);
            label8.TabIndex = 15;
            label8.Text = "Precio(*):";
            // 
            // CmbAreaDespacho
            // 
            CmbAreaDespacho.FormattingEnabled = true;
            CmbAreaDespacho.Location = new Point(213, 161);
            CmbAreaDespacho.Name = "CmbAreaDespacho";
            CmbAreaDespacho.Size = new Size(354, 29);
            CmbAreaDespacho.TabIndex = 18;
            // 
            // CmbMarca
            // 
            CmbMarca.FormattingEnabled = true;
            CmbMarca.Location = new Point(213, 50);
            CmbMarca.Name = "CmbMarca";
            CmbMarca.Size = new Size(354, 29);
            CmbMarca.TabIndex = 20;
            // 
            // CmbSubFamilia
            // 
            CmbSubFamilia.FormattingEnabled = true;
            CmbSubFamilia.Location = new Point(213, 88);
            CmbSubFamilia.Name = "CmbSubFamilia";
            CmbSubFamilia.Size = new Size(354, 29);
            CmbSubFamilia.TabIndex = 19;
            // 
            // CmbUnidadesMedida
            // 
            CmbUnidadesMedida.FormattingEnabled = true;
            CmbUnidadesMedida.Location = new Point(213, 125);
            CmbUnidadesMedida.Name = "CmbUnidadesMedida";
            CmbUnidadesMedida.Size = new Size(354, 29);
            CmbUnidadesMedida.TabIndex = 17;
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1404, 679);
            Controls.Add(panel2);
            Controls.Add(BtnReporte);
            Controls.Add(BtnActualizar);
            Controls.Add(BtnEliminar);
            Controls.Add(TabPrincipal);
            Controls.Add(BtnNuevo);
            Controls.Add(BtnSalir);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProducto";
            Text = "FrmProducto";
            Load += FrmProducto_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListado).EndInit();
            TabPrincipal.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPuntosVenta).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagenProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button BtnReporte;
        private Button BtnActualizar;
        private Button BtnEliminar;
        private TextBox TxtBuscar;
        private Label label4;
        private TabPage tabPage3;
        private Label LblTotal;
        private DataGridView DgvListado;
        private Button BtnBuscar;
        private Label label3;
        private Button BtnCancelar;
        private Button BtnRetornar;
        private Button BtnGuardar;
        private TabControl TabPrincipal;
        private TabPage tabPage4;
        private TextBox TxtDescripcion;
        private Label label1;
        private Button BtnNuevo;
        private Button BtnSalir;
        private Label label7;
        private Label label6;
        private Label label5;
        private GroupBox groupBox1;
        private PictureBox pictureBoxImagenProducto;
        private DataGridView dgvPuntosVenta;
        private Button BtnSeleccionarImagen;
        private TextBox TxtPrecio;
        private TextBox TxtObservaciones;
        private Label label9;
        private Label label8;
        private ComboBox CmbMarca;
        private ComboBox CmbSubFamilia;
        private ComboBox CmbAreaDespacho;
        private ComboBox CmbUnidadesMedida;
        private TextBox txtMovil;
        private TextBox txtEmail;
    }
}