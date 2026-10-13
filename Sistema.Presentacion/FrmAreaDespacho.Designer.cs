namespace Sistema.Presentacion
{
    partial class FrmAreaDespacho
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
            tabPage4 = new TabPage();
            label3 = new Label();
            BtnCancelar = new Button();
            BtnRetornar = new Button();
            BtnGuardar = new Button();
            TxtDescripcion = new TextBox();
            label1 = new Label();
            LblTotal = new Label();
            DgvListado = new DataGridView();
            BtnBuscar = new Button();
            TxtBuscar = new TextBox();
            BtnReporte = new Button();
            tabPage3 = new TabPage();
            BtnSalir = new Button();
            BtnEliminar = new Button();
            BtnActualizar = new Button();
            BtnNuevo = new Button();
            TabPrincipal = new TabControl();
            label4 = new Label();
            TxtImpresora = new TextBox();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListado).BeginInit();
            tabPage3.SuspendLayout();
            TabPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(tabControl1);
            panel2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(12, -13);
            panel2.Name = "panel2";
            panel2.Size = new Size(1241, 146);
            panel2.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(668, 51);
            label2.TabIndex = 1;
            label2.Text = "Modulo de Area de Despacho";
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
            // tabPage4
            // 
            tabPage4.Controls.Add(TxtImpresora);
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
            tabPage4.Size = new Size(1233, 365);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Mantenimiento";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(447, 133);
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
            BtnCancelar.Location = new Point(681, 164);
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
            BtnRetornar.Location = new Point(561, 164);
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
            BtnGuardar.Location = new Point(441, 164);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(114, 52);
            BtnGuardar.TabIndex = 6;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Location = new Point(441, 59);
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(354, 30);
            TxtDescripcion.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 62);
            label1.Name = "label1";
            label1.Size = new Size(203, 21);
            label1.TabIndex = 0;
            label1.Text = "Area de Despacho(*):";
            // 
            // LblTotal
            // 
            LblTotal.AutoSize = true;
            LblTotal.Location = new Point(984, 333);
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
            DgvListado.CellClick += DgvListado_CellClick;
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
            // TxtBuscar
            // 
            TxtBuscar.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtBuscar.Location = new Point(0, 6);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(804, 36);
            TxtBuscar.TabIndex = 0;
            // 
            // BtnReporte
            // 
            BtnReporte.BackColor = Color.FromArgb(226, 246, 245);
            BtnReporte.FlatAppearance.BorderColor = Color.FromArgb(83, 198, 198);
            BtnReporte.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            BtnReporte.FlatStyle = FlatStyle.Flat;
            BtnReporte.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            BtnReporte.ForeColor = Color.Black;
            BtnReporte.Location = new Point(477, 540);
            BtnReporte.Name = "BtnReporte";
            BtnReporte.Size = new Size(114, 52);
            BtnReporte.TabIndex = 22;
            BtnReporte.Text = "Reporte";
            BtnReporte.UseVisualStyleBackColor = false;
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
            tabPage3.Size = new Size(1233, 365);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Consulta";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.FromArgb(226, 246, 245);
            BtnSalir.FlatAppearance.BorderColor = Color.FromArgb(83, 198, 198);
            BtnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            BtnSalir.ForeColor = Color.Black;
            BtnSalir.Location = new Point(628, 540);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(114, 52);
            BtnSalir.TabIndex = 23;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.FromArgb(226, 246, 245);
            BtnEliminar.FlatAppearance.BorderColor = Color.FromArgb(83, 198, 198);
            BtnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            BtnEliminar.FlatStyle = FlatStyle.Flat;
            BtnEliminar.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            BtnEliminar.ForeColor = Color.Black;
            BtnEliminar.Location = new Point(326, 540);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(114, 52);
            BtnEliminar.TabIndex = 21;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnActualizar
            // 
            BtnActualizar.BackColor = Color.FromArgb(226, 246, 245);
            BtnActualizar.FlatAppearance.BorderColor = Color.FromArgb(83, 198, 198);
            BtnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            BtnActualizar.FlatStyle = FlatStyle.Flat;
            BtnActualizar.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            BtnActualizar.ForeColor = Color.Black;
            BtnActualizar.Location = new Point(175, 540);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(114, 52);
            BtnActualizar.TabIndex = 20;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = false;
            BtnActualizar.Click += BtnActualizar_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackColor = Color.FromArgb(226, 246, 245);
            BtnNuevo.FlatAppearance.BorderColor = Color.FromArgb(83, 198, 198);
            BtnNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            BtnNuevo.FlatStyle = FlatStyle.Flat;
            BtnNuevo.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            BtnNuevo.ForeColor = Color.Black;
            BtnNuevo.Location = new Point(24, 540);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(114, 52);
            BtnNuevo.TabIndex = 19;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = false;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // TabPrincipal
            // 
            TabPrincipal.Controls.Add(tabPage3);
            TabPrincipal.Controls.Add(tabPage4);
            TabPrincipal.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabPrincipal.Location = new Point(12, 135);
            TabPrincipal.Name = "TabPrincipal";
            TabPrincipal.SelectedIndex = 0;
            TabPrincipal.Size = new Size(1241, 399);
            TabPrincipal.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(314, 97);
            label4.Name = "label4";
            label4.Size = new Size(121, 21);
            label4.TabIndex = 10;
            label4.Text = "Impresora(*):";
            // 
            // TxtImpresora
            // 
            TxtImpresora.Location = new Point(441, 94);
            TxtImpresora.Name = "TxtImpresora";
            TxtImpresora.Size = new Size(354, 30);
            TxtImpresora.TabIndex = 11;
            // 
            // FrmAreaDespacho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 578);
            Controls.Add(panel2);
            Controls.Add(BtnReporte);
            Controls.Add(BtnSalir);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnActualizar);
            Controls.Add(BtnNuevo);
            Controls.Add(TabPrincipal);
            Name = "FrmAreaDespacho";
            Text = "FrmAreaDespacho";
            Load += FrmAreaDespacho_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListado).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            TabPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private Label label3;
        private Button BtnCancelar;
        private Button BtnRetornar;
        private Button BtnGuardar;
        private TextBox TxtDescripcion;
        private Label label1;
        private Label LblTotal;
        private DataGridView DgvListado;
        private Button BtnBuscar;
        private TextBox TxtBuscar;
        private Button BtnReporte;
        private TabPage tabPage3;
        private Button BtnSalir;
        private Button BtnEliminar;
        private Button BtnActualizar;
        private Button BtnNuevo;
        private TabControl TabPrincipal;
        private TextBox TxtImpresora;
        private Label label4;
    }
}