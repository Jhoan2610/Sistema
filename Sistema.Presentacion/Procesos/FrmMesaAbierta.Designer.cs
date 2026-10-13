namespace Sistema.Presentacion.Procesos
{
    partial class FrmMesaAbierta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMesaAbierta));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnSalir = new Button();
            imageList1 = new ImageList(components);
            btnNuevoPedido = new Button();
            txtPuntoVenta = new TextBox();
            btnVerPedido = new Button();
            label3 = new Label();
            txtMesa = new TextBox();
            label2 = new Label();
            tabPrincipal = new TabControl();
            tabPage1 = new TabPage();
            PnlObservacion = new Panel();
            txtObservacion = new TextBox();
            btnAceptar = new Button();
            PnlBusquedaProductos = new Panel();
            DgvBusquedaProducto = new DataGridView();
            BtnRetornar = new Button();
            BtnBusquedaProducto = new Button();
            txtBuscarProductos = new TextBox();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            label9 = new Label();
            panel7 = new Panel();
            dataGridView3 = new DataGridView();
            label10 = new Label();
            FlowLayoutPanelListadoProductos = new FlowLayoutPanel();
            panel4 = new Panel();
            label8 = new Label();
            DgvListadoProductos = new DataGridView();
            PnlPedidos = new Panel();
            pnlBuscarCliente = new Panel();
            DgvListarClientes = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            TxtBuscarClientes = new TextBox();
            panel8 = new Panel();
            dataGridView4 = new DataGridView();
            label11 = new Label();
            btnGenerarPedido = new Button();
            btnCancelarPedido = new Button();
            lblTotal = new Label();
            label7 = new Label();
            DgvDetalles = new DataGridView();
            btnBuscarProducto = new Button();
            btnEliminarProducto = new Button();
            btnActualizarPedido = new Button();
            lblCantidad = new Label();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnClear = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn1 = new Button();
            btnBuscar = new Button();
            ChkClienteManual = new CheckBox();
            txtDocumentoCliente = new TextBox();
            label6 = new Label();
            txtNombreCliente = new TextBox();
            label5 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            tabPage2 = new TabPage();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabPrincipal.SuspendLayout();
            tabPage1.SuspendLayout();
            PnlObservacion.SuspendLayout();
            PnlBusquedaProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvBusquedaProducto).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListadoProductos).BeginInit();
            PnlPedidos.SuspendLayout();
            pnlBuscarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListarClientes).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvDetalles).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1521, 56);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(227, 34);
            label1.TabIndex = 0;
            label1.Text = ".:. Mesa Abierta";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(168, 232, 232);
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(btnNuevoPedido);
            panel2.Controls.Add(txtPuntoVenta);
            panel2.Controls.Add(btnVerPedido);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtMesa);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(1521, 106);
            panel2.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(228, 246, 245);
            btnSalir.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.ImageKey = "salir.png";
            btnSalir.ImageList = imageList1;
            btnSalir.Location = new Point(1304, 16);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(177, 84);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "ver_pedido.jpeg");
            imageList1.Images.SetKeyName(1, "buscar_productos.jpeg");
            imageList1.Images.SetKeyName(2, "nuevo_pedido.jpeg");
            imageList1.Images.SetKeyName(3, "salir.png");
            imageList1.Images.SetKeyName(4, "lupa.png");
            imageList1.Images.SetKeyName(5, "lupa.ico");
            // 
            // btnNuevoPedido
            // 
            btnNuevoPedido.BackColor = Color.FromArgb(228, 246, 245);
            btnNuevoPedido.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevoPedido.ImageKey = "nuevo_pedido.jpeg";
            btnNuevoPedido.ImageList = imageList1;
            btnNuevoPedido.Location = new Point(938, 16);
            btnNuevoPedido.Name = "btnNuevoPedido";
            btnNuevoPedido.Size = new Size(177, 84);
            btnNuevoPedido.TabIndex = 4;
            btnNuevoPedido.Text = "Nuevo Pedido";
            btnNuevoPedido.TextImageRelation = TextImageRelation.ImageAboveText;
            btnNuevoPedido.UseVisualStyleBackColor = false;
            btnNuevoPedido.Click += btnNuevoPedido_Click;
            // 
            // txtPuntoVenta
            // 
            txtPuntoVenta.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtPuntoVenta.Location = new Point(278, 45);
            txtPuntoVenta.Name = "txtPuntoVenta";
            txtPuntoVenta.Size = new Size(234, 32);
            txtPuntoVenta.TabIndex = 3;
            txtPuntoVenta.Text = "PUNTO DE VENTA X";
            txtPuntoVenta.TextAlign = HorizontalAlignment.Center;
            // 
            // btnVerPedido
            // 
            btnVerPedido.BackColor = Color.FromArgb(228, 246, 245);
            btnVerPedido.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerPedido.ImageKey = "ver_pedido.jpeg";
            btnVerPedido.ImageList = imageList1;
            btnVerPedido.Location = new Point(1121, 16);
            btnVerPedido.Name = "btnVerPedido";
            btnVerPedido.Size = new Size(177, 84);
            btnVerPedido.TabIndex = 2;
            btnVerPedido.Text = "Ver Pedido";
            btnVerPedido.TextImageRelation = TextImageRelation.ImageAboveText;
            btnVerPedido.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(319, 19);
            label3.Name = "label3";
            label3.Size = new Size(145, 22);
            label3.TabIndex = 2;
            label3.Text = "Punto de Venta";
            // 
            // txtMesa
            // 
            txtMesa.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtMesa.Location = new Point(12, 45);
            txtMesa.Name = "txtMesa";
            txtMesa.Size = new Size(234, 32);
            txtMesa.TabIndex = 1;
            txtMesa.Text = "MESA X";
            txtMesa.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 19);
            label2.Name = "label2";
            label2.Size = new Size(187, 22);
            label2.TabIndex = 0;
            label2.Text = "Mesa Seleccionada";
            // 
            // tabPrincipal
            // 
            tabPrincipal.Controls.Add(tabPage1);
            tabPrincipal.Controls.Add(tabPage2);
            tabPrincipal.Dock = DockStyle.Fill;
            tabPrincipal.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPrincipal.Location = new Point(0, 162);
            tabPrincipal.Name = "tabPrincipal";
            tabPrincipal.SelectedIndex = 0;
            tabPrincipal.Size = new Size(1521, 797);
            tabPrincipal.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(PnlObservacion);
            tabPage1.Controls.Add(FlowLayoutPanelListadoProductos);
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(DgvListadoProductos);
            tabPage1.Controls.Add(PnlPedidos);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1513, 763);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Nuevo Pedido";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // PnlObservacion
            // 
            PnlObservacion.Controls.Add(txtObservacion);
            PnlObservacion.Controls.Add(btnAceptar);
            PnlObservacion.Controls.Add(PnlBusquedaProductos);
            PnlObservacion.Controls.Add(panel7);
            PnlObservacion.Location = new Point(825, 28);
            PnlObservacion.Name = "PnlObservacion";
            PnlObservacion.Size = new Size(580, 287);
            PnlObservacion.TabIndex = 29;
            PnlObservacion.Visible = false;
            // 
            // txtObservacion
            // 
            txtObservacion.Dock = DockStyle.Top;
            txtObservacion.Location = new Point(0, 56);
            txtObservacion.Multiline = true;
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new Size(580, 191);
            txtObservacion.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Gray;
            btnAceptar.Dock = DockStyle.Bottom;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = SystemColors.Control;
            btnAceptar.Location = new Point(0, 245);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(580, 42);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // PnlBusquedaProductos
            // 
            PnlBusquedaProductos.Controls.Add(DgvBusquedaProducto);
            PnlBusquedaProductos.Controls.Add(BtnRetornar);
            PnlBusquedaProductos.Controls.Add(BtnBusquedaProducto);
            PnlBusquedaProductos.Controls.Add(txtBuscarProductos);
            PnlBusquedaProductos.Controls.Add(panel5);
            PnlBusquedaProductos.Location = new Point(5, 199);
            PnlBusquedaProductos.Name = "PnlBusquedaProductos";
            PnlBusquedaProductos.Size = new Size(580, 287);
            PnlBusquedaProductos.TabIndex = 28;
            PnlBusquedaProductos.Visible = false;
            // 
            // DgvBusquedaProducto
            // 
            DgvBusquedaProducto.AllowUserToAddRows = false;
            DgvBusquedaProducto.AllowUserToDeleteRows = false;
            DgvBusquedaProducto.AllowUserToOrderColumns = true;
            DgvBusquedaProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvBusquedaProducto.Location = new Point(17, 106);
            DgvBusquedaProducto.Name = "DgvBusquedaProducto";
            DgvBusquedaProducto.ReadOnly = true;
            DgvBusquedaProducto.RowHeadersWidth = 51;
            DgvBusquedaProducto.Size = new Size(527, 159);
            DgvBusquedaProducto.TabIndex = 4;
            DgvBusquedaProducto.CellDoubleClick += DgvBusquedaProducto_CellDoubleClick;
            // 
            // BtnRetornar
            // 
            BtnRetornar.BackColor = Color.FromArgb(192, 0, 0);
            BtnRetornar.FlatAppearance.BorderSize = 0;
            BtnRetornar.FlatStyle = FlatStyle.Flat;
            BtnRetornar.ForeColor = Color.White;
            BtnRetornar.Location = new Point(455, 70);
            BtnRetornar.Name = "BtnRetornar";
            BtnRetornar.Size = new Size(94, 29);
            BtnRetornar.TabIndex = 3;
            BtnRetornar.Text = "Retornar";
            BtnRetornar.UseVisualStyleBackColor = false;
            BtnRetornar.Click += BtnRetornar_Click;
            // 
            // BtnBusquedaProducto
            // 
            BtnBusquedaProducto.BackColor = Color.CornflowerBlue;
            BtnBusquedaProducto.FlatAppearance.BorderSize = 0;
            BtnBusquedaProducto.FlatStyle = FlatStyle.Flat;
            BtnBusquedaProducto.ForeColor = Color.White;
            BtnBusquedaProducto.Location = new Point(349, 71);
            BtnBusquedaProducto.Name = "BtnBusquedaProducto";
            BtnBusquedaProducto.Size = new Size(94, 29);
            BtnBusquedaProducto.TabIndex = 2;
            BtnBusquedaProducto.Text = "Buscar";
            BtnBusquedaProducto.UseVisualStyleBackColor = false;
            BtnBusquedaProducto.Click += BtnBusquedaProducto_Click;
            // 
            // txtBuscarProductos
            // 
            txtBuscarProductos.Location = new Point(14, 70);
            txtBuscarProductos.Name = "txtBuscarProductos";
            txtBuscarProductos.Size = new Size(319, 30);
            txtBuscarProductos.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Green;
            panel5.Controls.Add(dataGridView1);
            panel5.Controls.Add(label9);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(580, 56);
            panel5.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(105, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 139);
            dataGridView1.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Green;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(5, 18);
            label9.Name = "label9";
            label9.Size = new Size(177, 23);
            label9.TabIndex = 2;
            label9.Text = "Buscar Productos";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(251, 128, 0);
            panel7.Controls.Add(dataGridView3);
            panel7.Controls.Add(label10);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(580, 56);
            panel7.TabIndex = 0;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AllowUserToOrderColumns = true;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(105, 71);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(300, 139);
            dataGridView3.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(251, 128, 0);
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(5, 18);
            label10.Name = "label10";
            label10.Size = new Size(135, 23);
            label10.TabIndex = 2;
            label10.Text = "Observacion";
            // 
            // FlowLayoutPanelListadoProductos
            // 
            FlowLayoutPanelListadoProductos.Dock = DockStyle.Fill;
            FlowLayoutPanelListadoProductos.Location = new Point(980, 65);
            FlowLayoutPanelListadoProductos.Name = "FlowLayoutPanelListadoProductos";
            FlowLayoutPanelListadoProductos.Size = new Size(530, 695);
            FlowLayoutPanelListadoProductos.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SteelBlue;
            panel4.Controls.Add(label8);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(980, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(530, 62);
            panel4.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.SteelBlue;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(13, 13);
            label8.Name = "label8";
            label8.Size = new Size(247, 23);
            label8.TabIndex = 2;
            label8.Text = "::: Productos Disponibles";
            // 
            // DgvListadoProductos
            // 
            DgvListadoProductos.BackgroundColor = SystemColors.ButtonFace;
            DgvListadoProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListadoProductos.Dock = DockStyle.Left;
            DgvListadoProductos.Location = new Point(677, 3);
            DgvListadoProductos.Name = "DgvListadoProductos";
            DgvListadoProductos.RowHeadersWidth = 51;
            DgvListadoProductos.Size = new Size(303, 757);
            DgvListadoProductos.TabIndex = 1;
            DgvListadoProductos.CellClick += DgvListadoProductos_CellClick;
            // 
            // PnlPedidos
            // 
            PnlPedidos.Controls.Add(pnlBuscarCliente);
            PnlPedidos.Controls.Add(btnGenerarPedido);
            PnlPedidos.Controls.Add(btnCancelarPedido);
            PnlPedidos.Controls.Add(lblTotal);
            PnlPedidos.Controls.Add(label7);
            PnlPedidos.Controls.Add(DgvDetalles);
            PnlPedidos.Controls.Add(btnBuscarProducto);
            PnlPedidos.Controls.Add(btnEliminarProducto);
            PnlPedidos.Controls.Add(btnActualizarPedido);
            PnlPedidos.Controls.Add(lblCantidad);
            PnlPedidos.Controls.Add(btn8);
            PnlPedidos.Controls.Add(btn9);
            PnlPedidos.Controls.Add(btn0);
            PnlPedidos.Controls.Add(btnClear);
            PnlPedidos.Controls.Add(btn2);
            PnlPedidos.Controls.Add(btn3);
            PnlPedidos.Controls.Add(btn4);
            PnlPedidos.Controls.Add(btn5);
            PnlPedidos.Controls.Add(btn6);
            PnlPedidos.Controls.Add(btn7);
            PnlPedidos.Controls.Add(btn1);
            PnlPedidos.Controls.Add(btnBuscar);
            PnlPedidos.Controls.Add(ChkClienteManual);
            PnlPedidos.Controls.Add(txtDocumentoCliente);
            PnlPedidos.Controls.Add(label6);
            PnlPedidos.Controls.Add(txtNombreCliente);
            PnlPedidos.Controls.Add(label5);
            PnlPedidos.Controls.Add(panel3);
            PnlPedidos.Dock = DockStyle.Left;
            PnlPedidos.Location = new Point(3, 3);
            PnlPedidos.Name = "PnlPedidos";
            PnlPedidos.Size = new Size(674, 757);
            PnlPedidos.TabIndex = 0;
            // 
            // pnlBuscarCliente
            // 
            pnlBuscarCliente.Controls.Add(DgvListarClientes);
            pnlBuscarCliente.Controls.Add(button1);
            pnlBuscarCliente.Controls.Add(button2);
            pnlBuscarCliente.Controls.Add(TxtBuscarClientes);
            pnlBuscarCliente.Controls.Add(panel8);
            pnlBuscarCliente.Location = new Point(74, 242);
            pnlBuscarCliente.Name = "pnlBuscarCliente";
            pnlBuscarCliente.Size = new Size(580, 287);
            pnlBuscarCliente.TabIndex = 29;
            pnlBuscarCliente.Visible = false;
            // 
            // DgvListarClientes
            // 
            DgvListarClientes.AllowUserToAddRows = false;
            DgvListarClientes.AllowUserToDeleteRows = false;
            DgvListarClientes.AllowUserToOrderColumns = true;
            DgvListarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListarClientes.Location = new Point(17, 106);
            DgvListarClientes.Name = "DgvListarClientes";
            DgvListarClientes.ReadOnly = true;
            DgvListarClientes.RowHeadersWidth = 51;
            DgvListarClientes.Size = new Size(527, 159);
            DgvListarClientes.TabIndex = 4;
            DgvListarClientes.CellClick += DgvListarClientes_CellClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(455, 70);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Retornar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.CornflowerBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(349, 71);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // TxtBuscarClientes
            // 
            TxtBuscarClientes.Location = new Point(14, 70);
            TxtBuscarClientes.Name = "TxtBuscarClientes";
            TxtBuscarClientes.Size = new Size(319, 30);
            TxtBuscarClientes.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(255, 192, 128);
            panel8.Controls.Add(dataGridView4);
            panel8.Controls.Add(label11);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(580, 56);
            panel8.TabIndex = 0;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.AllowUserToOrderColumns = true;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(105, 71);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.ReadOnly = true;
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(300, 139);
            dataGridView4.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(255, 192, 128);
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(5, 18);
            label11.Name = "label11";
            label11.Size = new Size(160, 23);
            label11.TabIndex = 2;
            label11.Text = "Buscar Clientes";
            // 
            // btnGenerarPedido
            // 
            btnGenerarPedido.BackColor = Color.RoyalBlue;
            btnGenerarPedido.FlatAppearance.BorderSize = 0;
            btnGenerarPedido.FlatStyle = FlatStyle.Flat;
            btnGenerarPedido.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarPedido.ForeColor = SystemColors.Control;
            btnGenerarPedido.Location = new Point(259, 699);
            btnGenerarPedido.Name = "btnGenerarPedido";
            btnGenerarPedido.Size = new Size(246, 53);
            btnGenerarPedido.TabIndex = 27;
            btnGenerarPedido.Text = "Generar Orden";
            btnGenerarPedido.UseVisualStyleBackColor = false;
            // 
            // btnCancelarPedido
            // 
            btnCancelarPedido.BackColor = Color.DimGray;
            btnCancelarPedido.FlatAppearance.BorderSize = 0;
            btnCancelarPedido.FlatStyle = FlatStyle.Flat;
            btnCancelarPedido.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarPedido.ForeColor = SystemColors.Control;
            btnCancelarPedido.Location = new Point(3, 699);
            btnCancelarPedido.Name = "btnCancelarPedido";
            btnCancelarPedido.Size = new Size(246, 53);
            btnCancelarPedido.TabIndex = 26;
            btnCancelarPedido.Text = "Cancelar";
            btnCancelarPedido.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.White;
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(422, 629);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(246, 56);
            lblTotal.TabIndex = 25;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(327, 646);
            label7.Name = "label7";
            label7.Size = new Size(89, 22);
            label7.TabIndex = 24;
            label7.Text = "Total RD$";
            // 
            // DgvDetalles
            // 
            DgvDetalles.AllowUserToAddRows = false;
            DgvDetalles.AllowUserToDeleteRows = false;
            DgvDetalles.AllowUserToOrderColumns = true;
            DgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDetalles.Location = new Point(3, 318);
            DgvDetalles.Name = "DgvDetalles";
            DgvDetalles.ReadOnly = true;
            DgvDetalles.RowHeadersWidth = 51;
            DgvDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvDetalles.Size = new Size(665, 308);
            DgvDetalles.TabIndex = 23;
            DgvDetalles.CellDoubleClick += DgvDetalles_CellDoubleClick;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.FlatStyle = FlatStyle.Flat;
            btnBuscarProducto.ImageKey = "buscar_productos.jpeg";
            btnBuscarProducto.ImageList = imageList1;
            btnBuscarProducto.Location = new Point(478, 259);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(109, 53);
            btnBuscarProducto.TabIndex = 22;
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = Color.Red;
            btnEliminarProducto.FlatAppearance.BorderSize = 0;
            btnEliminarProducto.FlatStyle = FlatStyle.Flat;
            btnEliminarProducto.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarProducto.ForeColor = SystemColors.Control;
            btnEliminarProducto.Location = new Point(257, 259);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(215, 53);
            btnEliminarProducto.TabIndex = 21;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnActualizarPedido
            // 
            btnActualizarPedido.BackColor = Color.FromArgb(0, 192, 0);
            btnActualizarPedido.FlatAppearance.BorderSize = 0;
            btnActualizarPedido.FlatStyle = FlatStyle.Flat;
            btnActualizarPedido.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarPedido.ForeColor = SystemColors.Control;
            btnActualizarPedido.Location = new Point(5, 259);
            btnActualizarPedido.Name = "btnActualizarPedido";
            btnActualizarPedido.Size = new Size(246, 53);
            btnActualizarPedido.TabIndex = 20;
            btnActualizarPedido.Text = "Actualizar Cantidad";
            btnActualizarPedido.UseVisualStyleBackColor = false;
            btnActualizarPedido.Click += btnActualizarPedido_Click;
            // 
            // lblCantidad
            // 
            lblCantidad.BackColor = Color.White;
            lblCantidad.BorderStyle = BorderStyle.FixedSingle;
            lblCantidad.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(341, 197);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(246, 56);
            lblCantidad.TabIndex = 19;
            lblCantidad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(246, 185, 59);
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.ForeColor = SystemColors.Control;
            btn8.Location = new Point(5, 197);
            btn8.Name = "btn8";
            btn8.Size = new Size(78, 56);
            btn8.TabIndex = 18;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn1_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(246, 185, 59);
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.ForeColor = SystemColors.Control;
            btn9.Location = new Point(89, 197);
            btn9.Name = "btn9";
            btn9.Size = new Size(78, 56);
            btn9.TabIndex = 17;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn1_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(246, 185, 59);
            btn0.FlatAppearance.BorderSize = 0;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.ForeColor = SystemColors.Control;
            btn0.Location = new Point(173, 197);
            btn0.Name = "btn0";
            btn0.Size = new Size(78, 56);
            btn0.TabIndex = 16;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn1_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(246, 185, 59);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.Control;
            btnClear.Location = new Point(257, 197);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(78, 56);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(246, 185, 59);
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.ForeColor = SystemColors.Control;
            btn2.Location = new Point(89, 135);
            btn2.Name = "btn2";
            btn2.Size = new Size(78, 56);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn1_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(246, 185, 59);
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.ForeColor = SystemColors.Control;
            btn3.Location = new Point(173, 135);
            btn3.Name = "btn3";
            btn3.Size = new Size(78, 56);
            btn3.TabIndex = 13;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn1_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(246, 185, 59);
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.ForeColor = SystemColors.Control;
            btn4.Location = new Point(257, 135);
            btn4.Name = "btn4";
            btn4.Size = new Size(78, 56);
            btn4.TabIndex = 12;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn1_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(246, 185, 59);
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.ForeColor = SystemColors.Control;
            btn5.Location = new Point(341, 135);
            btn5.Name = "btn5";
            btn5.Size = new Size(78, 56);
            btn5.TabIndex = 11;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn1_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(246, 185, 59);
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.ForeColor = SystemColors.Control;
            btn6.Location = new Point(425, 135);
            btn6.Name = "btn6";
            btn6.Size = new Size(78, 56);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn1_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(246, 185, 59);
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.ForeColor = SystemColors.Control;
            btn7.Location = new Point(509, 135);
            btn7.Name = "btn7";
            btn7.Size = new Size(78, 56);
            btn7.TabIndex = 9;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn1_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(246, 185, 59);
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = SystemColors.Control;
            btn1.Location = new Point(5, 135);
            btn1.Name = "btn1";
            btn1.Size = new Size(78, 56);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Transparent;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ImageKey = "lupa.ico";
            btnBuscar.ImageList = imageList1;
            btnBuscar.Location = new Point(511, 75);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(52, 54);
            btnBuscar.TabIndex = 6;
            btnBuscar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // ChkClienteManual
            // 
            ChkClienteManual.AutoSize = true;
            ChkClienteManual.Location = new Point(89, 75);
            ChkClienteManual.Name = "ChkClienteManual";
            ChkClienteManual.Size = new Size(98, 25);
            ChkClienteManual.TabIndex = 5;
            ChkClienteManual.Text = "Manual";
            ChkClienteManual.UseVisualStyleBackColor = true;
            // 
            // txtDocumentoCliente
            // 
            txtDocumentoCliente.Location = new Point(271, 99);
            txtDocumentoCliente.Name = "txtDocumentoCliente";
            txtDocumentoCliente.Size = new Size(234, 30);
            txtDocumentoCliente.TabIndex = 4;
            txtDocumentoCliente.TextChanged += txtDocumentoCliente_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(271, 75);
            label6.Name = "label6";
            label6.Size = new Size(122, 21);
            label6.TabIndex = 3;
            label6.Text = "Documento:";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(5, 99);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(234, 30);
            txtNombreCliente.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 75);
            label5.Name = "label5";
            label5.Size = new Size(78, 21);
            label5.TabIndex = 1;
            label5.Text = "Cliente:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(674, 57);
            panel3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SteelBlue;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(5, 16);
            label4.Name = "label4";
            label4.Size = new Size(148, 23);
            label4.TabIndex = 1;
            label4.Text = "Nuevo Pedido";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1513, 763);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ver Pedidos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FrmMesaAbierta
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1521, 959);
            Controls.Add(tabPrincipal);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 11F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmMesaAbierta";
            Text = "Mesa Abierta";
            WindowState = FormWindowState.Maximized;
            Load += FrmMesaAbierta_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPrincipal.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            PnlObservacion.ResumeLayout(false);
            PnlObservacion.PerformLayout();
            PnlBusquedaProductos.ResumeLayout(false);
            PnlBusquedaProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvBusquedaProducto).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListadoProductos).EndInit();
            PnlPedidos.ResumeLayout(false);
            PnlPedidos.PerformLayout();
            pnlBuscarCliente.ResumeLayout(false);
            pnlBuscarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListarClientes).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvDetalles).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Button btnVerPedido;
        private ImageList imageList1;
        private Button btnSalir;
        private TabControl tabPrincipal;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel PnlPedidos;
        private CheckBox ChkClienteManual;
        private TextBox txtDocumentoCliente;
        private Label label6;
        private TextBox txtNombreCliente;
        private Label label5;
        private Panel panel3;
        private Label label4;
        private Button btnBuscar;
        private Button btn1;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnClear;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btnBuscarProducto;
        private Button btnEliminarProducto;
        private Button btnActualizarPedido;
        private Label lblCantidad;
        private Button btnGenerarPedido;
        private Button btnCancelarPedido;
        private Label lblTotal;
        private Label label7;
        private DataGridView DgvDetalles;
        private FlowLayoutPanel FlowLayoutPanelListadoProductos;
        private Panel panel4;
        private Label label8;
        private Panel PnlBusquedaProductos;
        private Button BtnRetornar;
        private Button BtnBusquedaProducto;
        private TextBox txtBuscarProductos;
        private Panel panel5;
        private DataGridView dataGridView1;
        private Label label9;
        private Panel PnlObservacion;
        private TextBox txtObservacion;
        private Panel panel7;
        private DataGridView dataGridView3;
        private Label label10;
        internal TextBox txtMesa;
        internal TextBox txtPuntoVenta;
        internal Button btnNuevoPedido;
        internal DataGridView DgvBusquedaProducto;
        internal DataGridView DgvListadoProductos;
        private System.Windows.Forms.Timer timer1;
        private Button btnAceptar;
        private Panel pnlBuscarCliente;
        internal DataGridView DgvListarClientes;
        private Button button1;
        private Button button2;
        private TextBox TxtBuscarClientes;
        private Panel panel8;
        private DataGridView dataGridView4;
        private Label label11;
    }
}