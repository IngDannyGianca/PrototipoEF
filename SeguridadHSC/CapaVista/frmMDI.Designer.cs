
namespace CapaVista
{
    partial class frmMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAplicacion = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPerfiles = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAsignacionDeAplicacionAUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCambioContraseña = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBitacora = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.toolStripMenuItem1,
            this.mantenimientosToolStripMenuItem,
            this.asignacionesToolStripMenuItem1,
            this.btnCambioContraseña,
            this.btnBitacora,
            this.ayudasToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1067, 33);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "MenuStrip";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCerrarSesion});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.inicioToolStripMenuItem.Text = "Abrir";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(219, 30);
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 29);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUsuarios,
            this.btnAplicacion,
            this.btnPerfiles,
            this.productosToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.proveedorToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.mantenimientosToolStripMenuItem.Text = "Catálogo";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(242, 30);
            this.btnUsuarios.Text = "Marca";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnAplicacion
            // 
            this.btnAplicacion.Name = "btnAplicacion";
            this.btnAplicacion.Size = new System.Drawing.Size(242, 30);
            this.btnAplicacion.Text = "Linea";
            this.btnAplicacion.Click += new System.EventHandler(this.btnAplicacion_Click);
            // 
            // btnPerfiles
            // 
            this.btnPerfiles.Name = "btnPerfiles";
            this.btnPerfiles.Size = new System.Drawing.Size(242, 30);
            this.btnPerfiles.Text = "Bodegas";
            this.btnPerfiles.Click += new System.EventHandler(this.btnPerfiles_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.proveedorToolStripMenuItem.Text = "Tipo Movimiento";
            this.proveedorToolStripMenuItem.Click += new System.EventHandler(this.proveedorToolStripMenuItem_Click);
            // 
            // asignacionesToolStripMenuItem1
            // 
            this.asignacionesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAsignacionDeAplicacionAUsuarios});
            this.asignacionesToolStripMenuItem1.Name = "asignacionesToolStripMenuItem1";
            this.asignacionesToolStripMenuItem1.Size = new System.Drawing.Size(108, 29);
            this.asignacionesToolStripMenuItem1.Text = "Procesos";
            // 
            // btnAsignacionDeAplicacionAUsuarios
            // 
            this.btnAsignacionDeAplicacionAUsuarios.Name = "btnAsignacionDeAplicacionAUsuarios";
            this.btnAsignacionDeAplicacionAUsuarios.Size = new System.Drawing.Size(415, 30);
            this.btnAsignacionDeAplicacionAUsuarios.Text = "Asignacion de Aplicacion a Usuarios";
            this.btnAsignacionDeAplicacionAUsuarios.Click += new System.EventHandler(this.btnAsignacionDeAplicacionAUsuarios_Click);
            // 
            // btnCambioContraseña
            // 
            this.btnCambioContraseña.Name = "btnCambioContraseña";
            this.btnCambioContraseña.Size = new System.Drawing.Size(101, 29);
            this.btnCambioContraseña.Text = "Informes";
            this.btnCambioContraseña.Click += new System.EventHandler(this.btnCambioContraseña_Click);
            // 
            // btnBitacora
            // 
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(142, 29);
            this.btnBitacora.Text = "Herramientas";
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            // 
            // ayudasToolStripMenuItem
            // 
            this.ayudasToolStripMenuItem.Name = "ayudasToolStripMenuItem";
            this.ayudasToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.ayudasToolStripMenuItem.Text = "Ayudas";
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMDI";
            this.Text = "frmMDI DANNY SALDAÑA 0901-18-18686";
            this.Load += new System.EventHandler(this.frmMID_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnUsuarios;
        private System.Windows.Forms.ToolStripMenuItem btnAplicacion;
        private System.Windows.Forms.ToolStripMenuItem btnPerfiles;
        private System.Windows.Forms.ToolStripMenuItem asignacionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnAsignacionDeAplicacionAUsuarios;
        private System.Windows.Forms.ToolStripMenuItem btnCambioContraseña;
        private System.Windows.Forms.ToolStripMenuItem btnBitacora;
        private System.Windows.Forms.ToolStripMenuItem ayudasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
    }
}