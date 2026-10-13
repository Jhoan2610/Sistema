using Sistema.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion.Procesos
{
    public partial class FrmCierreTurnos : Form
    {
        public FrmCierreTurnos()
        {
            InitializeComponent();
        }

        #region "Variables Globales"
        int codigoTurno = 0;
        int codigoPV = 0;
        #endregion

        #region "Metodos"

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Punto de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //metodo para mostrar un mensaje de OK
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Punto de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Dar formato al dataGridView
        private void Formato()
        {
            if (DgvPuntosVenta.Columns.Count >= 2)
            {
                DgvPuntosVenta.Columns[0].Width = 120;
                DgvPuntosVenta.Columns[0].HeaderText = "CÓDIGO PV";
                DgvPuntosVenta.Columns[1].Width = 530;
                DgvPuntosVenta.Columns[1].HeaderText = "PUNTO DE VENTA";
            }
        }

        private async Task Listar(string valor)
        {
            try
            {
                DgvPuntosVenta.DataSource = await NPuntoVenta.Listar(valor);
                this.Formato();
            }
            catch (Exception ex)
            {
                this.MensajeError(ex.Message);
            }
        }

        private void SeleccionarItem()
        {
            if (DgvPuntosVenta.CurrentRow != null && DgvPuntosVenta.CurrentRow.Cells[0].Value != null)
            {
                codigoPV = Convert.ToInt32(DgvPuntosVenta.CurrentRow.Cells[0].Value);
                LblPuntoVenta.Text = Convert.ToString(DgvPuntosVenta.CurrentRow.Cells[1].Value);
            }
            else
            {
                this.MensajeError("Debe seleccionar un registro.");
            }
        }

        private async Task EstadoTurnoPuntosVentaAsync(int codigo)
        {
            try
            {
                DataTable tabla = await NRegistroPedidos.EstadoTurnoPuntoVenta(codigo);
                if (tabla != null && tabla.Rows.Count > 0)
                {
                    LblFechaTrabajo.Text = tabla.Rows[0][0].ToString();
                    LblEstadoTurno.Text = Convert.ToString(tabla.Rows[0][4]);
                    LblTurno.Text = Convert.ToString(tabla.Rows[0][2]);
                    codigoTurno = Convert.ToInt32(tabla.Rows[0][1]);

                    if (LblEstadoTurno.Text == "Abierto")
                    {
                        BtnAbrirTurno.Enabled = false;
                        BtnCerrarTurno.Enabled = true;
                    }
                    else if (LblEstadoTurno.Text == "Cerrado")
                    {
                        BtnAbrirTurno.Enabled = true;
                        BtnCerrarTurno.Enabled = false;
                    }
                }
                else
                {
                    LblFechaTrabajo.Text = "";
                    LblEstadoTurno.Text = "";
                    LblTurno.Text = "";

                    BtnAbrirTurno.Enabled = true;
                    BtnCerrarTurno.Enabled = false;

                    codigoTurno = 0;
                }
            }
            catch (Exception ex)
            {
                this.MensajeError(ex.Message);
            }
        }

        #endregion

        private async void FrmCierreTurnos_Load(object sender, EventArgs e)
        {
            await this.Listar("%");
        }

        private async void DgvPuntosVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.SeleccionarItem();
                await this.EstadoTurnoPuntosVentaAsync(codigoPV);
            }
        }

        private async void BtnAbrirTurno_Click(object sender, EventArgs e)
        {
            if (DgvPuntosVenta.CurrentRow != null && DgvPuntosVenta.CurrentRow.Cells[0].Value != null)
            {
                codigoPV = Convert.ToInt32(DgvPuntosVenta.CurrentRow.Cells[0].Value);
            }

            if (codigoPV > 0)
            {
                try
                {
                    if (MessageBox.Show("¿Desea abrir el turno siguiente?", "Aviso de Apertura de Turno", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string respuesta = "";
                        string fechaCierreTurno = LblFechaTrabajo.Text.Trim();

                        if (string.IsNullOrEmpty(fechaCierreTurno))
                        {
                            fechaCierreTurno = DateTime.Now.ToString();
                            codigoTurno = 1;
                        }
                        else
                        {
                            if (codigoTurno == 1)
                            {
                                codigoTurno = 2;
                            }
                            else if (codigoTurno == 2)
                            {
                                DateTime nueva_fecha = Convert.ToDateTime(fechaCierreTurno);
                                nueva_fecha = nueva_fecha.AddDays(1);
                                fechaCierreTurno = nueva_fecha.ToString();
                                codigoTurno = 1;
                            }
                        }

                        respuesta = await NCierreTurnos.AbrirTurnoAsync(fechaCierreTurno, codigoPV, codigoTurno);

                        if (respuesta == "OK")
                        {
                            await this.EstadoTurnoPuntosVentaAsync(codigoPV);
                            this.MensajeOK("Punto de venta abierto.");
                        }
                        else
                        {
                            this.MensajeError(respuesta);
                        }
                    }
                }
                catch (Exception ex)
                {
                    this.MensajeError(ex.Message);
                }
            }
            else
            {
                this.MensajeError("No se tiene información sobre este punto de venta.");
            }
        }

        private async void BtnCerrarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea cerrar el turno?", "Aviso de Cierre de Turno", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string respuesta;
                    string fechaCierreTurno = LblFechaTrabajo.Text;
                    respuesta = await NCierreTurnos.CerrarTurnoAsync(fechaCierreTurno, codigoPV, codigoTurno);

                    if (respuesta == "OK")
                    {
                        await this.EstadoTurnoPuntosVentaAsync(codigoPV);
                        this.MensajeOK("Punto de venta cerrado.");
                    }
                    else
                    {
                        this.MensajeError(respuesta);
                    }
                }
            }
            catch (Exception ex)
            {
                this.MensajeError(ex.Message);
            }
        }

        private void LblFechaTrabajo_Click(object sender, EventArgs e)
        {

        }

        private void LblPuntoVenta_Click(object sender, EventArgs e)
        {

        }
    }
}