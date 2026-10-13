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
    public partial class FrmMesas : Form
    {
        public FrmMesas()
        {
            InitializeComponent();
        }

        #region "Variables Globales"
        int codigo = 0; // aqui vamos a manejar el codigo de mesa que estemos instanciando
        int opcion = 0; // aqui vamos a pasar la opcion de crear nuevo (1) o actualizar existente (2)
        int codigo_pv = 0; // aqui vamos a manejar el codigo del punto de venta al que pertenece la mesa
        #endregion

        #region "Metodos"
        //Metodo para mostrar un mensaje cuando algo salga bien
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Modulo de Punto de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Metodo para mostrar un mensaje cuando algo salga mal
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Modulo de Punto de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Metodo para darle formato al DgvListado
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

            // --- 2. ESTILO DEL ENCABEZADO (Azul Corporativo) ---
            DgvListado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DgvListado.ColumnHeadersHeight = 40;

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.BackColor = Color.FromArgb(0, 120, 212); // Azul corporativo unificado
            headerStyle.ForeColor = Color.White;
            headerStyle.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.Padding = new Padding(10, 0, 0, 0);
            DgvListado.ColumnHeadersDefaultCellStyle = headerStyle;

            // --- 3. ESTILO DE FILAS Y SELECCIÓN (Azul Celeste) ---
            DgvListado.RowTemplate.Height = 35;

            DataGridViewCellStyle rowStyle = new DataGridViewCellStyle();
            rowStyle.BackColor = Color.White;
            rowStyle.ForeColor = Color.FromArgb(51, 65, 85);
            rowStyle.Font = new Font("Century Gothic", 9.5F, FontStyle.Regular);
            rowStyle.SelectionBackColor = Color.FromArgb(204, 229, 255); // Fondo celeste al seleccionar
            rowStyle.SelectionForeColor = Color.FromArgb(0, 51, 102);    // Texto azul marino
            rowStyle.Padding = new Padding(10, 0, 0, 0);
            DgvListado.RowsDefaultCellStyle = rowStyle;

            // --- 4. FILAS ALTERNADAS (Efecto Cebra) ---
            DataGridViewCellStyle altRowStyle = new DataGridViewCellStyle();
            altRowStyle.BackColor = Color.FromArgb(248, 250, 252);
            altRowStyle.ForeColor = Color.FromArgb(51, 65, 85);
            altRowStyle.SelectionBackColor = Color.FromArgb(204, 229, 255);
            altRowStyle.SelectionForeColor = Color.FromArgb(0, 51, 102);
            altRowStyle.Padding = new Padding(10, 0, 0, 0);
            DgvListado.AlternatingRowsDefaultCellStyle = altRowStyle;

            // --- 5. CONFIGURACIÓN Y MAPEO DE COLUMNAS (Mesas) ---
            if (DgvListado.Columns.Count >= 3)
            {
                // Columna 0: Código Mesa
                DgvListado.Columns[0].Width = 140;
                DgvListado.Columns[0].HeaderText = "CÓDIGO MESA";

                // Columna 1: Descripción de la Mesa
                DgvListado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DgvListado.Columns[1].HeaderText = "DESCRIPCIÓN MESA";

                // Columna 2: Nombre del Punto de Venta al que pertenece
                DgvListado.Columns[2].Width = 250;
                DgvListado.Columns[2].HeaderText = "PUNTO DE VENTA";
                DgvListado.Columns[2].Visible = true;

                // Columna 3: Ocultar el ID del Punto de Venta si la consulta lo retorna
                if (DgvListado.Columns.Count >= 4)
                {
                    DgvListado.Columns[3].Visible = false;
                }
            }
        }

        // Metodo para limpiar el TxtDescripcion
        private void LimpiarTexto()
        {
            TxtDescripcion.Clear();
        }

        //metodo para activar o desactivar el txtdescripcion y cmbpuntosventa
        private void EstadoTexto(bool estado)
        {
            TxtDescripcion.ReadOnly = !estado;
            CmbPuntosVenta.Enabled = estado;
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

        //metodo para controlar el estado de los botones de procesos(mantenimiento)
        private void EstadoBotonesProcesos(bool estado)
        {
            BtnGuardar.Visible = estado;
            BtnRetornar.Visible = !estado;
            BtnCancelar.Visible = estado;
        }

        //Metodo para seleccionar un registro del Dgv
        private void SeleccionarItem()
        {
            if (DgvListado.CurrentRow != null)
            {
                codigo = Convert.ToInt32(DgvListado.CurrentRow.Cells[0].Value);
                TxtDescripcion.Text = Convert.ToString(DgvListado.CurrentRow.Cells[1].Value);
                if (DgvListado.Columns.Count >= 4 && DgvListado.CurrentRow.Cells[3].Value != DBNull.Value)
                {
                    codigo_pv = Convert.ToInt32(DgvListado.CurrentRow.Cells[3].Value);
                    CmbPuntosVenta.SelectedValue = codigo_pv;
                }
            }
        }

        //listar puntos de ventas activos
        private async Task CargarPuntosVentaAsync()
        {
            try
            {
                CmbPuntosVenta.DataSource = await NPuntoVenta.Listar("%");
                //mostrar el texto del punto de venta
                CmbPuntosVenta.DisplayMember = "descripcion_pv";
                //asociar el codigo_pv
                CmbPuntosVenta.ValueMember = "codigo_pv";
            }
            catch (Exception ex)
            {
                this.MensajeError(ex.Message);
            }
        }

        //Mostrar listado de mesas asincrónicamente
        private async Task Listar(string valor)
        {
            try
            {
                //llenamos el DgvListado con el DataTable de la capa de negocios
                DgvListado.DataSource = await NMesa.Listar(valor);
                DgvListado.ClearSelection();
                DgvListado.CurrentCell = null;
                this.Formato(); // le damos formato al DgvListado
                LblTotal.Text = "Total Registros: " + DgvListado.RowCount.ToString();

                //resetear interfaz
                this.LimpiarTexto();
                this.EstadoBotones(true);
                this.EstadoBotonesProcesos(false);
                this.EstadoTexto(false);
            }
            catch (Exception ex)
            {
                this.MensajeError(ex.Message);
            }
        }//fin de listar()

        private void DgvListado_DefaultValuesNeeded(object? sender, DataGridViewRowEventArgs e)
        {
            throw new NotImplementedException();
        }

        //filtrar las mesas
        private async Task BuscarAsync(string valor)
        {
            await this.Listar(valor);
        }// fin de metodo buscar()

        //insertar una nueva mesa
        private async Task InsertarAsync()
        {
            string Respuesta = "";
            try
            {
                //validar que los campos obligatorios esten completos
                if (TxtDescripcion.Text == string.Empty || CmbPuntosVenta.SelectedValue == null)
                {
                    this.MensajeError("Complete los campos obligatorios");
                }
                else
                {
                    if (await NMesa.Existe(TxtDescripcion.Text.Trim()) == "1")
                    {
                        this.MensajeError("La mesa ya existe. Si se ha eliminado previamente, contactar al administrador");
                        return;
                    }
                    Respuesta = await NMesa.Guardar(opcion, codigo, Convert.ToInt32(CmbPuntosVenta.SelectedValue), TxtDescripcion.Text.Trim(), 1);
                    if (Respuesta == "OK")
                    {
                        this.MensajeOk("La mesa se insertó correctamente");
                        await this.Listar("%"); //refrescamos el DgvListado
                        this.opcion = 0; // reseteamos la variable global opcion
                        TabPrincipal.SelectedIndex = 0; // regresamos a la pestaña de consulta
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
        } //fin metodo insertar

        private async Task ActualizarAsync()
        {
            string Respuesta = "";
            try
            {
                if (DgvListado.CurrentCell is not null)
                {
                    //validar que los campos obligatorios esten completos
                    if (TxtDescripcion.Text == string.Empty || CmbPuntosVenta.SelectedValue == null)
                    {
                        this.MensajeError("Complete los campos obligatorios");
                    }
                    else
                    {
                        Respuesta = await NMesa.Guardar(opcion, codigo, Convert.ToInt32(CmbPuntosVenta.SelectedValue), TxtDescripcion.Text.Trim(), 1);
                        if (Respuesta == "OK")
                        {
                            this.MensajeOk("La mesa se actualizó correctamente");
                            await this.Listar("%"); //refrescamos el DgvListado
                            this.opcion = 0; // reseteamos la variable global opcion
                            TabPrincipal.SelectedIndex = 0; // regresamos a la pestaña de consulta
                        }
                        else
                        {
                            this.MensajeError(Respuesta);
                        }
                    }
                }
                else
                {
                    this.MensajeError("Seleccione una Mesa");
                }
            }
            catch (Exception ex)
            {
                this.MensajeError(ex.Message);
            }
        }
        //fin de actualizar

        //eliminar una mesa (desactivar)
        private async Task Eliminar()
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar la mesa seleccionada?", "Eliminar Mesa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //ejecutamos el metodo
                    string Respuesta = await NMesa.Eliminar(codigo);
                    if (Respuesta == "OK")
                    {
                        this.MensajeOk("La mesa se eliminó correctamente");
                        await this.Listar("%");
                    }
                    else
                    {
                        this.MensajeError(Respuesta);
                    }
                }
                else
                {
                    this.MensajeError("Seleccione una Mesa");
                }
            }
            catch (Exception ex)
            {
                this.MensajeError(ex.Message + ex.StackTrace);
            }
        }
        #endregion

        private async void FrmMesas_Load(object sender, EventArgs e)
        {
            await this.Listar("%");
            await this.CargarPuntosVentaAsync();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            opcion = 1; // indicamos que vamos a insertar un nuevo registro
            this.LimpiarTexto();
            this.EstadoBotones(false);
            this.EstadoBotonesProcesos(true);
            this.EstadoTexto(true);
            TabPrincipal.SelectedIndex = 1; // nos vamos a la pestaña de mantenimiento
            TxtDescripcion.Focus(); // ponemos el cursor en el txtdescripcion
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

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void DgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListado.CurrentCell is not null)
            {
                SeleccionarItem();
            }
            else
            {
                this.MensajeError("Debe haber seleccionado una Mesa");
            }
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
                this.MensajeError("Debe seleccionar una Mesa");
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
                this.MensajeError("Debe seleccionar una Mesa");
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
    }
}