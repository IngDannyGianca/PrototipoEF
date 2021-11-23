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
    public partial class frmClientes : Form
    {
        Controlador cn = new Controlador();
        public frmClientes()
        {
            InitializeComponent();
            CenterToScreen();
            MostarCliente();
            MostarClienteVendedor();
        }

        public void MostarCliente()
        {
            DataTable dt = cn.MostarCliente();
            dataGridView1.DataSource = dt;
        }

        public void MostarClienteVendedor()
        {
            DataTable dt = cn.MostarClienteVendedor();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "nombre_vendedor";
        }


        public void Limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            comboBox1.SelectedIndex = 0;

            radioButton1.Checked = true;
            radioButton2.Checked = false;

            dataGridView1.DataSource = "";
            MostarCliente();
        }




        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor1;
            string valor2;
            string valor3;
            string valor4;
            string valor5;
            string valor6;
            string valor7 = "1";

            valor1 = textBox1.Text;
            valor2 = textBox2.Text;

            valor3 = textBox3.Text;
            valor4 = textBox4.Text;

            valor5 = textBox5.Text;

            valor6 = (comboBox1.SelectedIndex + 1).ToString();

            if (radioButton1.Checked == true)
            {
                valor7 = "1";
            }
            else if (radioButton1.Checked == false)
            {
                valor7 = "0";
            }

            cn.InsertarCliente(valor1, valor2, valor3, valor4, valor5, valor6, valor7);
            MostarCliente();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valor1;
            string valor2;
            string valor3;
            string valor4;
            string valor5;
            string valor6;
            string valor7 = "1";
            string valor8;

            valor1 = textBox1.Text;
            valor2 = textBox2.Text;

            valor3 = textBox3.Text;
            valor4 = textBox4.Text;

            valor5 = textBox5.Text;

            valor6 = (comboBox1.SelectedIndex + 1).ToString();

            if (radioButton1.Checked == true)
            {
                valor7 = "1";
            }
            else if (radioButton1.Checked == false)
            {
                valor7 = "0";
            }

            valor8 = textBox1.Text;

            cn.ModificarCliente(valor1, valor2, valor3, valor4, valor5, valor6, valor7, valor8);
            MostarCliente();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string valor2;
            string valor1 = "0";

            valor2 = textBox1.Text;

            cn.BorrarCliente(valor1, valor2);
            MostarCliente();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            comboBox1.SelectedIndex = int.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString()) - 1;


            if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == "1")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            else if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == "0")
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
        }
    }
}
