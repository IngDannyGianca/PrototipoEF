using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class frmBodega : Form
    {
        Controlador cn = new Controlador();
        public frmBodega()
        {
            InitializeComponent();
            CenterToScreen();
            MostarBodega();
        }

        public void MostarBodega()
        {
            DataTable dt = cn.MostarBodega();
            dataGridView1.DataSource = dt;
        }

        public void Limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";

            radioButton1.Checked = true;
            radioButton2.Checked = false;

            dataGridView1.DataSource = "";
            MostarBodega();
        }

        private void frmBodega_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor1;
            string valor2;
            string valor3 = "1";

            valor1 = textBox1.Text;
            valor2 = textBox2.Text;
            if (radioButton1.Checked == true)
            {
                valor3 = "1";
            }
            else if (radioButton1.Checked == false)
            {
                valor3 = "0";
            }

            cn.InsertarBodega(valor1, valor2, valor3);
            MostarBodega();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valor1;
            string valor2;
            string valor3 = "1";
            string valor4;

            valor1 = textBox1.Text;
            valor2 = textBox2.Text;

            if (radioButton1.Checked == true)
            {
                valor3 = "1";
            }
            else if (radioButton1.Checked == false)
            {
                valor3 = "0";
            }

            valor4 = textBox1.Text;

            cn.ModificarBodega(valor1, valor2, valor3, valor4);
            MostarBodega();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string valor2;
            string valor1 = "0";

            valor2 = textBox1.Text;

            cn.BorrarBodega(valor1, valor2);
            MostarBodega();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == "1")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            else if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == "0")
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
