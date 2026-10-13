namespace Sistema.Presentacion
{
    partial class FrmDashBoard
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
            components = new System.ComponentModel.Container();
            panelMenu = new Panel();
            btnSalir = new Button();
            panelDatosMaestros = new Panel();
            btnMesas = new Button();
            btnAreaDespacho = new Button();
            btnPuntosVenta = new Button();
            btnFamilias = new Button();
            btnSubFamilia = new Button();
            btnUnidadesMedida = new Button();
            btnMarcas = new Button();
            btnProductos = new Button();
            btnDatosMaestros = new Button();
            panelReportes = new Panel();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            btnReportes = new Button();
            panelProcesos = new Panel();
            btnCliente = new Button();
            btnCierreTurnos = new Button();
            btnRegistrarPedidos = new Button();
            btnProcesos = new Button();
            btnDashboard = new Button();
            panelLogo = new Panel();
            pictureBoxLogo = new PictureBox();
            panelSuperior = new Panel();
            lblModuloActual = new Label();
            label1 = new Label();
            panelInferior = new Panel();
            groupBox2 = new GroupBox();
            lblFecha = new Label();
            lblHora = new Label();
            panelPrincipal = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            panelDatosMaestros.SuspendLayout();
            panelReportes.SuspendLayout();
            panelProcesos.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelSuperior.SuspendLayout();
            panelInferior.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.FromArgb(44, 105, 141);
            panelMenu.Controls.Add(btnSalir);
            panelMenu.Controls.Add(panelDatosMaestros);
            panelMenu.Controls.Add(btnDatosMaestros);
            panelMenu.Controls.Add(panelReportes);
            panelMenu.Controls.Add(btnReportes);
            panelMenu.Controls.Add(panelProcesos);
            panelMenu.Controls.Add(btnProcesos);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(294, 843);
            panelMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Top;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            btnSalir.Location = new Point(0, 1143);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(11, 0, 0, 0);
            btnSalir.Size = new Size(273, 55);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Cerrar sesión";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // panelDatosMaestros
            // 
            panelDatosMaestros.BackColor = Color.FromArgb(86, 232, 232);
            panelDatosMaestros.Controls.Add(btnMesas);
            panelDatosMaestros.Controls.Add(btnAreaDespacho);
            panelDatosMaestros.Controls.Add(btnPuntosVenta);
            panelDatosMaestros.Controls.Add(btnFamilias);
            panelDatosMaestros.Controls.Add(btnSubFamilia);
            panelDatosMaestros.Controls.Add(btnUnidadesMedida);
            panelDatosMaestros.Controls.Add(btnMarcas);
            panelDatosMaestros.Controls.Add(btnProductos);
            panelDatosMaestros.Dock = DockStyle.Top;
            panelDatosMaestros.Location = new Point(0, 710);
            panelDatosMaestros.Name = "panelDatosMaestros";
            panelDatosMaestros.Size = new Size(273, 433);
            panelDatosMaestros.TabIndex = 6;
            // 
            // btnMesas
            // 
            btnMesas.Dock = DockStyle.Top;
            btnMesas.FlatAppearance.BorderSize = 0;
            btnMesas.FlatStyle = FlatStyle.Flat;
            btnMesas.Font = new Font("Century Gothic", 9F);
            btnMesas.Location = new Point(0, 385);
            btnMesas.Name = "btnMesas";
            btnMesas.Padding = new Padding(40, 0, 0, 0);
            btnMesas.Size = new Size(273, 55);
            btnMesas.TabIndex = 9;
            btnMesas.Text = "Mesas";
            btnMesas.TextAlign = ContentAlignment.MiddleLeft;
            btnMesas.UseVisualStyleBackColor = true;
            btnMesas.Click += btnMesas_Click;
            // 
            // btnAreaDespacho
            // 
            btnAreaDespacho.Dock = DockStyle.Top;
            btnAreaDespacho.FlatAppearance.BorderSize = 0;
            btnAreaDespacho.FlatStyle = FlatStyle.Flat;
            btnAreaDespacho.Font = new Font("Century Gothic", 9F);
            btnAreaDespacho.Location = new Point(0, 330);
            btnAreaDespacho.Name = "btnAreaDespacho";
            btnAreaDespacho.Padding = new Padding(40, 0, 0, 0);
            btnAreaDespacho.Size = new Size(273, 55);
            btnAreaDespacho.TabIndex = 8;
            btnAreaDespacho.Text = "Areas de despacho";
            btnAreaDespacho.TextAlign = ContentAlignment.MiddleLeft;
            btnAreaDespacho.UseVisualStyleBackColor = true;
            btnAreaDespacho.Click += btnAreaDespacho_Click;
            // 
            // btnPuntosVenta
            // 
            btnPuntosVenta.Dock = DockStyle.Top;
            btnPuntosVenta.FlatAppearance.BorderSize = 0;
            btnPuntosVenta.FlatStyle = FlatStyle.Flat;
            btnPuntosVenta.Font = new Font("Century Gothic", 9F);
            btnPuntosVenta.Location = new Point(0, 275);
            btnPuntosVenta.Name = "btnPuntosVenta";
            btnPuntosVenta.Padding = new Padding(40, 0, 0, 0);
            btnPuntosVenta.Size = new Size(273, 55);
            btnPuntosVenta.TabIndex = 7;
            btnPuntosVenta.Text = "Puntos de Venta";
            btnPuntosVenta.TextAlign = ContentAlignment.MiddleLeft;
            btnPuntosVenta.UseVisualStyleBackColor = true;
            btnPuntosVenta.Click += btnPuntosVenta_Click;
            // 
            // btnFamilias
            // 
            btnFamilias.Dock = DockStyle.Top;
            btnFamilias.FlatAppearance.BorderSize = 0;
            btnFamilias.FlatStyle = FlatStyle.Flat;
            btnFamilias.Font = new Font("Century Gothic", 9F);
            btnFamilias.Location = new Point(0, 220);
            btnFamilias.Name = "btnFamilias";
            btnFamilias.Padding = new Padding(40, 0, 0, 0);
            btnFamilias.Size = new Size(273, 55);
            btnFamilias.TabIndex = 6;
            btnFamilias.Text = "Familias";
            btnFamilias.TextAlign = ContentAlignment.MiddleLeft;
            btnFamilias.UseVisualStyleBackColor = true;
            btnFamilias.Click += btnFamilias_Click;
            // 
            // btnSubFamilia
            // 
            btnSubFamilia.Dock = DockStyle.Top;
            btnSubFamilia.FlatAppearance.BorderSize = 0;
            btnSubFamilia.FlatStyle = FlatStyle.Flat;
            btnSubFamilia.Font = new Font("Century Gothic", 9F);
            btnSubFamilia.Location = new Point(0, 165);
            btnSubFamilia.Name = "btnSubFamilia";
            btnSubFamilia.Padding = new Padding(40, 0, 0, 0);
            btnSubFamilia.Size = new Size(273, 55);
            btnSubFamilia.TabIndex = 5;
            btnSubFamilia.Text = "Sub Familias";
            btnSubFamilia.TextAlign = ContentAlignment.MiddleLeft;
            btnSubFamilia.UseVisualStyleBackColor = true;
            btnSubFamilia.Click += btnSubFamilia_Click;
            // 
            // btnUnidadesMedida
            // 
            btnUnidadesMedida.Dock = DockStyle.Top;
            btnUnidadesMedida.FlatAppearance.BorderSize = 0;
            btnUnidadesMedida.FlatStyle = FlatStyle.Flat;
            btnUnidadesMedida.Font = new Font("Century Gothic", 9F);
            btnUnidadesMedida.Location = new Point(0, 110);
            btnUnidadesMedida.Name = "btnUnidadesMedida";
            btnUnidadesMedida.Padding = new Padding(40, 0, 0, 0);
            btnUnidadesMedida.Size = new Size(273, 55);
            btnUnidadesMedida.TabIndex = 4;
            btnUnidadesMedida.Text = "Unidades de Medida";
            btnUnidadesMedida.TextAlign = ContentAlignment.MiddleLeft;
            btnUnidadesMedida.UseVisualStyleBackColor = true;
            btnUnidadesMedida.Click += btnUnidadesMedida_Click;
            // 
            // btnMarcas
            // 
            btnMarcas.Dock = DockStyle.Top;
            btnMarcas.FlatAppearance.BorderSize = 0;
            btnMarcas.FlatStyle = FlatStyle.Flat;
            btnMarcas.Font = new Font("Century Gothic", 9F);
            btnMarcas.Location = new Point(0, 55);
            btnMarcas.Name = "btnMarcas";
            btnMarcas.Padding = new Padding(40, 0, 0, 0);
            btnMarcas.Size = new Size(273, 55);
            btnMarcas.TabIndex = 3;
            btnMarcas.Text = "Marcas";
            btnMarcas.TextAlign = ContentAlignment.MiddleLeft;
            btnMarcas.UseVisualStyleBackColor = true;
            btnMarcas.Click += btnMarcas_Click;
            // 
            // btnProductos
            // 
            btnProductos.Dock = DockStyle.Top;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Century Gothic", 9F);
            btnProductos.Location = new Point(0, 0);
            btnProductos.Name = "btnProductos";
            btnProductos.Padding = new Padding(40, 0, 0, 0);
            btnProductos.Size = new Size(273, 55);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnDatosMaestros
            // 
            btnDatosMaestros.Dock = DockStyle.Top;
            btnDatosMaestros.FlatAppearance.BorderSize = 0;
            btnDatosMaestros.FlatStyle = FlatStyle.Flat;
            btnDatosMaestros.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            btnDatosMaestros.Location = new Point(0, 655);
            btnDatosMaestros.Name = "btnDatosMaestros";
            btnDatosMaestros.Padding = new Padding(11, 0, 0, 0);
            btnDatosMaestros.Size = new Size(273, 55);
            btnDatosMaestros.TabIndex = 5;
            btnDatosMaestros.Text = "Datos Maestros";
            btnDatosMaestros.TextAlign = ContentAlignment.MiddleLeft;
            btnDatosMaestros.UseVisualStyleBackColor = true;
            btnDatosMaestros.Click += btnDatosMaestros_Click;
            // 
            // panelReportes
            // 
            panelReportes.BackColor = Color.FromArgb(86, 232, 232);
            panelReportes.Controls.Add(button4);
            panelReportes.Controls.Add(button5);
            panelReportes.Controls.Add(button6);
            panelReportes.Dock = DockStyle.Top;
            panelReportes.Location = new Point(0, 487);
            panelReportes.Name = "panelReportes";
            panelReportes.Size = new Size(273, 168);
            panelReportes.TabIndex = 4;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 9F);
            button4.Location = new Point(0, 110);
            button4.Name = "button4";
            button4.Padding = new Padding(40, 0, 0, 0);
            button4.Size = new Size(273, 55);
            button4.TabIndex = 4;
            button4.Text = "Reporte 3";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 9F);
            button5.Location = new Point(0, 55);
            button5.Name = "button5";
            button5.Padding = new Padding(40, 0, 0, 0);
            button5.Size = new Size(273, 55);
            button5.TabIndex = 3;
            button5.Text = "Reporte 2";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century Gothic", 9F);
            button6.Location = new Point(0, 0);
            button6.Name = "button6";
            button6.Padding = new Padding(40, 0, 0, 0);
            button6.Size = new Size(273, 55);
            button6.TabIndex = 2;
            button6.Text = "Reporte 1";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            btnReportes.ForeColor = SystemColors.ControlText;
            btnReportes.Location = new Point(0, 432);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(11, 0, 0, 0);
            btnReportes.Size = new Size(273, 55);
            btnReportes.TabIndex = 3;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // panelProcesos
            // 
            panelProcesos.BackColor = Color.FromArgb(86, 232, 232);
            panelProcesos.Controls.Add(btnCliente);
            panelProcesos.Controls.Add(btnCierreTurnos);
            panelProcesos.Controls.Add(btnRegistrarPedidos);
            panelProcesos.Dock = DockStyle.Top;
            panelProcesos.Location = new Point(0, 264);
            panelProcesos.Name = "panelProcesos";
            panelProcesos.Size = new Size(273, 168);
            panelProcesos.TabIndex = 2;
            // 
            // btnCliente
            // 
            btnCliente.Dock = DockStyle.Top;
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Font = new Font("Century Gothic", 9F);
            btnCliente.Location = new Point(0, 110);
            btnCliente.Name = "btnCliente";
            btnCliente.Padding = new Padding(40, 0, 0, 0);
            btnCliente.Size = new Size(273, 55);
            btnCliente.TabIndex = 4;
            btnCliente.Text = "Gestion de Clientes";
            btnCliente.TextAlign = ContentAlignment.MiddleLeft;
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click_1;
            // 
            // btnCierreTurnos
            // 
            btnCierreTurnos.Dock = DockStyle.Top;
            btnCierreTurnos.FlatAppearance.BorderSize = 0;
            btnCierreTurnos.FlatStyle = FlatStyle.Flat;
            btnCierreTurnos.Font = new Font("Century Gothic", 9F);
            btnCierreTurnos.Location = new Point(0, 55);
            btnCierreTurnos.Name = "btnCierreTurnos";
            btnCierreTurnos.Padding = new Padding(40, 0, 0, 0);
            btnCierreTurnos.Size = new Size(273, 55);
            btnCierreTurnos.TabIndex = 3;
            btnCierreTurnos.Text = "Cierre Turnos";
            btnCierreTurnos.TextAlign = ContentAlignment.MiddleLeft;
            btnCierreTurnos.UseVisualStyleBackColor = true;
            btnCierreTurnos.Click += btnCierreTurnos_Click;
            // 
            // btnRegistrarPedidos
            // 
            btnRegistrarPedidos.Dock = DockStyle.Top;
            btnRegistrarPedidos.FlatAppearance.BorderSize = 0;
            btnRegistrarPedidos.FlatStyle = FlatStyle.Flat;
            btnRegistrarPedidos.Font = new Font("Century Gothic", 9F);
            btnRegistrarPedidos.Location = new Point(0, 0);
            btnRegistrarPedidos.Name = "btnRegistrarPedidos";
            btnRegistrarPedidos.Padding = new Padding(40, 0, 0, 0);
            btnRegistrarPedidos.Size = new Size(273, 55);
            btnRegistrarPedidos.TabIndex = 2;
            btnRegistrarPedidos.Text = "Registro Pedidos";
            btnRegistrarPedidos.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrarPedidos.UseVisualStyleBackColor = true;
            btnRegistrarPedidos.Click += btnRegistrarPedidos_Click;
            // 
            // btnProcesos
            // 
            btnProcesos.Dock = DockStyle.Top;
            btnProcesos.FlatAppearance.BorderSize = 0;
            btnProcesos.FlatStyle = FlatStyle.Flat;
            btnProcesos.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnProcesos.Location = new Point(0, 209);
            btnProcesos.Name = "btnProcesos";
            btnProcesos.Padding = new Padding(11, 0, 0, 0);
            btnProcesos.Size = new Size(273, 55);
            btnProcesos.TabIndex = 1;
            btnProcesos.Text = "Procesos";
            btnProcesos.TextAlign = ContentAlignment.MiddleLeft;
            btnProcesos.UseVisualStyleBackColor = true;
            btnProcesos.Click += btnProcesos_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnDashboard.Location = new Point(0, 154);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(11, 0, 0, 0);
            btnDashboard.Size = new Size(273, 55);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "DashBoard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBoxLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(273, 154);
            panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.logo;
            pictureBoxLogo.Location = new Point(-10, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(239, 125);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.White;
            panelSuperior.Controls.Add(lblModuloActual);
            panelSuperior.Controls.Add(label1);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(294, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1505, 110);
            panelSuperior.TabIndex = 0;
            // 
            // lblModuloActual
            // 
            lblModuloActual.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModuloActual.ForeColor = Color.FromArgb(44, 105, 141);
            lblModuloActual.Location = new Point(6, 26);
            lblModuloActual.Name = "lblModuloActual";
            lblModuloActual.Size = new Size(300, 47);
            lblModuloActual.TabIndex = 1;
            lblModuloActual.Text = "Temporal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(44, 105, 141);
            label1.Location = new Point(834, 26);
            label1.Name = "label1";
            label1.Size = new Size(535, 47);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA PUNTO DE VENTAS";
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(86, 232, 232);
            panelInferior.Controls.Add(groupBox2);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(294, 726);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1505, 117);
            panelInferior.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblFecha);
            groupBox2.Controls.Add(lblHora);
            groupBox2.Location = new Point(1133, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(372, 125);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fecha y Hora:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            lblFecha.Location = new Point(16, 55);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(60, 19);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "label3";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            lblHora.Location = new Point(16, 26);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(60, 19);
            lblHora.TabIndex = 0;
            lblHora.Text = "label2";
            // 
            // panelPrincipal
            // 
            panelPrincipal.AutoScroll = true;
            panelPrincipal.AutoSize = true;
            panelPrincipal.Location = new Point(294, 116);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1505, 604);
            panelPrincipal.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // FrmDashBoard
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1799, 843);
            Controls.Add(panelInferior);
            Controls.Add(panelSuperior);
            Controls.Add(panelMenu);
            Controls.Add(panelPrincipal);
            Font = new Font("Century Gothic", 10F);
            Name = "FrmDashBoard";
            Text = "Sistema Punto de Venta";
            WindowState = FormWindowState.Maximized;
            Load += FrmDashBoard_Load;
            panelMenu.ResumeLayout(false);
            panelDatosMaestros.ResumeLayout(false);
            panelReportes.ResumeLayout(false);
            panelProcesos.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelInferior.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Panel panelSuperior;
        private Panel panelInferior;
        private Button btnDashboard;
        private Panel panelPrincipal;
        private Panel panelProcesos;
        private Button btnCierreTurnos;
        private Button btnRegistrarPedidos;
        private Button btnProcesos;
        private Panel panelDatosMaestros;
        private Button btnUnidadesMedida;
        private Button btnMarcas;
        private Button btnProductos;
        private Button btnDatosMaestros;
        private Panel panelReportes;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button btnReportes;
        private Button btnMesas;
        private Button btnAreaDespacho;
        private Button btnPuntosVenta;
        private Button btnFamilias;
        private Button btnSubFamilia;
        private PictureBox pictureBoxLogo;
        private Label lblModuloActual;
        private Label label1;
        private GroupBox groupBox2;
        private Label lblFecha;
        private Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private Button btnSalir;
        private Button btnCliente;
    }
}