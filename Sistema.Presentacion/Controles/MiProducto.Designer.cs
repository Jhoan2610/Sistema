namespace Sistema.Presentacion.Controles
{
    partial class MiProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiProducto));
            PnlProducto = new Panel();
            LblCodigoProducto = new Label();
            LblImpresora = new Label();
            LblArchivoTxt = new Label();
            lblPrecioProducto = new Label();
            LblDescripcionProducto = new Label();
            PictureBoxImagenProducto = new PictureBox();
            PnlProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxImagenProducto).BeginInit();
            SuspendLayout();
            // 
            // PnlProducto
            // 
            PnlProducto.BorderStyle = BorderStyle.FixedSingle;
            PnlProducto.Controls.Add(LblCodigoProducto);
            PnlProducto.Controls.Add(LblImpresora);
            PnlProducto.Controls.Add(LblArchivoTxt);
            PnlProducto.Controls.Add(lblPrecioProducto);
            PnlProducto.Controls.Add(LblDescripcionProducto);
            PnlProducto.Controls.Add(PictureBoxImagenProducto);
            PnlProducto.Dock = DockStyle.Fill;
            PnlProducto.Location = new Point(0, 0);
            PnlProducto.Name = "PnlProducto";
            PnlProducto.Size = new Size(200, 220);
            PnlProducto.TabIndex = 0;
            // 
            // LblCodigoProducto
            // 
            LblCodigoProducto.AutoSize = true;
            LblCodigoProducto.Font = new Font("Tahoma", 10F);
            LblCodigoProducto.Location = new Point(3, 50);
            LblCodigoProducto.Name = "LblCodigoProducto";
            LblCodigoProducto.Size = new Size(29, 21);
            LblCodigoProducto.TabIndex = 5;
            LblCodigoProducto.Text = "CP";
            LblCodigoProducto.Visible = false;
            // 
            // LblImpresora
            // 
            LblImpresora.AutoSize = true;
            LblImpresora.Font = new Font("Tahoma", 10F);
            LblImpresora.Location = new Point(0, 80);
            LblImpresora.Name = "LblImpresora";
            LblImpresora.Size = new Size(39, 21);
            LblImpresora.TabIndex = 4;
            LblImpresora.Text = "Imp";
            LblImpresora.Visible = false;
            // 
            // LblArchivoTxt
            // 
            LblArchivoTxt.AutoSize = true;
            LblArchivoTxt.Font = new Font("Tahoma", 10F);
            LblArchivoTxt.Location = new Point(-2, 115);
            LblArchivoTxt.Name = "LblArchivoTxt";
            LblArchivoTxt.Size = new Size(34, 21);
            LblArchivoTxt.TabIndex = 3;
            LblArchivoTxt.Text = "Txt";
            LblArchivoTxt.Visible = false;
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.AutoSize = true;
            lblPrecioProducto.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecioProducto.Location = new Point(70, 187);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(57, 22);
            lblPrecioProducto.TabIndex = 2;
            lblPrecioProducto.Text = "Precio";
            // 
            // LblDescripcionProducto
            // 
            LblDescripcionProducto.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDescripcionProducto.Location = new Point(46, 150);
            LblDescripcionProducto.Name = "LblDescripcionProducto";
            LblDescripcionProducto.Size = new Size(121, 24);
            LblDescripcionProducto.TabIndex = 1;
            LblDescripcionProducto.Text = "Producto X";
            LblDescripcionProducto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PictureBoxImagenProducto
            // 
            PictureBoxImagenProducto.BackgroundImageLayout = ImageLayout.None;
            PictureBoxImagenProducto.Image = (Image)resources.GetObject("PictureBoxImagenProducto.Image");
            PictureBoxImagenProducto.Location = new Point(46, 50);
            PictureBoxImagenProducto.Name = "PictureBoxImagenProducto";
            PictureBoxImagenProducto.Size = new Size(107, 86);
            PictureBoxImagenProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxImagenProducto.TabIndex = 0;
            PictureBoxImagenProducto.TabStop = false;
            PictureBoxImagenProducto.Click += PictureBoxImagenProducto_Click;
            // 
            // MiProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PnlProducto);
            Name = "MiProducto";
            Size = new Size(200, 220);
            PnlProducto.ResumeLayout(false);
            PnlProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxImagenProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlProducto;
        private PictureBox PictureBoxImagenProducto;
        private Label LblCodigoProducto;
        private Label LblImpresora;
        private Label LblArchivoTxt;
        private Label lblPrecioProducto;
        private Label LblDescripcionProducto;
    }
}
