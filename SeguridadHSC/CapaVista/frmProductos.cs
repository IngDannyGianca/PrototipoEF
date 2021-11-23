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
    public partial class frmProductos : Form
    {
        Controlador cn = new Controlador();
        public frmProductos()
        {
            InitializeComponent();
            CenterToScreen();
            MostarProducto();
            MostarProductoLinea();
            MostarProductoMarca();
        }

        public void MostarProducto()
        {
            DataTable dt = cn.MostarProducto();
            dataGridView1.DataSource = dt;
        }

        public void MostarProductoLinea()
        {
            DataTable dt = cn.MostarProductoLinea();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "nombre_linea";
        }

        public void MostarProductoMarca()
        {
            DataTable dt = cn.MostarProductoMarca();
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "nombre_marca";
        }

        public void Limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            radioButton1.Checked = true;
            radioButton2.Checked = false;

            dataGridView1.DataSource = "";
            MostarProducto();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor1;
            string valor2;
            string valor3;
            string valor4;
            float valor5;
            string valor6 = "1";

            valor1 = textBox1.Text;
            valor2 = textBox2.Text;

            valor3 = (comboBox1.SelectedIndex + 1).ToString();
            valor4 = (comboBox2.SelectedIndex + 1).ToString();

            valor5 = float.Parse(textBox5.Text);

            if (radioButton1.Checked == true)
            {
                valor6 = "1";
            }
            else if (radioButton1.Checked == false)
            {
                valor6 = "0";
            }

            cn.InsertarProducto(valor1, valor2, valor3, valor4, valor5, valor6);
            MostarProducto();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valor1;
            string valor2;
            string valor3;
            string valor4;
            float valor5;
            string valor6 = "1";
            string valor7;

            valor1 = textBox1.Text;
            valor2 = textBox2.Text;

            valor3 = (comboBox1.SelectedIndex + 1).ToString();
            valor4 = (comboBox2.SelectedIndex + 1).ToString();

            valor5 = float.Parse(textBox5.Text);

            if (radioButton1.Checked == true)
            {
                valor6 = "1";
            }
            else if (radioButton1.Checked == false)
            {
                valor6 = "0";
            }

            

            valor7 = textBox1.Text;

            cn.ModificarProducto(valor1, valor2, valor3, valor4, valor5, valor6, valor7);
            MostarProducto();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string valor2;
            string valor1 = "0";

            valor2 = textBox1.Text;

            cn.BorrarProducto(valor1, valor2);
            MostarProducto();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            comboBox1.SelectedIndex = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString())-1;
            comboBox2.SelectedIndex = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString())-1;

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
