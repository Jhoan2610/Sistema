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

namespace Sistema.Presentacion.Procesos
{
    public partial class FrmMesaAbierta : Form
    {
        public FrmMesaAbierta()
        {
            InitializeComponent();
        }

        // crear tabla temporal para llenar los productos ordenados 
        DataTable tablaDetalle = new DataTable();

        // atributos para almacenar la info de cada producto
        private int codigo_pr;
        private string descripcion_pr;
        private string precioUnitario_pr;
        private string impresora_pr;
        private Image imagen_pr;
        private string archivotxt;
        private int codigo_pv_pr;
        private int codigo_sf_pr;
        private int codigoCliente;

        //información de la mesa y turno
        private int codigoMesa;
        private int codigoTurno;
        private string fechaTrabajo;
        private int codigoUsuario;



        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Codigo_pr { get => codigo_pr; set => codigo_pr = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Descripcion_pr { get => descripcion_pr; set => descripcion_pr = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string PrecioUnitario_pr { get => precioUnitario_pr; set => precioUnitario_pr = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Impresora_pr { get => impresora_pr; set => impresora_pr = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image Imagen_pr { get => imagen_pr; set => imagen_pr = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Archivotxt { get => archivotxt; set => archivotxt = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Codigo_pv_pr { get => codigo_pv_pr; set => codigo_pv_pr = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Codigo_sf_pr { get => codigo_sf_pr; set => codigo_sf_pr = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CodigoMesa { get => codigoMesa; set => codigoMesa = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CodigoTurno { get => codigoTurno; set => codigoTurno = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FechaTrabajo { get => fechaTrabajo; set => fechaTrabajo = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]


        #region "Variables para generar la impresion de un pedido"
        private int codigoTicket;
        private string Impresora;
        private string descripcionPv;
        private string fechaEmision;
        private string descripcionTurno;
        private string nombreUsuario;
        private string descripcionCargo;
        private string descripcionMesa;
        private string cliente;
        private string numeroDocumentoCliente;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CodigoUsuario { get => codigoUsuario; set => codigoUsuario = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CodigoTicket { get => codigoTicket; set => codigoTicket = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Impresora1 { get => Impresora; set => Impresora = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string DescripcionPv { get => descripcionPv; set => descripcionPv = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FechaEmision { get => fechaEmision; set => fechaEmision = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string DescripcionTurno { get => descripcionTurno; set => descripcionTurno = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string DescripcionCargo { get => descripcionCargo; set => descripcionCargo = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string DescripcionMesa { get => descripcionMesa; set => descripcionMesa = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Cliente { get => cliente; set => cliente = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NumeroDocumentoCliente { get => numeroDocumentoCliente; set => numeroDocumentoCliente = value; }


        #endregion

        #region "Mis metodos"

        private async Task LlenarListadoProductosAsync(FlowLayoutPanel contenedor)
        {
            try
            {
                contenedor.Controls.Clear();
                if (DgvListadoProductos.CurrentRow == null || DgvListadoProductos.CurrentRow.Cells["codigo_sf"].Value == DBNull.Value)
                {
                    return;
                }

                codigo_sf_pr = Convert.ToInt32(DgvListadoProductos.CurrentRow.Cells["codigo_sf"].Value);

                DataTable tabla = await NMesaAbierta.ListarProductosSubfamiliaAsync(codigo_pv_pr, codigo_sf_pr);

                if (tabla != null && tabla.Rows.Count > 0)
                {
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        Codigo_pr = Convert.ToInt32(tabla.Rows[i][0]);
                        Descripcion_pr = Convert.ToString(tabla.Rows[i][1]);
                        PrecioUnitario_pr = Convert.ToString(tabla.Rows[i][2]);

                        if (tabla.Rows[i][3] != DBNull.Value)
                        {
                            byte[] imagen = (byte[])tabla.Rows[i][3];
                            using (MemoryStream ms = new MemoryStream(imagen))
                            {
                                Imagen_pr = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            Imagen_pr = null;
                        }

                        Impresora_pr = Convert.ToString(tabla.Rows[i][4]);

                        // crear componente de MiProducto
                        Controles.MiProducto producto = new Controles.MiProducto();
                        producto.CodigoProducto = Codigo_pr;
                        producto.DescripcionProducto = Descripcion_pr;
                        producto.PrecioUnitarioProducto = PrecioUnitario_pr;
                        producto.ImagenProducto = Imagen_pr;
                        producto.Impresora = Impresora_pr;
                        producto.ArchivoTxt = Archivotxt;

                        // añadirlo al contenedor
                        contenedor.Controls.Add(producto);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // metodo para crear estructuras del DgvDetalle de productos
        private void CrearTablaDetalle()
        {
            tablaDetalle = new DataTable("tablaDetalle");
            tablaDetalle.Columns.Add("descripcion_pr", Type.GetType("System.String"));
            tablaDetalle.Columns.Add("precio_pr", Type.GetType("System.String"));
            tablaDetalle.Columns.Add("cantidad_pr", Type.GetType("System.String"));
            tablaDetalle.Columns.Add("total_pr", Type.GetType("System.String"));
            tablaDetalle.Columns.Add("observacion_pr", Type.GetType("System.String"));
            tablaDetalle.Columns.Add("codigo_pr", Type.GetType("System.Int32"));
            tablaDetalle.Columns.Add("impresora_pr", Type.GetType("System.String"));

            // añadimos la estructura al DgvDetalle
            DgvDetalles.DataSource = tablaDetalle;

            // darle formato
            if (DgvDetalles.Columns.Count >= 7)
            {
                DgvDetalles.Columns[0].Width = 150;
                DgvDetalles.Columns[0].HeaderText = "Producto";
                DgvDetalles.Columns[1].Width = 100;
                DgvDetalles.Columns[1].HeaderText = "Precio";
                DgvDetalles.Columns[2].Width = 100;
                DgvDetalles.Columns[2].HeaderText = "Cantidad";
                DgvDetalles.Columns[3].Width = 100;
                DgvDetalles.Columns[3].HeaderText = "Total";
                DgvDetalles.Columns[4].Width = 160;
                DgvDetalles.Columns[4].HeaderText = "Observaciones";
                DgvDetalles.Columns[5].Visible = false;
                DgvDetalles.Columns[6].Visible = false;
            }
        }

        // metodo para agregar un producto al dgvdetalle cuando el usuario lo seleccione
        private void AgregarItem(string descripcionProducto, string precioProducto, string cantidad, string total, string observaciones, int codigoProducto, string impresora)
        {
            DataRow fila = tablaDetalle.NewRow();
            fila["descripcion_pr"] = descripcionProducto;
            fila["precio_pr"] = precioProducto;
            fila["cantidad_pr"] = cantidad;
            fila["total_pr"] = total;
            fila["observacion_pr"] = observaciones;
            fila["codigo_pr"] = codigoProducto;
            fila["impresora_pr"] = impresora;

            tablaDetalle.Rows.Add(fila);
        }

        // metodo para capturar la tecla del boton presionado y añadirlo al label cantidad
        private void Botones(object sender)
        {
            if (sender is Button btn)
            {
                lblCantidad.Text += btn.Text;
            }
        }

        // actualizar el total 
        private void ActualizarSuma()
        {
            const int columna = 3;
            decimal suma = 0;
            foreach (DataGridViewRow row in DgvDetalles.Rows)
            {
                if (row.Cells[columna].Value != null && row.Cells[columna].Value != DBNull.Value)
                {
                    suma += Convert.ToDecimal(row.Cells[columna].Value);
                }
            }
            lblTotal.Text = suma.ToString("F2");
        }

        // busqueda rapida de productos
        private async Task BusquedaRapidaProductosAsync(string valor)
        {
            try
            {
                DgvBusquedaProducto.DataSource = await NMesaAbierta.BusquedaRapidaProductosAsync(valor);

                if (DgvBusquedaProducto.Columns.Count >= 5)
                {
                    DgvBusquedaProducto.Columns[0].Width = 180;
                    DgvBusquedaProducto.Columns[0].HeaderText = "Producto";
                    DgvBusquedaProducto.Columns[1].Width = 110;
                    DgvBusquedaProducto.Columns[1].HeaderText = "P Unitario";
                    DgvBusquedaProducto.Columns[2].Width = 160;
                    DgvBusquedaProducto.Columns[2].HeaderText = "Subfamlia";
                    DgvBusquedaProducto.Columns[3].Visible = false;
                    DgvBusquedaProducto.Columns[4].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // busqueda de clientes

        private async Task BusquedaRapidaCliente(string valor)
        {
            try
            {
                DgvListarClientes.DataSource = await NMesaAbierta.BusquedaRapidaCliente(valor);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //Metodo para añadir un cliente de la busqueda rapida
        private async Task SeleccionarClientesBusquedaRapida()
        {
            txtNombreCliente.Text = DgvListarClientes.CurrentRow.Cells["nombre"].Value.ToString();
            codigoCliente = Convert.ToInt32(DgvListarClientes.CurrentRow.Cells["codigo_cl"].Value);
            txtDocumentoCliente.Text = DgvListarClientes.CurrentRow.Cells["num_documento_cl"].Value.ToString();
        }

        // metodo para la busqueda rapida de productos
        private void SeleccionarProductoBusquedaRapida()
        {
            if (DgvBusquedaProducto.CurrentRow == null) return;

            string descripcionProducto = Convert.ToString(DgvBusquedaProducto.CurrentRow.Cells["descripcion_pr"].Value);
            string precioProducto = Convert.ToString(DgvBusquedaProducto.CurrentRow.Cells["precio_unitario"].Value);
            int codigoProducto = Convert.ToInt32(DgvBusquedaProducto.CurrentRow.Cells["codigo_pr"].Value);
            string impresora = Convert.ToString(DgvBusquedaProducto.CurrentRow.Cells["impresora"].Value);

            AgregarItem(descripcionProducto, precioProducto, "1", precioProducto, "", codigoProducto, impresora);
            tablaDetalle.AcceptChanges();

            ActualizarSuma();
        }

        #endregion

        private void txtDocumentoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private async void DgvListadoProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // cargar los productos para esa subfamilia que esten disponibles en el punto de venta
                await this.LlenarListadoProductosAsync(FlowLayoutPanelListadoProductos);
            }
        }

        private void FrmMesaAbierta_Load(object sender, EventArgs e)
        {
            if (tabPrincipal.TabPages.Count > 0)
            {
                tabPrincipal.TabPages[0].Enabled = false;
            }
            // crear una tabla de detalle para agregar los productos seleccionados
            this.CrearTablaDetalle();
        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            if (tabPrincipal.TabPages.Count > 0)
            {
                tabPrincipal.TabPages[0].Enabled = true;
                tabPrincipal.SelectedIndex = 0; // mostrar vista nuevo pedido
            }
            // habilita un proceso para cargar los productos
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // leer todos los archivos de productos y agregarlos al dgvdetalle
            string rutaArchivo = @"C:\test\" + Archivotxt + ".txt";
            if (File.Exists(rutaArchivo))
            {
                string descripcionProducto;
                string precioProducto;
                string codigoProducto;
                string impresora;

                using (StreamReader leer = new StreamReader(rutaArchivo))
                {
                    descripcionProducto = leer.ReadLine();
                    precioProducto = leer.ReadLine();
                    codigoProducto = leer.ReadLine();
                    impresora = leer.ReadLine();
                }

                try
                {
                    File.Delete(rutaArchivo);
                }
                catch
                {
                    // Si el archivo está bloqueado momentáneamente por el SO, se intentará borrar en el próximo Tick
                }

                if (!string.IsNullOrEmpty(descripcionProducto) &&
                    !string.IsNullOrEmpty(precioProducto) &&
                    !string.IsNullOrEmpty(codigoProducto) &&
                    !string.IsNullOrEmpty(impresora))
                {
                    this.AgregarItem(
                        descripcionProducto.Substring(16),
                        precioProducto.Substring(11),
                        "1",
                        precioProducto.Substring(11),
                        "",
                        Convert.ToInt32(codigoProducto.Substring(11)),
                        impresora.Substring(11)
                    );

                    tablaDetalle.AcceptChanges();
                    ActualizarSuma();
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // actualice la cantidad de un producto
            Botones(sender);
        }

        private void btnActualizarPedido_Click(object sender, EventArgs e)
        {
            if (DgvDetalles.SelectedRows.Count > 0 && lblCantidad.Text.Length > 0)
            {
                DataGridViewRow fila = DgvDetalles.CurrentRow;
                if (fila is null)
                {
                    return;
                }

                fila.Cells["cantidad_pr"].Value = " " + lblCantidad.Text + ".00";
                fila.Cells["total_pr"].Value = (Convert.ToDecimal(fila.Cells["precio_pr"].Value) * Convert.ToDecimal(lblCantidad.Text)).ToString("F2");

                tablaDetalle.AcceptChanges();
                ActualizarSuma();
                lblCantidad.Text = "";
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (DgvDetalles.SelectedRows.Count > 0 && DgvDetalles.CurrentRow != null)
            {
                DgvDetalles.Rows.Remove(DgvDetalles.CurrentRow);
                tablaDetalle.AcceptChanges();
                ActualizarSuma();
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            PnlBusquedaProductos.Visible = true;
        }

        private async void BtnBusquedaProducto_Click(object sender, EventArgs e)
        {
            await BusquedaRapidaProductosAsync(txtBuscarProductos.Text.Trim());
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            PnlBusquedaProductos.Visible = false;
            DgvBusquedaProducto.DataSource = null;
        }

        private void DgvBusquedaProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SeleccionarProductoBusquedaRapida();
            }
        }

        private void DgvDetalles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DgvDetalles.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = DgvDetalles.CurrentRow;
                if (fila is null)
                {
                    return;
                }
                txtObservacion.Text = Convert.ToString(fila.Cells["observacion_pr"].Value);
                DgvDetalles.Enabled = false;
                PnlObservacion.Visible = true;
                txtObservacion.Focus();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (DgvDetalles.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = DgvDetalles.CurrentRow;
                if (fila is null)
                {
                    return;
                }
                fila.Cells["observacion_pr"].Value = txtObservacion.Text.Trim();
                tablaDetalle.AcceptChanges();
                DgvDetalles.Enabled = true;
                PnlObservacion.Visible = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pnlBuscarCliente.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BusquedaRapidaCliente(TxtBuscarClientes.Text.Trim());
        }

        private void DgvListarClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarClientesBusquedaRapida();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlBuscarCliente.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}