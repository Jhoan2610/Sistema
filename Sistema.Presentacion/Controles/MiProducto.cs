using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema.Presentacion.Controles
{
    public partial class MiProducto : UserControl
    {
        public MiProducto()
        {
            InitializeComponent();
        }

        #region "Variables y propiedades"
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CodigoProducto
        {
            get { return Convert.ToInt32(LblCodigoProducto.Text); }
            set { LblCodigoProducto.Text = value.ToString(); }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string DescripcionProducto
        {
            get { return LblDescripcionProducto.Text; }
            set { LblDescripcionProducto.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Impresora
        {
            get { return LblImpresora.Text; }
            set { LblImpresora.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string PrecioUnitarioProducto
        {
            get { return lblPrecioProducto.Text; }
            set { lblPrecioProducto.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ArchivoTxt
        {
            get { return LblArchivoTxt.Text; }
            set { LblArchivoTxt.Text = value; }

        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image ImagenProducto
        {
            get { return PictureBoxImagenProducto.Image; }
            set { PictureBoxImagenProducto.Image = value; }
        }

        #endregion

        private void PictureBoxImagenProducto_Click(object sender, EventArgs e)
        {
            using (StreamWriter escribir = new StreamWriter(@"C:\test\" + ArchivoTxt + ".txt", true))
            {
                try
                {
                    escribir.WriteLine($"descripcion_pr: {DescripcionProducto}");
                    escribir.WriteLine($"precio_pr: {PrecioUnitarioProducto}");
                    escribir.WriteLine($"codigo_pr: {CodigoProducto}");
                    escribir.WriteLine($"impresora: {Impresora}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }
    }
}
