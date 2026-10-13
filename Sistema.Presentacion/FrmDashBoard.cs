using Sistema.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmDashBoard : Form
    {
        public FrmDashBoard()
        {
            InitializeComponent();
            //llamamos al customizardiseño()
            CustomizarDiseño();
        }
        #region "Variables"
        private Form formularioActivo;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal Usuario Usuario { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal string DescripcionCargo { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal string DescripcionRol { get; set; }

        #endregion
        #region "Metodos"
        //Metodo para ocultar los paneles
        private void CustomizarDiseño()
        {
            panelProcesos.Visible = false;
            panelReportes.Visible = false;
            panelDatosMaestros.Visible = false;
        }
        //metodo para ocultar los submenus
        private void OcultarSubMenu()
        {
            if (panelProcesos.Visible == true)
            {
                panelProcesos.Visible = false;
            }

            if (panelReportes.Visible == true)
            {
                panelReportes.Visible = false;
            }

            if (panelDatosMaestros.Visible == true)
            {
                panelDatosMaestros.Visible = false;
            }
        }
        //metodo para mostrar los submenus
        private void MostrarSubMenu(Panel panel)
        {
            if (panel.Visible == false)
            {
                OcultarSubMenu();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }
        //metodo para cargar un formulario
        private void AbrirFormulario(Form form)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(form);
            panelPrincipal.Tag = form;
            form.StartPosition = FormStartPosition.CenterParent;
            form.BringToFront();
            form.Show();
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: " + DateTime.Now.ToLongTimeString();
            lblFecha.Text = "Fecha: " + DateTime.Now.ToLongDateString();
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            lblModuloActual.Text = btnProcesos.Text;
            MostrarSubMenu(panelProcesos);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            lblModuloActual.Text = btnReportes.Text;
            MostrarSubMenu(panelReportes);
        }

        private void btnDatosMaestros_Click(object sender, EventArgs e)
        {
            lblModuloActual.Text = btnDatosMaestros.Text;
            MostrarSubMenu(panelDatosMaestros);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmProducto());
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmMarca());
        }

        private void btnUnidadesMedida_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmUnidadesMedida());
        }

        private void btnSubFamilia_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmSubFamilia());
        }

        private void btnFamilias_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmFamilia());
        }

        private void btnPuntosVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPuntoVenta());
        }

        private void btnAreaDespacho_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAreaDespacho());
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmMesas());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            lblModuloActual.Text = btnDashboard.Text;
            CustomizarDiseño();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea salir del sistema", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnRegistrarPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Procesos.FrmRegistroPedidos(Usuario));
        }

        private void btnCierreTurnos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Procesos.FrmCierreTurnos());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCliente());
        }

        private void btnCliente_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCliente());
        }

        private void FrmDashBoard_Load(object sender, EventArgs e)
        {
            //establecer que puede ver o accesar el usuario
            if(Usuario.CodigoRol == 1)
            {
                //este es el admin
                panelDatosMaestros.Enabled = true;
                panelProcesos.Enabled = true;
            }
            else
            {
                //este es el usuario comun
                panelDatosMaestros.Enabled = false;
                panelProcesos.Enabled = true;
            }
        }
    }
}
