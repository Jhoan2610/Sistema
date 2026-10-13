using Sistema.Entidad;
using Sistema.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        #region "Variables Globales"
        int codigo = 0;    // Código del producto seleccionado
        int opcion = 0;    // 1: Nuevo, 2: Actualizar
        DataTable detalle = new DataTable(); // Detalle de los productos
        #endregion

        #region "Metodos"
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Módulo de Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Módulo de Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

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

            // --- 4. FILAS ALTERNADAS (Efecto Cebra) ---
            DataGridViewCellStyle altRowStyle = new DataGridViewCellStyle();
            altRowStyle.BackColor = Color.FromArgb(248, 250, 252);
            altRowStyle.ForeColor = Color.FromArgb(51, 65, 85);
            altRowStyle.SelectionBackColor = Color.FromArgb(204, 229, 255);
            altRowStyle.SelectionForeColor = Color.FromArgb(0, 51, 102);
            altRowStyle.Padding = new Padding(10, 0, 0, 0);
            DgvListado.AlternatingRowsDefaultCellStyle = altRowStyle;

            // --- 5. CONFIGURACIÓN Y MAPEO DE COLUMNAS ---
            if (DgvListado.Columns.Count >= 7)
            {
                DgvListado.Columns[0].Width = 120;
                DgvListado.Columns[0].HeaderText = "Código Producto";

                DgvListado.Columns[1].Width = 250;
                DgvListado.Columns[1].HeaderText = "Producto";

                DgvListado.Columns[2].Width = 180;
                DgvListado.Columns[2].HeaderText = "Marca";

                DgvListado.Columns[3].Width = 180;
                DgvListado.Columns[3].HeaderText = "SubFamilia";

                DgvListado.Columns[4].Width = 140;
                DgvListado.Columns[4].HeaderText = "Precio Unitario";
                DgvListado.Columns[4].DefaultCellStyle.Format = "N2"; // Formato numérico decimal (0.00)

                DgvListado.Columns[5].Width = 180;
                DgvListado.Columns[5].HeaderText = "Area Despacho";

                DgvListado.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DgvListado.Columns[6].HeaderText = "Observación";

                // Ocultar llaves foráneas o IDs internos sobrantes
                for (int i = 7; i < DgvListado.Columns.Count; i++)
                {
                    DgvListado.Columns[i].Visible = false;
                }
            }
        }

        private void LimpiarTexto()
        {
            TxtDescripcion.Clear();
            TxtObservaciones.Clear();
            TxtPrecio.Text = "0.00";
        }

        private void EstadoTexto(bool estado)
        {
            TxtDescripcion.ReadOnly = !estado;
            TxtObservaciones.ReadOnly = !estado;
            TxtPrecio.ReadOnly = !estado;
            CmbMarca.Enabled = estado;
            CmbUnidadesMedida.Enabled = estado;
            CmbSubFamilia.Enabled = estado;
            CmbAreaDespacho.Enabled = estado;
            BtnSeleccionarImagen.Enabled = estado;
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

        private async Task SeleccionarItem()
        {
            if (DgvListado.CurrentRow != null)
            {
                codigo = Convert.ToInt32(DgvListado.CurrentRow.Cells["codigo_pr"].Value);
                TxtDescripcion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["descripcion_pr"].Value);
                if (DgvListado.CurrentRow.Cells["codigo_ma"].Value != DBNull.Value)
                    CmbMarca.SelectedValue = Convert.ToInt32(DgvListado.CurrentRow.Cells["codigo_ma"].Value);
                if (DgvListado.CurrentRow.Cells["codigo_um"].Value != DBNull.Value)
                    CmbUnidadesMedida.SelectedValue = Convert.ToInt32(DgvListado.CurrentRow.Cells["codigo_um"].Value);
                if (DgvListado.CurrentRow.Cells["codigo_sf"].Value != DBNull.Value)
                    CmbSubFamilia.SelectedValue = Convert.ToInt32(DgvListado.CurrentRow.Cells["codigo_sf"].Value);
                if (DgvListado.CurrentRow.Cells["codigo_ad"].Value != DBNull.Value)
                    CmbAreaDespacho.SelectedValue = Convert.ToInt32(DgvListado.CurrentRow.Cells["codigo_ad"].Value);

                TxtPrecio.Text = Convert.ToString(DgvListado.CurrentRow.Cells["precio_unitario"].Value);
                TxtObservaciones.Text = Convert.ToString(DgvListado.CurrentRow.Cells["observacion"].Value);

                await MostrarImagen(codigo);
                await ListarPuntosVenta(opcion, codigo);
            }
        }

        //mostrar imagen de un producto asincrónicamente
        private async Task MostrarImagen(int id)
        {
            try
            {
                byte[] imagen = await NProducto.MostrarImagen(id);
                if (imagen != null && imagen.Length > 0)
                {
                    using (MemoryStream memoryStream = new MemoryStream(imagen))
                    {
                        pictureBoxImagenProducto.Image = Image.FromStream(memoryStream);
                    }
                }
                else
                {
                    await MostrarImagenDefecto();
                }
            }
            catch
            {
                await MostrarImagenDefecto();
            }
        }

        //mostrar imagen por defecto asincrónicamente
        private async Task MostrarImagenDefecto()
        {
            try
            {
                byte[] imagen = await NProducto.MostrarImagenDefecto();
                if (imagen != null && imagen.Length > 0)
                {
                    using (MemoryStream memoryStream = new MemoryStream(imagen))
                    {
                        pictureBoxImagenProducto.Image = Image.FromStream(memoryStream);
                    }
                }
                else
                {
                    pictureBoxImagenProducto.Image = null;
                }
            }
            catch
            {
                pictureBoxImagenProducto.Image = null;
            }
        }

        //metodo para crear estructura de la tabla en memoria
        private void CrearTabla()
        {
            detalle = new DataTable("Detalle");
            detalle.Columns.Add("descripcion_pv", Type.GetType("System.String"));
            detalle.Columns.Add("ok", Type.GetType("System.Boolean"));
            detalle.Columns.Add("codigo_pv", Type.GetType("System.Int32"));
            dgvPuntosVenta.DataSource = detalle;

            //formato a este DataGridView
            dgvPuntosVenta.Columns[0].Width = 210;
            dgvPuntosVenta.Columns[0].HeaderText = "PUNTO DE VENTA";
            dgvPuntosVenta.Columns[1].Width = 125;
            dgvPuntosVenta.Columns[1].HeaderText = "DISPONIBLE";
            dgvPuntosVenta.Columns[1].ReadOnly = true;
            dgvPuntosVenta.Columns[2].Visible = false;
        }

        //Metodo para llenar una fila en la tabla en memoria para los puntos de venta
        private void AgregarPuntoVenta(string descripcion, bool ok, int codigo)
        {
            DataRow fila = detalle.NewRow();
            fila["descripcion_pv"] = descripcion;
            fila["ok"] = ok;
            fila["codigo_pv"] = codigo;
            detalle.Rows.Add(fila);
        }

        //Metodo para llenar el DataGridView con la tabla en memoria para los puntos de venta asincrónicamente
        private async Task ListarPuntosVenta(int opcion, int codigo)
        {
            try
            {
                DataTable tabla = await NProducto.ListarPuntosVenta(opcion, codigo);
                detalle.Clear();

                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    AgregarPuntoVenta(Convert.ToString(tabla.Rows[i][0]), Convert.ToBoolean(tabla.Rows[i][1]), Convert.ToInt32(tabla.Rows[i][2]));
                }
                dgvPuntosVenta.DataSource = detalle;

                if (opcion >= 1)
                {
                    dgvPuntosVenta.Columns["ok"].ReadOnly = false;
                }
                else
                {
                    dgvPuntosVenta.Columns["ok"].ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                this.MensajeError(ex.Message);
            }
        }

        //cargar comboboxes asincrónicamente
        private async Task CargarComboBox()
        {
            try
            {
                CmbMarca.DataSource = await NMarca.Listar("%");
                CmbMarca.DisplayMember = "descripcion_ma";
                CmbMarca.ValueMember = "codigo_ma";

                CmbUnidadesMedida.DataSource = await NUnidadesMedida.Listar("%");
                CmbUnidadesMedida.DisplayMember = "descripcion_um";
                CmbUnidadesMedida.ValueMember = "codigo_um";

                CmbSubFamilia.DataSource = await NSubFamilia.Listar("%");
                CmbSubFamilia.DisplayMember = "descripcion_sf";
                CmbSubFamilia.ValueMember = "codigo_sf";

                CmbAreaDespacho.DataSource = await NAreaDespacho.Listar("%");
                CmbAreaDespacho.DisplayMember = "descripcion_ad";
                CmbAreaDespacho.ValueMember = "codigo_ad";
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
                DgvListado.DataSource = await NProducto.Listar(valor);
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

        private async Task Buscar(string valor)
        {
            await this.Listar(valor);
        }

        private async Task Insertar()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtDescripcion.Text) || CmbSubFamilia.SelectedValue == null || CmbMarca.SelectedValue == null || CmbAreaDespacho.SelectedValue == null || CmbUnidadesMedida.SelectedValue == null || string.IsNullOrWhiteSpace(TxtPrecio.Text))
                {
                    this.MensajeError("Complete los campos obligatorios");
                    return;
                }

                if (await NProducto.Existe(TxtDescripcion.Text.Trim()) == "1")
                {
                    this.MensajeError("El producto ya existe.");
                    return;
                }
                Producto producto = new Producto();
                producto.Codigo = codigo;
                producto.Descripcion = TxtDescripcion.Text.Trim();
                producto.CodigoMarca = Convert.ToInt32(CmbMarca.SelectedValue);
                producto.CodigoSubFamilia = Convert.ToInt32(CmbSubFamilia.SelectedValue);
                producto.PrecioUnitario = Convert.ToDecimal(TxtPrecio.Text.Trim());
                producto.CodigoAreaDespacho = Convert.ToInt32(CmbAreaDespacho.SelectedValue);
                producto.CodigoUnidadMedida = Convert.ToInt32(CmbUnidadesMedida.SelectedValue);
                producto.Observacion = TxtObservaciones.Text.Trim();

                //imagen
                if (pictureBoxImagenProducto.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBoxImagenProducto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        producto.Imagen = ms.ToArray();
                    }
                }

                string respuesta = await NProducto.Guardar(opcion, producto, detalle);
                if (respuesta == "OK")
                {
                    this.MensajeOk("El producto se insertó correctamente");
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

        private async Task Actualizar()
        {
            string Respuesta = "";

            try
            {
                //validar que los campos obligatorios esten completados
                if (string.IsNullOrWhiteSpace(TxtDescripcion.Text) || CmbSubFamilia.SelectedValue == null || CmbMarca.SelectedValue == null || CmbAreaDespacho.SelectedValue == null || CmbUnidadesMedida.SelectedValue == null || string.IsNullOrWhiteSpace(TxtPrecio.Text))
                {
                    this.MensajeError("Complete los campos obligatorios");
                }
                else
                {
                    Producto producto = new Producto();
                    producto.Codigo = codigo;
                    producto.Descripcion = TxtDescripcion.Text.Trim();
                    producto.CodigoMarca = Convert.ToInt32(CmbMarca.SelectedValue);
                    producto.CodigoUnidadMedida = Convert.ToInt32(CmbUnidadesMedida.SelectedValue);
                    producto.CodigoSubFamilia = Convert.ToInt32(CmbSubFamilia.SelectedValue);
                    producto.CodigoAreaDespacho = Convert.ToInt32(CmbAreaDespacho.SelectedValue);
                    producto.PrecioUnitario = Convert.ToDecimal(TxtPrecio.Text.Trim());
                    producto.Observacion = TxtObservaciones.Text.Trim();

                    //imagen del producto
                    if (pictureBoxImagenProducto.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pictureBoxImagenProducto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            producto.Imagen = ms.ToArray();
                        }
                    }

                    Respuesta = await NProducto.Guardar(opcion, producto, detalle);
                    if (Respuesta == "OK")
                    {
                        this.MensajeOk("El Producto se actualizó correctamente");
                        await this.Listar("%"); //refrescamos Dgv Listado
                        this.opcion = 0; //reseteamos la variable
                        TabPrincipal.SelectedIndex = 0; //regresamos a la pestaña de consulta
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

        private async Task Eliminar()
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el Producto seleccionado?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //ejecutamos el metodo
                    string Respuesta = await NProducto.Eliminar(codigo);
                    if (Respuesta == "OK")
                    {
                        this.MensajeOk("El Producto fue eliminado correctamente");
                        await this.Listar("%");
                    }
                    else
                    {
                        this.MensajeError(Respuesta);
                    }
                }
                else
                {
                    this.MensajeError("Debe seleccionar un Producto");
                }
            }
            catch (Exception ex)
            {
                this.MensajeError(ex.Message + ex.StackTrace);
            }
        }
        #endregion

        private async void FrmProducto_Load(object sender, EventArgs e)
        {
            await this.Listar("%");
            await this.CargarComboBox();
            this.CrearTabla();
            dgvPuntosVenta.ReadOnly = false;
        }

        private async void BtnNuevo_Click(object sender, EventArgs e)
        {
            opcion = 1; //nuevo registro
            this.LimpiarTexto();
            this.EstadoBotones(false);
            this.EstadoBotonesProcesos(true);
            this.EstadoTexto(true);
            await ListarPuntosVenta(opcion, codigo);
            await MostrarImagenDefecto();
            TabPrincipal.SelectedIndex = 1; //mueve automaticamente a la pestaña de mantenimiento
            TxtDescripcion.Focus(); //coloca el cursor dentro del txtdescripcion
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (opcion == 1)
            {
                await this.Insertar();
            }
            else if (opcion == 2)
            {
                await this.Actualizar();
            }
        }

        private async void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (DgvListado.CurrentCell is not null)
            {
                opcion = 2;
                await SeleccionarItem();

                this.EstadoBotones(false);
                this.EstadoBotonesProcesos(true);
                this.EstadoTexto(true);
                BtnGuardar.Text = "Actualizar";
                TabPrincipal.SelectedIndex = 1;
            }
            else
            {
                this.MensajeError("Debe seleccionar un Producto");
            }
        }

        private void BtnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            foto.Filter = "Image files(*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (foto.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImagenProducto.Image = Image.FromFile(foto.FileName);
            }
        }

        private async void DgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListado.CurrentCell is not null)
            {
                await SeleccionarItem();
            }
            else
            {
                this.MensajeError("Debe seleccionar un Producto");
            }
        }

        private async void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListado.CurrentCell is not null)
            {
                opcion = 2;
                await SeleccionarItem();

                this.EstadoBotones(false);
                this.EstadoBotonesProcesos(true);
                this.EstadoTexto(true);
                BtnGuardar.Text = "Actualizar";
                TabPrincipal.SelectedIndex = 1;
            }
            else
            {
                this.MensajeError("Debe seleccionar un Producto");
            }
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvListado.CurrentCell is not null)
            {
                await SeleccionarItem();
                await this.Eliminar();
            }
            else
            {
                this.MensajeError("Debe seleccionar un Producto");
            }
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            await this.Buscar(TxtBuscar.Text.Trim());
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void dgvPuntosVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}