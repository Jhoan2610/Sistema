namespace Sistema.Presentacion.Procesos
{
    partial class FrmCierreTurnos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            DgvPuntosVenta = new DataGridView();
            panel2 = new Panel();
            BtnCerrarTurno = new Button();
            BtnAbrirTurno = new Button();
            LblEstadoTurno = new Label();
            label5 = new Label();
            LblTurno = new Label();
            label8 = new Label();
            LblFechaTrabajo = new Label();
            label6 = new Label();
            LblPuntoVenta = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPuntosVenta).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1450, 98);
            panel1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(37, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(318, 40);
            label2.TabIndex = 0;
            label2.Text = "Gestión de Turnos";
            // 
            // DgvPuntosVenta
            // 
            DgvPuntosVenta.AllowUserToAddRows = false;
            DgvPuntosVenta.AllowUserToDeleteRows = false;
            DgvPuntosVenta.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvPuntosVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvPuntosVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvPuntosVenta.DefaultCellStyle = dataGridViewCellStyle2;
            DgvPuntosVenta.Location = new Point(21, 128);
            DgvPuntosVenta.Margin = new Padding(3, 2, 3, 2);
            DgvPuntosVenta.Name = "DgvPuntosVenta";
            DgvPuntosVenta.ReadOnly = true;
            DgvPuntosVenta.RowHeadersWidth = 51;
            DgvPuntosVenta.RowTemplate.Height = 24;
            DgvPuntosVenta.Size = new Size(592, 221);
            DgvPuntosVenta.TabIndex = 1;
            DgvPuntosVenta.CellClick += DgvPuntosVenta_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(BtnCerrarTurno);
            panel2.Controls.Add(BtnAbrirTurno);
            panel2.Controls.Add(LblEstadoTurno);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(LblTurno);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(LblFechaTrabajo);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(LblPuntoVenta);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(619, 128);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(805, 478);
            panel2.TabIndex = 19;
            // 
            // BtnCerrarTurno
            // 
            BtnCerrarTurno.BackColor = SystemColors.ButtonShadow;
            BtnCerrarTurno.Enabled = false;
            BtnCerrarTurno.FlatStyle = FlatStyle.Flat;
            BtnCerrarTurno.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCerrarTurno.ForeColor = Color.White;
            BtnCerrarTurno.Location = new Point(531, 360);
            BtnCerrarTurno.Margin = new Padding(5, 8, 5, 8);
            BtnCerrarTurno.Name = "BtnCerrarTurno";
            BtnCerrarTurno.Size = new Size(252, 68);
            BtnCerrarTurno.TabIndex = 30;
            BtnCerrarTurno.Text = "Cerrar Turno";
            BtnCerrarTurno.UseVisualStyleBackColor = false;
            BtnCerrarTurno.Click += BtnCerrarTurno_Click;
            // 
            // BtnAbrirTurno
            // 
            BtnAbrirTurno.BackColor = Color.CornflowerBlue;
            BtnAbrirTurno.Enabled = false;
            BtnAbrirTurno.FlatStyle = FlatStyle.Flat;
            BtnAbrirTurno.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAbrirTurno.ForeColor = Color.White;
            BtnAbrirTurno.Location = new Point(237, 360);
            BtnAbrirTurno.Margin = new Padding(5, 8, 5, 8);
            BtnAbrirTurno.Name = "BtnAbrirTurno";
            BtnAbrirTurno.Size = new Size(257, 68);
            BtnAbrirTurno.TabIndex = 29;
            BtnAbrirTurno.Text = "Abrir Siguiente Turno";
            BtnAbrirTurno.UseVisualStyleBackColor = false;
            BtnAbrirTurno.Click += BtnAbrirTurno_Click;
            // 
            // LblEstadoTurno
            // 
            LblEstadoTurno.BorderStyle = BorderStyle.Fixed3D;
            LblEstadoTurno.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblEstadoTurno.Location = new Point(219, 286);
            LblEstadoTurno.Name = "LblEstadoTurno";
            LblEstadoTurno.Size = new Size(581, 46);
            LblEstadoTurno.TabIndex = 28;
            LblEstadoTurno.Text = "Punto de Venta X";
            LblEstadoTurno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 286);
            label5.Name = "label5";
            label5.Size = new Size(160, 21);
            label5.TabIndex = 27;
            label5.Text = "Estado del Turno:";
            // 
            // LblTurno
            // 
            LblTurno.BorderStyle = BorderStyle.Fixed3D;
            LblTurno.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTurno.Location = new Point(219, 234);
            LblTurno.Name = "LblTurno";
            LblTurno.Size = new Size(581, 46);
            LblTurno.TabIndex = 26;
            LblTurno.Text = "Punto de Venta X";
            LblTurno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(20, 234);
            label8.Name = "label8";
            label8.Size = new Size(71, 22);
            label8.TabIndex = 25;
            label8.Text = "Turno:";
            // 
            // LblFechaTrabajo
            // 
            LblFechaTrabajo.BorderStyle = BorderStyle.Fixed3D;
            LblFechaTrabajo.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFechaTrabajo.Location = new Point(219, 181);
            LblFechaTrabajo.Name = "LblFechaTrabajo";
            LblFechaTrabajo.Size = new Size(583, 46);
            LblFechaTrabajo.TabIndex = 24;
            LblFechaTrabajo.Text = "Punto de Venta X";
            LblFechaTrabajo.TextAlign = ContentAlignment.MiddleCenter;
            LblFechaTrabajo.Click += LblFechaTrabajo_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 181);
            label6.Name = "label6";
            label6.Size = new Size(173, 22);
            label6.TabIndex = 23;
            label6.Text = "Fecha de Trabajo:";
            // 
            // LblPuntoVenta
            // 
            LblPuntoVenta.BorderStyle = BorderStyle.Fixed3D;
            LblPuntoVenta.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPuntoVenta.Location = new Point(219, 129);
            LblPuntoVenta.Name = "LblPuntoVenta";
            LblPuntoVenta.Size = new Size(581, 46);
            LblPuntoVenta.TabIndex = 22;
            LblPuntoVenta.Text = "Punto de Venta X";
            LblPuntoVenta.TextAlign = ContentAlignment.MiddleCenter;
            LblPuntoVenta.Click += LblPuntoVenta_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 129);
            label3.Name = "label3";
            label3.Size = new Size(156, 22);
            label3.TabIndex = 21;
            label3.Text = "Punto de Venta:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(805, 98);
            panel3.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(107, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(330, 34);
            label1.TabIndex = 0;
            label1.Text = "Información del Turno";
            // 
            // FrmCierreTurnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 814);
            Controls.Add(panel2);
            Controls.Add(DgvPuntosVenta);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmCierreTurnos";
            Text = "Cierre de Turnos";
            Load += FrmCierreTurnos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPuntosVenta).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvPuntosVenta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblFechaTrabajo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblPuntoVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTurno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblEstadoTurno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAbrirTurno;
        private System.Windows.Forms.Button BtnCerrarTurno;
    }
}