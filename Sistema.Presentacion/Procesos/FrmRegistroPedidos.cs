using Sistema.Entidad;
using Sistema.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion.Procesos
{
    public partial class FrmRegistroPedidos : Form
    {
        public FrmRegistroPedidos(Usuario usuario)
        {
            InitializeComponent();
            Usuario = usuario;
        }
        //propiedad para recibir el usuario
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal Usuario Usuario { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CodigoMesa { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string DescripcionMesa { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image EstadoMesa { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int EstadoMesaDisponible { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CodigoPuntoVenta { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string DescripcionPuntoVenta { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CodigoUsuario { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CodigoTurno { get; set; }
       

        #region "Mis Metodos"

        // Cargar puntos de venta disponibles asincrónicamente
        private async Task CargarPuntosVentaAsync()
        {
            try
            {
                cmbPuntosVenta.DataSource = await NPuntoVenta.Listar("%");
                cmbPuntosVenta.ValueMember = "codigo_pv";
                cmbPuntosVenta.DisplayMember = "descripcion_pv";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar puntos de venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método asincrónico para mostrar el estado de un punto de venta
        private async Task EstadoTurnoPuntoVenta(int codigo)
        {
            try
            {
                DataTable tabla = await NRegistroPedidos.EstadoTurnoPuntoVenta(codigo);
                if (tabla != null && tabla.Rows.Count > 0)
                {
                    txtFechaTrabajo.Text = Convert.ToString(tabla.Rows[0][0]);
                    txtEstado.Text = Convert.ToString(tabla.Rows[0][4]);
                    txtTurno.Text = Convert.ToString(tabla.Rows[0][2]);
                    CodigoTurno = Convert.ToInt32(tabla.Rows[0][1]);

                    lblMensaje.Visible = (txtEstado.Text == "Cerrado");
                }
                else
                {
                    txtFechaTrabajo.Text = "Ninguno";
                    txtEstado.Text = "Ninguno";
                    txtTurno.Text = "Ninguno";
                    lblMensaje.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al consultar turno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Llenar contenedor de mesas asincrónicamente
        private async Task LlenarPuntoVentaAsync(FlowLayoutPanel contenedor)
        {
            if (txtEstado.Text == "Abierto" && cmbPuntosVenta.SelectedValue != null)
            {
                contenedor.Controls.Clear();

                try
                {
                    byte[] imagen1 = await NRegistroPedidos.ImagenEstadoMesa(1); // Mesa disponible
                    byte[] imagen2 = await NRegistroPedidos.ImagenEstadoMesa(0); // Mesa no disponible

                    Image imgDisponible = null;
                    Image imgNoDisponible = null;

                    if (imagen1 != null && imagen1.Length > 0)
                    {
                        using (MemoryStream ms1 = new MemoryStream(imagen1))
                        {
                            imgDisponible = Image.FromStream(ms1);
                        }
                    }

                    if (imagen2 != null && imagen2.Length > 0)
                    {
                        using (MemoryStream ms2 = new MemoryStream(imagen2))
                        {
                            imgNoDisponible = Image.FromStream(ms2);
                        }
                    }

                    int idPuntoVenta = Convert.ToInt32(cmbPuntosVenta.SelectedValue);
                    DataTable tabla = await NRegistroPedidos.MostrarMesas(idPuntoVenta);

                    if (tabla != null && tabla.Rows.Count > 0)
                    {
                        for (int fila = 0; fila < tabla.Rows.Count; fila++)
                        {
                            CodigoMesa = Convert.ToInt32(tabla.Rows[fila][0]);
                            DescripcionMesa = Convert.ToString(tabla.Rows[fila][1]);

                            if (Convert.ToInt32(tabla.Rows[fila][2]) == 1)
                            {
                                EstadoMesaDisponible = 1;
                                EstadoMesa = imgDisponible;
                            }
                            else
                            {
                                EstadoMesaDisponible = 0;
                                EstadoMesa = imgNoDisponible;
                            }

                            CodigoPuntoVenta = Convert.ToInt32(tabla.Rows[fila][3]);
                            DescripcionPuntoVenta = Convert.ToString(tabla.Rows[fila][4]);
                            CodigoUsuario = Usuario.CodigoUsuario;

                            // Crear instancia del control de usuario MiMesa
                            Controles.MiMesa miMesa = new Controles.MiMesa
                            {
                                Codigo = CodigoMesa,
                                Descripcion = DescripcionMesa,
                                Disponible = EstadoMesa,
                                CodigoPV = CodigoPuntoVenta,
                                DescripcionPV = DescripcionPuntoVenta,
                                CodigoUsuario = CodigoUsuario,
                                CodigoTurno = CodigoTurno,
                                DisponibleEstado = EstadoMesaDisponible,
                                //añadimos fecha de emision
                                FechaEmision = txtFechaTrabajo.Text
                            };

                            // Añadir el control al panel contenedor
                            contenedor.Controls.Add(miMesa);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al cargar mesas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Si el turno no está abierto o no hay selección, se limpian los controles
                contenedor.Controls.Clear();
            }
        }
        #endregion

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await this.CargarPuntosVentaAsync();
        }

        private async void FrmRegistroPedidos_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "El punto de venta se encuentra cerrado. Contacte al administrador.";
            await this.CargarPuntosVentaAsync();
        }

        private async void cmbPuntosVenta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbPuntosVenta.SelectedValue != null)
            {
                int codigoPv = Convert.ToInt32(cmbPuntosVenta.SelectedValue);
                await this.EstadoTurnoPuntoVenta(codigoPv);
                await this.LlenarPuntoVentaAsync(flowLayoutPanel1);
            }
        }

        private void cbmPuntosVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Evento retenido para evitar romper asignaciones de diseñador
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (cmbPuntosVenta.SelectedValue != null && Convert.ToInt32(cmbPuntosVenta.SelectedValue) > 0)
            {
                await this.EstadoTurnoPuntoVenta(Convert.ToInt32(cmbPuntosVenta.SelectedValue));
            }
        }
    }
}