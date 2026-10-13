using Sistema.Datos;
using Sistema.Negocios;
using Sistema.Presentacion.Procesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion.Controles
{
    public partial class MiMesa : UserControl
    {
        public MiMesa()
        {
            InitializeComponent();
        }

        //Propiedades de la mesa

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Codigo
        {
            get
            {
                return Convert.ToInt32(lblCodigoMesa.Text);
            }
            set
            {
                lblCodigoMesa.Text = Convert.ToString(value);
            }
        }

 
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Descripcion
        {
            get
            {
                return lblDescripcionMesa.Text;
            }
            set
            {
                lblDescripcionMesa.Text = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CodigoPV
        {
            get
            {
                return Convert.ToInt32(lblCodigoPuntoVenta.Text);
            }
            set
            {
                lblCodigoPuntoVenta.Text = Convert.ToString(value);
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string DescripcionPV
        {
            get
            {
                return lblDescripcionPuntoVenta.Text;
            }
            set
            {
                lblDescripcionPuntoVenta.Text = value;
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CodigoUsuario
        {
            get
            {
                return Convert.ToInt32(lblCodigoUsuario.Text);
            }
            set
            {
                lblCodigoUsuario.Text = Convert.ToString(value);
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CodigoTurno
        {
            get
            {
                return Convert.ToInt32(lblCodigoTurno.Text);
            }
            set
            {
                lblCodigoTurno.Text = Convert.ToString(value);
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

        public string FechaEmision { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image Disponible
        {
            get
            {
                return pictureBoxEstado.Image;
            }
            set
            {
                pictureBoxEstado.Image = value;
            }
        }

        private int disponible;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int DisponibleEstado { get => disponible; set => disponible = value; }

        private async void pictureBoxImagenMesa_Click(object sender, EventArgs e)
        {
            // crear un objeto de formulario mesa abierta
            if (DisponibleEstado == 0)
            {
                MessageBox.Show("La mesa no está disponible.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Procesos.FrmMesaAbierta frmMesaAbierta = new FrmMesaAbierta();
                frmMesaAbierta.txtMesa.Text = Descripcion;
                frmMesaAbierta.txtPuntoVenta.Text = DescripcionPV;
                frmMesaAbierta.btnNuevoPedido.Focus();

                //esto es lo nuevo
                frmMesaAbierta.CodigoMesa = Codigo;
                frmMesaAbierta.CodigoTurno = CodigoTurno;
                frmMesaAbierta.FechaTrabajo = FechaEmision;
                frmMesaAbierta.CodigoUsuario = CodigoUsuario;

                try
                {
                    frmMesaAbierta.DgvListadoProductos.DataSource = await NMesaAbierta.ListarSubFamiliasAsync(CodigoPV);
                    frmMesaAbierta.Codigo_pv_pr = CodigoPV;
                    frmMesaAbierta.Archivotxt = DateTime.Now.Ticks.ToString();

                    //formato al dgv
                    if (frmMesaAbierta.DgvListadoProductos.Columns.Count >= 2)
                    {
                        frmMesaAbierta.DgvListadoProductos.Columns[0].Width = 230;
                        frmMesaAbierta.DgvListadoProductos.Columns[0].HeaderText = "SubFamilia";
                        frmMesaAbierta.DgvListadoProductos.Columns[1].Visible = false;
                    }

                    frmMesaAbierta.ShowDialog(); //bloquea la vista hasta que no se cierre
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al abrir la mesa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void pictureBoxEstado_Click(object sender, EventArgs e)
        {
            try
            {
                DMesa dmesa = new DMesa();

                byte[] imagen1 = await NRegistroPedidos.ImagenEstadoMesa(1);
                byte[] imagen2 = await NRegistroPedidos.ImagenEstadoMesa(0);

                if (DisponibleEstado == 1)
                {
                    await dmesa.DisponibleAsync(Codigo, 0);
                    DisponibleEstado = 0;

                    if (imagen2 != null && imagen2.Length > 0)
                    {
                        using (MemoryStream ms2 = new MemoryStream(imagen2))
                        {
                            Disponible = Image.FromStream(ms2);
                        }
                    }
                }
                else
                {
                    await dmesa.DisponibleAsync(Codigo, 1);
                    DisponibleEstado = 1;

                    if (imagen1 != null && imagen1.Length > 0)
                    {
                        using (MemoryStream ms1 = new MemoryStream(imagen1))
                        {
                            Disponible = Image.FromStream(ms1);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cambiar estado de la mesa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}