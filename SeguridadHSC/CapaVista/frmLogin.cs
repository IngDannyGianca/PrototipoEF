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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMDI form3 = new frmMDI();
            form3.MdiParent = this.MdiParent;
            form3.Show();

            string message = "Bienvenido, ADMIN";
            string title = "Bienvenido";
            MessageBox.Show(message, title);

            frmLogin form4 = new frmLogin();
            form4.MdiParent = this.MdiParent;
            form4.Close();


        }
    }
}
