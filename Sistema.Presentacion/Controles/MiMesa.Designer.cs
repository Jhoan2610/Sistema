namespace Sistema.Presentacion.Controles
{
    partial class MiMesa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiMesa));
            panelMesa = new Panel();
            lblCodigoTurno = new Label();
            lblCodigoUsuario = new Label();
            lblDescripcionPuntoVenta = new Label();
            lblCodigoPuntoVenta = new Label();
            lblCodigoMesa = new Label();
            lblDescripcionMesa = new Label();
            pictureBoxEstado = new PictureBox();
            pictureBoxImagenMesa = new PictureBox();
            panelMesa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEstado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagenMesa).BeginInit();
            SuspendLayout();
            // 
            // panelMesa
            // 
            panelMesa.BackColor = SystemColors.Control;
            panelMesa.Controls.Add(lblCodigoTurno);
            panelMesa.Controls.Add(lblCodigoUsuario);
            panelMesa.Controls.Add(lblDescripcionPuntoVenta);
            panelMesa.Controls.Add(lblCodigoPuntoVenta);
            panelMesa.Controls.Add(lblCodigoMesa);
            panelMesa.Controls.Add(lblDescripcionMesa);
            panelMesa.Controls.Add(pictureBoxEstado);
            panelMesa.Controls.Add(pictureBoxImagenMesa);
            panelMesa.Location = new Point(0, 0);
            panelMesa.Name = "panelMesa";
            panelMesa.Size = new Size(201, 191);
            panelMesa.TabIndex = 0;
            // 
            // lblCodigoTurno
            // 
            lblCodigoTurno.AutoSize = true;
            lblCodigoTurno.Location = new Point(163, 114);
            lblCodigoTurno.Name = "lblCodigoTurno";
            lblCodigoTurno.Size = new Size(26, 20);
            lblCodigoTurno.TabIndex = 7;
            lblCodigoTurno.Text = "CT";
            // 
            // lblCodigoUsuario
            // 
            lblCodigoUsuario.AutoSize = true;
            lblCodigoUsuario.Location = new Point(161, 81);
            lblCodigoUsuario.Name = "lblCodigoUsuario";
            lblCodigoUsuario.Size = new Size(28, 20);
            lblCodigoUsuario.TabIndex = 6;
            lblCodigoUsuario.Text = "CU";
            // 
            // lblDescripcionPuntoVenta
            // 
            lblDescripcionPuntoVenta.AutoSize = true;
            lblDescripcionPuntoVenta.Location = new Point(161, 48);
            lblDescripcionPuntoVenta.Name = "lblDescripcionPuntoVenta";
            lblDescripcionPuntoVenta.Size = new Size(37, 20);
            lblDescripcionPuntoVenta.TabIndex = 5;
            lblDescripcionPuntoVenta.Text = "DPV";
            // 
            // lblCodigoPuntoVenta
            // 
            lblCodigoPuntoVenta.AutoSize = true;
            lblCodigoPuntoVenta.Location = new Point(162, 12);
            lblCodigoPuntoVenta.Name = "lblCodigoPuntoVenta";
            lblCodigoPuntoVenta.Size = new Size(26, 20);
            lblCodigoPuntoVenta.TabIndex = 4;
            lblCodigoPuntoVenta.Text = "PV";
            // 
            // lblCodigoMesa
            // 
            lblCodigoMesa.AutoSize = true;
            lblCodigoMesa.Location = new Point(13, 12);
            lblCodigoMesa.Name = "lblCodigoMesa";
            lblCodigoMesa.Size = new Size(31, 20);
            lblCodigoMesa.TabIndex = 3;
            lblCodigoMesa.Text = "CM";
            // 
            // lblDescripcionMesa
            // 
            lblDescripcionMesa.AutoSize = true;
            lblDescripcionMesa.Location = new Point(70, 156);
            lblDescripcionMesa.Name = "lblDescripcionMesa";
            lblDescripcionMesa.Size = new Size(57, 20);
            lblDescripcionMesa.TabIndex = 2;
            lblDescripcionMesa.Text = "Mesa X";
            // 
            // pictureBoxEstado
            // 
            pictureBoxEstado.Image = (Image)resources.GetObject("pictureBoxEstado.Image");
            pictureBoxEstado.Location = new Point(76, 28);
            pictureBoxEstado.Name = "pictureBoxEstado";
            pictureBoxEstado.Size = new Size(51, 51);
            pictureBoxEstado.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxEstado.TabIndex = 1;
            pictureBoxEstado.TabStop = false;
            pictureBoxEstado.Click += pictureBoxEstado_Click;
            // 
            // pictureBoxImagenMesa
            // 
            pictureBoxImagenMesa.Image = (Image)resources.GetObject("pictureBoxImagenMesa.Image");
            pictureBoxImagenMesa.Location = new Point(43, 62);
            pictureBoxImagenMesa.Name = "pictureBoxImagenMesa";
            pictureBoxImagenMesa.Size = new Size(113, 91);
            pictureBoxImagenMesa.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagenMesa.TabIndex = 0;
            pictureBoxImagenMesa.TabStop = false;
            pictureBoxImagenMesa.Click += pictureBoxImagenMesa_Click;
            // 
            // MiMesa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            Controls.Add(panelMesa);
            Name = "MiMesa";
            Size = new Size(201, 191);
            panelMesa.ResumeLayout(false);
            panelMesa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEstado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagenMesa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMesa;
        private PictureBox pictureBoxEstado;
        private PictureBox pictureBoxImagenMesa;
        private Label lblDescripcionPuntoVenta;
        private Label lblCodigoPuntoVenta;
        private Label lblCodigoMesa;
        private Label lblDescripcionMesa;
        private Label lblCodigoTurno;
        private Label lblCodigoUsuario;
    }
}
