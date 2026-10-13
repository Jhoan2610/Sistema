namespace Sistema.Presentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            procesosToolStripMenuItem = new ToolStripMenuItem();
            proceso1ToolStripMenuItem = new ToolStripMenuItem();
            proceso2ToolStripMenuItem = new ToolStripMenuItem();
            proceso3ToolStripMenuItem = new ToolStripMenuItem();
            datosMaestrosToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            marcasToolStripMenuItem = new ToolStripMenuItem();
            unidadesDeMedidaToolStripMenuItem = new ToolStripMenuItem();
            familiasToolStripMenuItem = new ToolStripMenuItem();
            subFamiliasToolStripMenuItem = new ToolStripMenuItem();
            puntosDeVentaToolStripMenuItem = new ToolStripMenuItem();
            areaDeDespachoToolStripMenuItem = new ToolStripMenuItem();
            mesasToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            windowsMenu = new ToolStripMenuItem();
            newWindowToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tileVerticalToolStripMenuItem = new ToolStripMenuItem();
            tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
            closeAllToolStripMenuItem = new ToolStripMenuItem();
            arrangeIconsToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            salirDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            toolStripStatusLabel = new ToolStripStatusLabel();
            statusStrip = new StatusStrip();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Font = new Font("Century Gothic", 12F);
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { procesosToolStripMenuItem, datosMaestrosToolStripMenuItem, reportesToolStripMenuItem, windowsMenu, salirToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.MdiWindowListItem = windowsMenu;
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(8, 3, 0, 3);
            menuStrip.Size = new Size(1005, 33);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // procesosToolStripMenuItem
            // 
            procesosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { proceso1ToolStripMenuItem, proceso2ToolStripMenuItem, proceso3ToolStripMenuItem });
            procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            procesosToolStripMenuItem.Size = new Size(110, 27);
            procesosToolStripMenuItem.Text = "Procesos";
            // 
            // proceso1ToolStripMenuItem
            // 
            proceso1ToolStripMenuItem.Name = "proceso1ToolStripMenuItem";
            proceso1ToolStripMenuItem.Size = new Size(189, 28);
            proceso1ToolStripMenuItem.Text = "Proceso 1";
            // 
            // proceso2ToolStripMenuItem
            // 
            proceso2ToolStripMenuItem.Name = "proceso2ToolStripMenuItem";
            proceso2ToolStripMenuItem.Size = new Size(189, 28);
            proceso2ToolStripMenuItem.Text = "Proceso 2";
            // 
            // proceso3ToolStripMenuItem
            // 
            proceso3ToolStripMenuItem.Name = "proceso3ToolStripMenuItem";
            proceso3ToolStripMenuItem.Size = new Size(189, 28);
            proceso3ToolStripMenuItem.Text = "Proceso 3";
            // 
            // datosMaestrosToolStripMenuItem
            // 
            datosMaestrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productosToolStripMenuItem, marcasToolStripMenuItem, unidadesDeMedidaToolStripMenuItem, familiasToolStripMenuItem, subFamiliasToolStripMenuItem, puntosDeVentaToolStripMenuItem, areaDeDespachoToolStripMenuItem, mesasToolStripMenuItem });
            datosMaestrosToolStripMenuItem.Name = "datosMaestrosToolStripMenuItem";
            datosMaestrosToolStripMenuItem.Size = new Size(173, 27);
            datosMaestrosToolStripMenuItem.Text = "Datos Maestros";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(301, 28);
            productosToolStripMenuItem.Text = "Productos";
            // 
            // marcasToolStripMenuItem
            // 
            marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            marcasToolStripMenuItem.Size = new Size(301, 28);
            marcasToolStripMenuItem.Text = "Marcas";
            // 
            // unidadesDeMedidaToolStripMenuItem
            // 
            unidadesDeMedidaToolStripMenuItem.Name = "unidadesDeMedidaToolStripMenuItem";
            unidadesDeMedidaToolStripMenuItem.Size = new Size(301, 28);
            unidadesDeMedidaToolStripMenuItem.Text = "Unidades de medida";
            // 
            // familiasToolStripMenuItem
            // 
            familiasToolStripMenuItem.Name = "familiasToolStripMenuItem";
            familiasToolStripMenuItem.Size = new Size(301, 28);
            familiasToolStripMenuItem.Text = "Familias";
            // 
            // subFamiliasToolStripMenuItem
            // 
            subFamiliasToolStripMenuItem.Name = "subFamiliasToolStripMenuItem";
            subFamiliasToolStripMenuItem.Size = new Size(301, 28);
            subFamiliasToolStripMenuItem.Text = "SubFamilias";
            // 
            // puntosDeVentaToolStripMenuItem
            // 
            puntosDeVentaToolStripMenuItem.Name = "puntosDeVentaToolStripMenuItem";
            puntosDeVentaToolStripMenuItem.Size = new Size(301, 28);
            puntosDeVentaToolStripMenuItem.Text = "Puntos de Venta";
            puntosDeVentaToolStripMenuItem.Click += puntosDeVentaToolStripMenuItem_Click;
            // 
            // areaDeDespachoToolStripMenuItem
            // 
            areaDeDespachoToolStripMenuItem.Name = "areaDeDespachoToolStripMenuItem";
            areaDeDespachoToolStripMenuItem.Size = new Size(301, 28);
            areaDeDespachoToolStripMenuItem.Text = "Areas de Despacho";
            // 
            // mesasToolStripMenuItem
            // 
            mesasToolStripMenuItem.Name = "mesasToolStripMenuItem";
            mesasToolStripMenuItem.Size = new Size(301, 28);
            mesasToolStripMenuItem.Text = "Mesas";
            mesasToolStripMenuItem.Click += mesasToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(110, 27);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // windowsMenu
            // 
            windowsMenu.DropDownItems.AddRange(new ToolStripItem[] { newWindowToolStripMenuItem, cascadeToolStripMenuItem, tileVerticalToolStripMenuItem, tileHorizontalToolStripMenuItem, closeAllToolStripMenuItem, arrangeIconsToolStripMenuItem });
            windowsMenu.Name = "windowsMenu";
            windowsMenu.Size = new Size(109, 27);
            windowsMenu.Text = "&Windows";
            // 
            // newWindowToolStripMenuItem
            // 
            newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            newWindowToolStripMenuItem.Size = new Size(230, 28);
            newWindowToolStripMenuItem.Text = "&New Window";
            newWindowToolStripMenuItem.Click += ShowNewForm;
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(230, 28);
            cascadeToolStripMenuItem.Text = "&Cascade";
            cascadeToolStripMenuItem.Click += CascadeToolStripMenuItem_Click;
            // 
            // tileVerticalToolStripMenuItem
            // 
            tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            tileVerticalToolStripMenuItem.Size = new Size(230, 28);
            tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            tileVerticalToolStripMenuItem.Click += TileVerticalToolStripMenuItem_Click;
            // 
            // tileHorizontalToolStripMenuItem
            // 
            tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            tileHorizontalToolStripMenuItem.Size = new Size(230, 28);
            tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            tileHorizontalToolStripMenuItem.Click += TileHorizontalToolStripMenuItem_Click;
            // 
            // closeAllToolStripMenuItem
            // 
            closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            closeAllToolStripMenuItem.Size = new Size(230, 28);
            closeAllToolStripMenuItem.Text = "C&lose All";
            closeAllToolStripMenuItem.Click += CloseAllToolStripMenuItem_Click;
            // 
            // arrangeIconsToolStripMenuItem
            // 
            arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            arrangeIconsToolStripMenuItem.Size = new Size(230, 28);
            arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            arrangeIconsToolStripMenuItem.Click += ArrangeIconsToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesiónToolStripMenuItem, salirDelSistemaToolStripMenuItem });
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(62, 27);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(248, 28);
            cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new Size(248, 28);
            salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(49, 20);
            toolStripStatusLabel.Text = "Status";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 599);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 19, 0);
            statusStrip.Size = new Size(1005, 26);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 625);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmPrincipal";
            Text = "Sistema de Puntos de Venta";
            WindowState = FormWindowState.Maximized;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private ToolStripMenuItem procesosToolStripMenuItem;
        private ToolStripMenuItem proceso1ToolStripMenuItem;
        private ToolStripMenuItem proceso2ToolStripMenuItem;
        private ToolStripMenuItem proceso3ToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem datosMaestrosToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem marcasToolStripMenuItem;
        private ToolStripMenuItem unidadesDeMedidaToolStripMenuItem;
        private ToolStripMenuItem familiasToolStripMenuItem;
        private ToolStripMenuItem subFamiliasToolStripMenuItem;
        private ToolStripMenuItem puntosDeVentaToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel;
        private StatusStrip statusStrip;
        private ToolStripMenuItem areaDeDespachoToolStripMenuItem;
        private ToolStripMenuItem mesasToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private ToolStripMenuItem salirDelSistemaToolStripMenuItem;
    }
}



