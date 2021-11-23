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
    public partial class frmLinea : Form
    {
        Controlador cn = new Controlador();
        public frmLinea()
        {
            InitializeComponent();
            CenterToScreen();
            MostarLinea();
        }

        public void MostarLinea()
        {
            DataTable dt = cn.MostarLinea();
            dataGridView1.DataSource = dt;
        }

        public void Limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";

            radioButton1.Checked = true;
            radioButton2.Checked = false;

            dataGridView1.DataSource = "";
            MostarLinea();
        }




        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string valor2;
            string valor1 ="0";

            valor2 = textBox1.Text;

            cn.BorrarLinea(valor1, valor2);
            MostarLinea();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valor1;
            string valor2;
            string valor3 ="1";
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

            cn.ModificarLinea(valor1, valor2, valor3, valor4);
            MostarLinea();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor1;
            string valor2;
            string valor3 = "1";

            valor1 = textBox1.Text;
            valor2 = textBox2.Text;
            if (radioButton1.Checked == true)  {
                valor3 = "1";
            } else if (radioButton1.Checked == false)
            {
                valor3 = "0";
            }

            cn.InsertarLinea(valor1, valor2, valor3);
            MostarLinea();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
    }
}
