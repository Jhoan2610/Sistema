using Sistema.Entidad;
using Sistema.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        #region "Variables Globales"
        int codigo = 0; // Manejar el código del cliente
        int opcion = 0; // 1: Insertar, 2: Actualizar
        #endregion

        #region "Metodos"
        // Metodo para mostrar un mensaje cuando algo salga bien
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Modulo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Metodo para mostrar un mensaje cuando algo salga mal
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Modulo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Metodo para darle formato al DgvListado
        private void Formato()
        {
            // --- 1. CONFIGURACIÓN GENERAL DEL DATAGRIDVIEW ---
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

            // --- 2. ESTILO DEL ENCABEZADO ---
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

            // --- 3. ESTILO DE FILAS Y SELECCIÓN ---
            DgvListado.RowTemplate.Height = 35;

            DataGridViewCellStyle rowStyle = new DataGridViewCellStyle();
            rowStyle.BackColor = Color.White;
            rowStyle.ForeColor = Color.FromArgb(51, 65, 85);
            rowStyle.Font = new Font("Century Gothic", 9.5F, FontStyle.Regular);
            rowStyle.SelectionBackColor = Color.FromArgb(204, 229, 255);
            rowStyle.SelectionForeColor = Color.FromArgb(0, 51, 102);
            rowStyle.Padding = new Padding(10, 0, 0, 0);
            DgvListado.RowsDefaultCellStyle = rowStyle;

            // --- 4. FILAS ALTERNADAS ---
            DataGridViewCellStyle altRowStyle = new DataGridViewCellStyle();
            altRowStyle.BackColor = Color.FromArgb(248, 250, 252);
            altRowStyle.ForeColor = Color.FromArgb(51, 65, 85);
            altRowStyle.SelectionBackColor = Color.FromArgb(204, 229, 255);
            altRowStyle.SelectionForeColor = Color.FromArgb(0, 51, 102);
            altRowStyle.Padding = new Padding(10, 0, 0, 0);
            DgvListado.AlternatingRowsDefaultCellStyle = altRowStyle;

            // --- 5. MAPEO Y FORMATO DE COLUMNAS ---
            if (DgvListado.Columns.Count >= 9)
            {
                DgvListado.Columns[0].HeaderText = "CÓDIGO";
                DgvListado.Columns[0].Width = 100;

                DgvListado.Columns[1].HeaderText = "NOMBRE / RAZÓN SOCIAL";
                DgvListado.Columns[1].Width = 180;

                DgvListado.Columns[2].Visible = false; // codigo_tdc

                DgvListado.Columns[3].HeaderText = "TIPO DOC.";
                DgvListado.Columns[3].Width = 110;

                DgvListado.Columns[4].HeaderText = "Nº DOCUMENTO";
                DgvListado.Columns[4].Width = 140;

                DgvListado.Columns[5].HeaderText = "TELÉFONO";
                DgvListado.Columns[5].Width = 130;

                DgvListado.Columns[6].HeaderText = "MÓVIL";
                DgvListado.Columns[6].Width = 130;

                DgvListado.Columns[7].HeaderText = "EMAIL";
                DgvListado.Columns[7].Width = 200;

                DgvListado.Columns[8].HeaderText = "DIRECCIÓN";
                DgvListado.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                // Ocultar columnas adicionales de auditoría/estado si existen
                for (int i = 9; i < DgvListado.Columns.Count; i++)
                {
                    DgvListado.Columns[i].Visible = false;
                }
            }
        }

        // Metodo para limpiar los controles de texto
        private void LimpiarTexto()
        {
            txtEmail.Clear();
            TxtNombre.Clear();
            TxtNumDocumento.Clear();
            TxtTelefono.Clear();
            TxtMovil.Clear();
            txtDireccion.Clear();
            if (CmbTipoDoc.Items.Count > 0)
            {
                CmbTipoDoc.SelectedIndex = 0;
            }
        }

        // Metodo para activar o desactivar las cajas de texto
        private void EstadoTexto(bool estado)
        {
            TxtNombre.ReadOnly = !estado;
            TxtNumDocumento.ReadOnly = !estado;
            TxtTelefono.ReadOnly = !estado;
            TxtMovil.ReadOnly = !estado;
            txtEmail.ReadOnly = !estado;
            txtDireccion.ReadOnly = !estado;
            CmbTipoDoc.Enabled = estado;
        }

        // Metodo para controlar el estado de los botones de la pantalla de consulta
        private void EstadoBotones(bool estado)
        {
            BtnActualizar.Enabled = estado;
            BtnEliminar.Enabled = estado;
            BtnNuevo.Enabled = estado;
            BtnReporte.Enabled = estado;
            BtnRetornar.Enabled = estado;
        }

        // Metodo para controlar el estado de los botones de procesos (mantenimiento)
        private void EstadoBotonesProcesos(bool estado)
        {
            BtnGuardar.Visible = estado;
            BtnRetornar.Visible = !estado;
            BtnCancelar.Visible = estado;
        }

        // Metodo para seleccionar un registro del DataGridView
        private void SeleccionarItem()
        {
            if (DgvListado.CurrentRow != null)
            {
                codigo = Convert.ToInt32(DgvListado.CurrentRow.Cells[0].Value);
                TxtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells[1].Value);
                if (DgvListado.CurrentRow.Cells[2].Value != DBNull.Value)
                {
                    CmbTipoDoc.SelectedValue = Convert.ToInt32(DgvListado.CurrentRow.Cells[2].Value);
                }
                TxtNumDocumento.Text = Convert.ToString(DgvListado.CurrentRow.Cells[4].Value);
                TxtTelefono.Text = Convert.ToString(DgvListado.CurrentRow.Cells[5].Value);
                TxtMovil.Text = Convert.ToString(DgvListado.CurrentRow.Cells[6].Value);
                txtEmail.Text = Convert.ToString(DgvListado.CurrentRow.Cells[7].Value);
                txtDireccion.Text = Convert.ToString(DgvListado.CurrentRow.Cells[8].Value);
            }
        }

        // Cargar combobox de tipos de documentos asincrónicamente
        private async Task CargarTiposDocumentoAsync()
        {
            try
            {
                CmbTipoDoc.DataSource = await NCliente.ListarTipoDocAsync();
                CmbTipoDoc.DisplayMember = "descripcion_tdc";
                CmbTipoDoc.ValueMember = "codigo_tdc";
            }
            catch (Exception ex)
            {
                this.MensajeError(ex.Message);
            }
        }

        // Mostrar listado de clientes asincrónicamente
        private async Task Listar(string valor)
        {
            try
            {
                DgvListado.DataSource = await NCliente.Listar(valor);
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

        // Filtrar clientes
        private async Task BuscarAsync(string valor)
        {
            await this.Listar(valor);
        }

        // Insertar Cliente
        private async Task InsertarAsync()
        {
            string Respuesta = "";
            try
            {
                if (TxtNombre.Text == string.Empty || CmbTipoDoc.SelectedValue == null || TxtNumDocumento.Text == string.Empty)
                {
                    this.MensajeError("Complete los campos obligatorios (*)");
                }
                else
                {
                    if (!string.IsNullOrEmpty(txtEmail.Text.Trim()) && await NCliente.Existe(txtEmail.Text.Trim()) == "1")
                    {
                        this.MensajeError("El correo electrónico ya se encuentra registrado.");
                        return;
                    }

                    Cliente cliente = new Cliente();
                    cliente.CodigoCl = codigo;
                    cliente.CodigoTdc = Convert.ToInt32(CmbTipoDoc.SelectedValue);
                    cliente.NumDocumentoCl = TxtNumDocumento.Text.Trim();
                    cliente.Nombre = TxtNombre.Text.Trim();
                    cliente.Telefono = TxtTelefono.Text.Trim();
                    cliente.Movil = TxtMovil.Text.Trim();
                    cliente.Email = txtEmail.Text.Trim();
                    cliente.Direccion = txtDireccion.Text.Trim();

                    Respuesta = await NCliente.Guardar(opcion, cliente);
                    if (Respuesta == "OK")
                    {
                        this.MensajeOk("El cliente se registró correctamente");
                        await this.Listar("%");
                        this.opcion = 0;
                        TabPrincipal.SelectedIndex = 0;
                    }
                    else
                    {
                        this.MensajeError(Respuesta);
                    }
                }
            }
            catch (Exception ex)
            {
                this.MensajeError(ex.Message);
            }
        }

        // Actualizar Cliente
        private async Task ActualizarAsync()
        {
            string Respuesta = "";
            try
            {
                if (DgvListado.CurrentCell is not null)
                {
                    if (TxtNombre.Text == string.Empty || CmbTipoDoc.SelectedValue == null || TxtNumDocumento.Text == string.Empty)
                    {
                        this.MensajeError("Complete los campos obligatorios (*)");
                        return;
                    }

                    Cliente cliente = new Cliente();
                    cliente.CodigoCl = codigo;
                    cliente.CodigoTdc = Convert.ToInt32(CmbTipoDoc.SelectedValue);
                    cliente.NumDocumentoCl = TxtNumDocumento.Text.Trim();
                    cliente.Nombre = TxtNombre.Text.Trim();
                    cliente.Telefono = TxtTelefono.Text.Trim();
                    cliente.Movil = TxtMovil.Text.Trim();
                    cliente.Email = txtEmail.Text.Trim();
                    cliente.Direccion = txtDireccion.Text.Trim();

                    Respuesta = await NCliente.Guardar(opcion, cliente);
                    if (Respuesta == "OK")
                    {
                        this.MensajeOk("El cliente se actualizó correctamente");
                        await this.Listar("%");
                        this.opcion = 0;
                        TabPrincipal.SelectedIndex = 0;
                    }
                    else
                    {
                        this.MensajeError(Respuesta);
                    }
                }
                else
                {
                    this.MensajeError("Seleccione un Cliente");
                }
            }
            catch (Exception ex)
            {
                this.MensajeError(ex.Message);
            }
        }

        // Eliminar Cliente (Desactivar)
        private async Task Eliminar()
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el cliente seleccionado?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string Respuesta = await NCliente.Eliminar(codigo);
                    if (Respuesta == "OK")
                    {
                        this.MensajeOk("El cliente se eliminó correctamente");
                        await this.Listar("%");
                    }
                    else
                    {
                        this.MensajeError(Respuesta);
                    }
                }
            }
            catch (Exception ex)
            {
                this.MensajeError(ex.Message + ex.StackTrace);
            }
        }
        #endregion

        private async void FrmCliente_Load(object sender, EventArgs e)
        {
            await this.CargarTiposDocumentoAsync();
            await this.Listar("%");
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            opcion = 1; //nuevo registro
            this.LimpiarTexto();
            this.EstadoBotones(false);
            this.EstadoBotonesProcesos(true);
            this.EstadoTexto(true);
            TabPrincipal.SelectedIndex = 1; //mueve automaticamente a la pestaña de mantenimiento
            TxtNombre.Focus();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (DgvListado.CurrentCell is not null)
            {
                SeleccionarItem();
                opcion = 2;
                this.EstadoBotones(false);
                this.EstadoBotonesProcesos(true);
                this.EstadoTexto(true);
                BtnGuardar.Text = "Actualizar";
                TabPrincipal.SelectedIndex = 1;
            }
            else
            {
                this.MensajeError("Debe seleccionar un cliente");
            }
        }

        private void DgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListado.CurrentCell is not null)
            {
                SeleccionarItem();
            }
            else
            {
                this.MensajeError("Debe seleccionar un cliente");
            }
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvListado.CurrentCell is not null)
            {
                SeleccionarItem();
                await this.Eliminar();
            }
            else
            {
                this.MensajeError("Debe seleccionar un cliente");
            }
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            TabPrincipal.SelectedIndex = 0;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarTexto();
            this.EstadoBotones(true);
            this.EstadoBotonesProcesos(false);
            this.EstadoTexto(false);
            TabPrincipal.SelectedIndex = 0;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            await this.BuscarAsync(TxtBuscar.Text.Trim());
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
    }
}