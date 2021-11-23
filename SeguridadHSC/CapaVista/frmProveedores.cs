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
    public partial class frmProveedores : Form
    {
        Controlador cn = new Controlador();
        public frmProveedores()
        {
            InitializeComponent();
            CenterToScreen();
            MostarProveedor();
        }

        public void MostarProveedor()
        {
            DataTable dt = cn.MostarProveedor();
            dataGridView1.DataSource = dt;
        }

        public void Limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";


            radioButton1.Checked = true;
            radioButton2.Checked = false;

            dataGridView1.DataSource = "";
            MostarProveedor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor1;
            string valor2;
            string valor3;
            string valor4;
            string valor5;
            string valor6 = "1";

            valor1 = textBox1.Text;
            valor2 = textBox2.Text;

            valor3 = textBox3.Text;
            valor4 = textBox4.Text;

            valor5 = textBox5.Text;


            if (radioButton1.Checked == true)
            {
                valor6 = "1";
            }
            else if (radioButton1.Checked == false)
            {
                valor6 = "0";
            }

            cn.InsertarProveedor(valor1, valor2, valor3, valor4, valor5, valor6);
            MostarProveedor();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valor1;
            string valor2;
            string valor3;
            string valor4;
            string valor5;
            string valor6 = "1";
            string valor7;

            valor1 = textBox1.Text;
            valor2 = textBox2.Text;

            valor3 = textBox3.Text;
            valor4 = textBox4.Text;

            valor5 = textBox5.Text;


            if (radioButton1.Checked == true)
            {
                valor6 = "1";
            }
            else if (radioButton1.Checked == false)
            {
                valor6 = "0";
            }

            valor7 = textBox1.Text;

            cn.ModificarProveedor(valor1, valor2, valor3, valor4, valor5, valor6, valor7);
            MostarProveedor();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string valor2;
            string valor1 = "0";

            valor2 = textBox1.Text;

            cn.BorrarProveedor(valor1, valor2);
            MostarProveedor();
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



            if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "1")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            else if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "0")
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
        }
    }
}
