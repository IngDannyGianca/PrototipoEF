using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
            CenterToScreen();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            //var form2 = new frmLoginHSC();
            //form2.Closed += (s, args) => this.Hide();
            //form2.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmMarca form = new frmMarca();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void btnAplicacion_Click(object sender, EventArgs e)
        {
            frmLinea form = new frmLinea();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void btnModulos_Click(object sender, EventArgs e)
        {
        }

        private void btnPerfiles_Click(object sender, EventArgs e)
        {
            frmBodega form = new frmBodega();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void btnAsignacionDeAplicacionAUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnAsignacionDeAplicacionesAPerfiles_Click(object sender, EventArgs e)
        {
          

        }

        private void btnCambioContraseña_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
        }

        private void btnAsiginaciónDePerfilesAUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void bitácoraDeLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {

        }

        private void frmMID_Load(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos form3 = new frmProductos();
            form3.MdiParent = this.MdiParent;
            form3.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimiento form3 = new frmMovimiento();
            form3.MdiParent = this.MdiParent;
            form3.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes form3 = new frmClientes();
            form3.MdiParent = this.MdiParent;
            form3.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedores form3 = new frmProveedores();
            form3.MdiParent = this.MdiParent;
            form3.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoMovimiento form3 = new frmTipoMovimiento();
            form3.MdiParent = this.MdiParent;
            form3.Show();
        }
    }
}