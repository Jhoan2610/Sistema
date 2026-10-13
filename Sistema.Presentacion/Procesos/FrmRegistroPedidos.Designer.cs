namespace Sistema.Presentacion.Procesos
{
    partial class FrmRegistroPedidos
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
            panel2 = new Panel();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            panelSuperior = new Panel();
            lblMensaje = new Label();
            txtEstado = new TextBox();
            txtTurno = new TextBox();
            txtFechaTrabajo = new TextBox();
            btnBuscar = new Button();
            cmbPuntosVenta = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            BtnSalir = new Button();
            panel1 = new Panel();
            label6 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            panelSuperior.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(tabControl1);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1289, 78);
            panel2.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 9);
            label2.Name = "label2";
            label2.Size = new Size(324, 44);
            label2.TabIndex = 1;
            label2.Text = "Registrar Pedidos";
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
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(186, 232, 232);
            panelSuperior.Controls.Add(lblMensaje);
            panelSuperior.Controls.Add(txtEstado);
            panelSuperior.Controls.Add(txtTurno);
            panelSuperior.Controls.Add(txtFechaTrabajo);
            panelSuperior.Controls.Add(btnBuscar);
            panelSuperior.Controls.Add(cmbPuntosVenta);
            panelSuperior.Controls.Add(label5);
            panelSuperior.Controls.Add(label4);
            panelSuperior.Controls.Add(label3);
            panelSuperior.Controls.Add(label1);
            panelSuperior.Controls.Add(BtnSalir);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 78);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1289, 147);
            panelSuperior.TabIndex = 19;
            // 
            // lblMensaje
            // 
            lblMensaje.Dock = DockStyle.Bottom;
            lblMensaje.ForeColor = Color.Red;
            lblMensaje.Location = new Point(0, 127);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(1289, 20);
            lblMensaje.TabIndex = 31;
            lblMensaje.Text = "label6";
            lblMensaje.TextAlign = ContentAlignment.BottomCenter;
            lblMensaje.Visible = false;
            // 
            // txtEstado
            // 
            txtEstado.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            txtEstado.Location = new Point(878, 66);
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(172, 28);
            txtEstado.TabIndex = 30;
            // 
            // txtTurno
            // 
            txtTurno.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            txtTurno.Location = new Point(678, 66);
            txtTurno.Name = "txtTurno";
            txtTurno.ReadOnly = true;
            txtTurno.Size = new Size(194, 28);
            txtTurno.TabIndex = 29;
            // 
            // txtFechaTrabajo
            // 
            txtFechaTrabajo.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            txtFechaTrabajo.Location = new Point(482, 65);
            txtFechaTrabajo.Name = "txtFechaTrabajo";
            txtFechaTrabajo.ReadOnly = true;
            txtFechaTrabajo.Size = new Size(190, 28);
            txtFechaTrabajo.TabIndex = 20;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(337, 64);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 20;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cmbPuntosVenta
            // 
            cmbPuntosVenta.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbPuntosVenta.FormattingEnabled = true;
            cmbPuntosVenta.Location = new Point(46, 66);
            cmbPuntosVenta.Name = "cmbPuntosVenta";
            cmbPuntosVenta.Size = new Size(285, 27);
            cmbPuntosVenta.TabIndex = 28;
            cmbPuntosVenta.Text = "Selecciona Un Punto de Venta";
            cmbPuntosVenta.SelectionChangeCommitted += cmbPuntosVenta_SelectionChangeCommitted;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(912, 28);
            label5.Name = "label5";
            label5.Size = new Size(74, 23);
            label5.TabIndex = 26;
            label5.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(713, 28);
            label4.Name = "label4";
            label4.Size = new Size(61, 23);
            label4.TabIndex = 27;
            label4.Text = "Turno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(492, 28);
            label3.Name = "label3";
            label3.Size = new Size(180, 23);
            label3.TabIndex = 26;
            label3.Text = "Fecha de Trabajo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 28);
            label1.Name = "label1";
            label1.Size = new Size(160, 23);
            label1.TabIndex = 25;
            label1.Text = "Punto de Venta";
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Right;
            BtnSalir.BackColor = Color.FromArgb(226, 246, 245);
            BtnSalir.FlatAppearance.BorderColor = Color.FromArgb(83, 198, 198);
            BtnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            BtnSalir.ForeColor = Color.Black;
            BtnSalir.Location = new Point(1127, 28);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(124, 69);
            BtnSalir.TabIndex = 24;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 78, 112);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 225);
            panel1.Name = "panel1";
            panel1.Size = new Size(1289, 52);
            panel1.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(4, 15);
            label6.Name = "label6";
            label6.Size = new Size(92, 19);
            label6.TabIndex = 0;
            label6.Text = ":::Mesas:::";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 277);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1289, 347);
            flowLayoutPanel1.TabIndex = 33;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // FrmRegistroPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 624);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(panelSuperior);
            Controls.Add(panel2);
            Name = "FrmRegistroPedidos";
            Text = "Registro Pedidos";
            Load += FrmRegistroPedidos_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panelSuperior;
        private Button BtnSalir;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private ComboBox cmbPuntosVenta;
        private TextBox txtEstado;
        private TextBox txtTurno;
        private TextBox txtFechaTrabajo;
        private Button btnBuscar;
        private Label lblMensaje;
        private Panel panel1;
        private Label label6;
        private FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
    }
}