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
    public partial class FrmAreaDespacho : Form
    {
        public FrmAreaDespacho()
        {
            InitializeComponent();
        }

        private async void FrmAreaDespacho_Load(object sender, EventArgs e)
        {
            await this.Listar("%");
        }

        #region "Variables Globales"
        int codigo = 0; // aqui vamos a manejar el codigo del area de despacho que estemos instanciando
        int opcion = 0; // aqui vamos a pasar la opcion de crear nuevo o actualizar existente
        string ImpresoraSeleccionada = "";
        #endregion

        #region "Metodos"
        //Metodo para mostrar un mensaje cuando algo salga bien
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Modulo de Area de Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Metodo para mostrar un mensaje cuando algo salga mal
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Modulo de Area de Despacho", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Metodo para darle formato al DgvListado
        private void Formato()
        {
            if (DgvListado.Columns.Count >= 3)
            {
                DgvListado.Columns[0].Width = 120;
                DgvListado.Columns[0].HeaderText = "CÓDIGO";
                DgvListado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DgvListado.Columns[1].HeaderText = "DESCRIPCIÓN ÁREA DE DESPACHO";
                DgvListado.Columns[2].HeaderText = "IMPRESORA";
                DgvListado.Columns[2].Width = 200;
            }

            // Configuración general
            DgvListado.BorderStyle = BorderStyle.None;
            DgvListado.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvListado.BackgroundColor = Color.FromArgb(245, 247, 250);
            DgvListado.EnableHeadersVisualStyles = false; // OBLIGATORIO para personalizar colores de encabezado
            DgvListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListado.MultiSelect = false;
            DgvListado.AllowUserToAddRows = false;
            DgvListado.AllowUserToResizeRows = false;
            DgvListado.RowHeadersVisible = false;

            // Encabezado UNIFORME (Azul Real / Royal Blue)
            DgvListado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DgvListado.ColumnHeadersHeight = 40;

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.BackColor = Color.FromArgb(0, 120, 212); // Azul corporativo
            headerStyle.ForeColor = Color.White;
            headerStyle.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.Padding = new Padding(10, 0, 0, 0);
            DgvListado.ColumnHeadersDefaultCellStyle = headerStyle;

            // Filas y Selección
            DgvListado.RowTemplate.Height = 35;

            DataGridViewCellStyle rowStyle = new DataGridViewCellStyle();
            rowStyle.BackColor = Color.White;
            rowStyle.ForeColor = Color.FromArgb(51, 65, 85);
            rowStyle.Font = new Font("Century Gothic", 9.5F, FontStyle.Regular);

            // COLOR DE SELECCIÓN
            rowStyle.SelectionBackColor = Color.FromArgb(204, 229, 255); // Azul suave armónico
            rowStyle.SelectionForeColor = Color.FromArgb(0, 51, 102);    // Texto azul marino legible
            rowStyle.Padding = new Padding(10, 0, 0, 0);

            DgvListado.RowsDefaultCellStyle = rowStyle;

            // Filas alternadas
            DataGridViewCellStyle altRowStyle = new DataGridViewCellStyle();
            altRowStyle.BackColor = Color.FromArgb(248, 250, 252);
            altRowStyle.ForeColor = Color.FromArgb(51, 65, 85);
            altRowStyle.SelectionBackColor = Color.FromArgb(204, 229, 255);
            altRowStyle.SelectionForeColor = Color.FromArgb(0, 51, 102);
            altRowStyle.Padding = new Padding(10, 0, 0, 0);

            DgvListado.AlternatingRowsDefaultCellStyle = altRowStyle;

            DgvListado.GridColor = Color.FromArgb(226, 232, 240);
        }

        // Metodo para limpiar el TxtDescripcion y TxtImpresora
        private void LimpiarTexto()
        {
            TxtDescripcion.Clear();
            TxtImpresora.Clear();
        }

        //metodo para activar o desactivar las cajas de texto
        private void EstadoTexto(bool estado)
        {
            TxtDescripcion.ReadOnly = !estado;
            TxtImpresora.ReadOnly = !estado;
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
                TxtImpresora.Text = Convert.ToString(DgvListado.CurrentRow.Cells[2].Value);
                ImpresoraSeleccionada = TxtImpresora.Text;
            }
        }

        //Mostrar listado de Areas de Despacho
        private async Task Listar(string valor)
        {
            try
            {
                //llenamos el DgvListado con el DataTable asincrónico de la capa de negocios
                DgvListado.DataSource = await NAreaDespacho.Listar(valor);
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

        //filtrar las areas de despacho
        private async Task BuscarAsync(string valor)
        {
            await this.Listar(valor);
        }// fin de metodo buscar()

        //insertar una nueva area de despacho
        private async Task InsertarAsync()
        {
            string Respuesta = "";
            try
            {
                //validar que los campos obligatorios esten completos
                if (TxtDescripcion.Text == string.Empty || TxtImpresora.Text == string.Empty)
                {
                    this.MensajeError("Complete los campos obligatorios");
                }
                else
                {
                    if (await NAreaDespacho.Existe(TxtDescripcion.Text.Trim()) == "1")
                    {
                        this.MensajeError("La área de despacho ya existe. Si se ha eliminado previamente, contactar al administrador");
                        return;
                    }
                    Respuesta = await NAreaDespacho.Guardar(opcion, codigo, TxtDescripcion.Text.Trim(), TxtImpresora.Text.Trim());
                    if (Respuesta == "OK")
                    {
                        this.MensajeOk("La área de despacho se insertó correctamente");
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
                //validar que los campos obligatorios esten completados
                if (DgvListado.CurrentCell is not null)
                {
                    if (TxtDescripcion.Text == string.Empty || TxtImpresora.Text == string.Empty)
                    {
                        this.MensajeError("Complete los Campos Obligatorios");
                    }
                    else
                    {
                        if (await NAreaDespacho.Existe(TxtDescripcion.Text.Trim()) == "1" && ImpresoraSeleccionada == TxtImpresora.Text.Trim())
                        {
                            this.MensajeError("El área de despacho ya existe. Si se ha eliminado previamente, contactar con el administrador");
                            return;
                        }

                        Respuesta = await NAreaDespacho.Guardar(opcion, codigo, TxtDescripcion.Text.Trim(), TxtImpresora.Text.Trim());

                        if (Respuesta == "OK")
                        {
                            this.MensajeOk("La área de despacho se actualizó correctamente.");
                            await this.Listar("%"); //Refrescamos el DgvListado
                            this.opcion = 0; //Reseteamos la variable global opcion
                            TabPrincipal.SelectedIndex = 0; //muevete automaticamente a la pestaña de Consulta
                        }
                        else
                        {
                            this.MensajeError(Respuesta);
                        }
                    }
                }
                else
                {
                    this.MensajeError("Debe seleccionar una área de despacho.");
                }
            }
            catch (Exception ex)
            {
                this.MensajeError(ex.Message);
            }
        } //fin del metodo actualizar

        //eliminar un area de despacho (desactivar)
        private async Task Eliminar()
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el Área de Despacho seleccionada?", "Eliminar Área de Despacho", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //ejecutamos el metodo asincrónico
                    string Respuesta = await NAreaDespacho.Eliminar(codigo);
                    if (Respuesta == "OK")
                    {
                        this.MensajeOk("El área de despacho se eliminó correctamente");
                        await this.Listar("%");
                    }
                    else
                    {
                        this.MensajeError(Respuesta);
                    }
                }
                else
                {
                    this.MensajeError("Seleccione un Área de despacho");
                }
            }
            catch (Exception ex)
            {
                this.MensajeError(ex.Message + ex.StackTrace);
            }
        }
        #endregion

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            await this.BuscarAsync(TxtBuscar.Text.Trim());
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

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (DgvListado.CurrentCell is not null)
            {
                SeleccionarItem();
                opcion = 2; // indicamos que vamos a actualizar un registro existente
                this.EstadoBotones(false);
                this.EstadoBotonesProcesos(true);
                this.EstadoTexto(true);
                BtnGuardar.Text = "Actualizar";
                TabPrincipal.SelectedIndex = 1;
            }
            else
            {
                this.MensajeError("Seleccione una Área de despacho");
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
                this.MensajeError("Debe seleccionar un Área de despacho.");
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
                this.MensajeError("Seleccione un Área de despacho");
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
    }
}