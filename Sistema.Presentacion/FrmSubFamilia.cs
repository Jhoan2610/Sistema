using Sistema.Negocios;
using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmSubFamilia : Form
    {
        public FrmSubFamilia()
        {
            InitializeComponent();
        }

        #region "Variables Globales"
        int codigo = 0;    // Código de la subfamilia seleccionada
        int opcion = 0;    // 1: Nuevo, 2: Actualizar
        #endregion

        #region "Metodos"
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Módulo de SubFamilia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Módulo de SubFamilia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Formato()
        {
            // CONFIGURACIÓN GENERAL DEL DATAGRIDVIEW
            DgvListado.BorderStyle = BorderStyle.None;
            DgvListado.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvListado.BackgroundColor = Color.FromArgb(245, 247, 250);
            DgvListado.EnableHeadersVisualStyles = false;
            DgvListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListado.MultiSelect = false;
            DgvListado.AllowUserToAddRows = false;
            DgvListado.AllowUserToDeleteRows = false;
            DgvListado.AllowUserToResizeRows = false;
            DgvListado.RowHeadersVisible = false;
            DgvListado.GridColor = Color.FromArgb(226, 232, 240);

            // ENCABEZADOS
            DgvListado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DgvListado.ColumnHeadersHeight = 40;

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.BackColor = Color.FromArgb(0, 120, 212);
            headerStyle.ForeColor = Color.White;
            headerStyle.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.Padding = new Padding(10, 0, 0, 0);
            DgvListado.ColumnHeadersDefaultCellStyle = headerStyle;

            // FILAS Y SELECCIÓN
            DgvListado.RowTemplate.Height = 35;

            DataGridViewCellStyle rowStyle = new DataGridViewCellStyle();
            rowStyle.BackColor = Color.White;
            rowStyle.ForeColor = Color.FromArgb(51, 65, 85);
            rowStyle.Font = new Font("Century Gothic", 9.5F, FontStyle.Regular);
            rowStyle.SelectionBackColor = Color.FromArgb(204, 229, 255);
            rowStyle.SelectionForeColor = Color.FromArgb(0, 51, 102);
            rowStyle.Padding = new Padding(10, 0, 0, 0);
            DgvListado.RowsDefaultCellStyle = rowStyle;

            // FILAS ALTERNADAS
            DataGridViewCellStyle altRowStyle = new DataGridViewCellStyle();
            altRowStyle.BackColor = Color.FromArgb(248, 250, 252);
            altRowStyle.ForeColor = Color.FromArgb(51, 65, 85);
            altRowStyle.SelectionBackColor = Color.FromArgb(204, 229, 255);
            altRowStyle.SelectionForeColor = Color.FromArgb(0, 51, 102);
            altRowStyle.Padding = new Padding(10, 0, 0, 0);
            DgvListado.AlternatingRowsDefaultCellStyle = altRowStyle;

            // MAPEO DE COLUMNAS SEGÚN EL STORED PROCEDURE
            if (DgvListado.Columns.Count >= 3)
            {
                DgvListado.Columns[0].Width = 120;
                DgvListado.Columns[0].HeaderText = "CÓDIGO SUBFAMILIA";

                DgvListado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DgvListado.Columns[1].HeaderText = "DESCRIPCIÓN SUBFAMILIA";

                DgvListado.Columns[2].Width = 250;
                DgvListado.Columns[2].HeaderText = "FAMILIA";

                if (DgvListado.Columns.Count >= 4)
                {
                    DgvListado.Columns[3].Visible = false;
                }
            }
        }

        private void LimpiarTexto()
        {
            TxtDescripcion.Clear();
        }

        private void EstadoTexto(bool estado)
        {
            TxtDescripcion.ReadOnly = !estado;
            CmbFamilia.Enabled = estado;
        }

        private void EstadoBotones(bool estado)
        {
            BtnActualizar.Enabled = estado;
            BtnEliminar.Enabled = estado;
            BtnNuevo.Enabled = estado;
            BtnReporte.Enabled = estado;
            BtnRetornar.Enabled = estado;
        }

        private void EstadoBotonesProcesos(bool estado)
        {
            BtnGuardar.Visible = estado;
            BtnRetornar.Visible = !estado;
            BtnCancelar.Visible = estado;
        }

        private void SeleccionarItem()
        {
            if (DgvListado.CurrentRow != null)
            {
                codigo = Convert.ToInt32(DgvListado.CurrentRow.Cells[0].Value);
                TxtDescripcion.Text = Convert.ToString(DgvListado.CurrentRow.Cells[1].Value);
                if (DgvListado.Columns.Count >= 4 && DgvListado.CurrentRow.Cells[3].Value != DBNull.Value)
                {
                    CmbFamilia.SelectedValue = Convert.ToInt32(DgvListado.CurrentRow.Cells[3].Value);
                }
            }
        }

        private async Task CargarFamiliasAsync()
        {
            try
            {
                CmbFamilia.DataSource = await NFamilia.Listar("%");
                CmbFamilia.DisplayMember = "descripcion_fa";
                CmbFamilia.ValueMember = "codigo_fa";
            }
            catch (Exception ex)
            {
                this.MensajeError(ex.Message);
            }
        }

        private async Task Listar(string valor)
        {
            try
            {
                DgvListado.DataSource = await NSubFamilia.Listar(valor);
                DgvListado.ClearSelection();
                DgvListado.CurrentCell = null;
                this.Formato();
                LblTotal.Text = "Total Registros: " + DgvListado.RowCount.ToString();

                this.LimpiarTexto();
                this.EstadoBotones(true);
                this.EstadoBotonesProcesos(false);
                this.EstadoTexto(false);
            }
            catch (Exception ex)
            {
                this.MensajeError(ex.Message);
            }
        }

        private async Task BuscarAsync(string valor)
        {
            await this.Listar(valor);
        }

        private async Task InsertarAsync()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtDescripcion.Text) || CmbFamilia.SelectedValue == null)
                {
                    this.MensajeError("Complete los campos obligatorios");
                    return;
                }

                if (await NSubFamilia.Existe(TxtDescripcion.Text.Trim()) == "1")
                {
                    this.MensajeError("La Subfamilia ya existe.");
                    return;
                }

                string respuesta = await NSubFamilia.Guardar(opcion, codigo, Convert.ToInt32(CmbFamilia.SelectedValue), TxtDescripcion.Text.Trim());
                if (respuesta == "OK")
                {
                    this.MensajeOk("La Subfamilia se insertó correctamente");
                    await this.Listar("%");
                    this.opcion = 0;
                    TabPrincipal.SelectedIndex = 0;
                }
                else
                {
                    this.MensajeError(respuesta);
                }
            }
            catch (Exception ex)
            {
                this.MensajeError(ex.Message);
            }
        }

        private async Task ActualizarAsync()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtDescripcion.Text) || CmbFamilia.SelectedValue == null)
                {
                    this.MensajeError("Complete los campos obligatorios");
                    return;
                }

                string respuesta = await NSubFamilia.Guardar(opcion, codigo, Convert.ToInt32(CmbFamilia.SelectedValue), TxtDescripcion.Text.Trim());
                if (respuesta == "OK")
                {
                    this.MensajeOk("La Subfamilia se actualizó correctamente");
                    await this.Listar("%");
                    this.opcion = 0;
                    TabPrincipal.SelectedIndex = 0;
                }
                else
                {
                    this.MensajeError(respuesta);
                }
            }
            catch (Exception ex)
            {
                this.MensajeError(ex.Message);
            }
        }

        private async Task Eliminar()
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar la Subfamilia seleccionada?", "Eliminar Subfamilia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string respuesta = await NSubFamilia.Eliminar(codigo);
                    if (respuesta == "OK")
                    {
                        this.MensajeOk("La Subfamilia se eliminó correctamente");
                        await this.Listar("%");
                    }
                    else
                    {
                        this.MensajeError(respuesta);
                    }
                }
            }
            catch (Exception ex)
            {
                this.MensajeError(ex.Message + ex.StackTrace);
            }
        }
        #endregion

        private async void FrmSubFamilia_Load(object sender, EventArgs e)
        {
            await this.Listar("%");
            await this.CargarFamiliasAsync();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            opcion = 1;
            this.LimpiarTexto();
            this.EstadoBotones(false);
            this.EstadoBotonesProcesos(true);
            this.EstadoTexto(true);
            BtnGuardar.Text = "Guardar";
            TabPrincipal.SelectedIndex = 1;
            TxtDescripcion.Focus();
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (opcion == 1)
            {
                await this.InsertarAsync();
            }
            else if (opcion == 2)
            {
                await this.ActualizarAsync();
            }
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            await this.BuscarAsync(TxtBuscar.Text.Trim());
        }

        private void DgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListado.CurrentRow is not null)
            {
                SeleccionarItem();
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (DgvListado.CurrentRow is not null)
            {
                opcion = 2;
                this.SeleccionarItem();
                this.EstadoBotones(false);
                this.EstadoBotonesProcesos(true);
                this.EstadoTexto(true);
                BtnGuardar.Text = "Actualizar";
                TabPrincipal.SelectedIndex = 1;
            }
            else
            {
                this.MensajeError("Debe seleccionar una SubFamilia");
            }
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvListado.CurrentRow != null)
            {
                SeleccionarItem();
                await this.Eliminar();
            }
            else
            {
                this.MensajeError("Debe seleccionar una SubFamilia");
            }
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            TabPrincipal.SelectedIndex = 0;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarTexto();
            this.EstadoBotones(true);
            this.EstadoBotonesProcesos(false);
            this.EstadoTexto(false);
            TabPrincipal.SelectedIndex = 0;
        }
    }
}