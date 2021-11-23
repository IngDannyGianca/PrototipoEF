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
    public partial class frmMovimiento : Form
    {
        Controlador cn = new Controlador();
        public frmMovimiento()
        {
            InitializeComponent();
            CenterToScreen();
            MostarVentaCliente();
            MostarVentaProducto();
            MostarVentaDetalle();

            textBox3.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        public void MostarVentaCliente()
        {
            DataTable dt = cn.MostarVentaCliente();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "codigo_cliente";
        }

        public void InsertarVentaTotal()
        {
            string valor2;
            string valor1;

            valor2 = textBox1.Text;
            valor1 = textBox4.Text;

            cn.InsertarVentaTotal(valor1, valor2);
            MostarVentaTotal();
        }

        

        public void MostarVentaDetalle()
        {
            DataTable dt = cn.MostarVentaDetalle();
            dataGridView1.DataSource = dt;
        }

        public void MostarVentaClienteNombre()
        {
            string valor1 = comboBox1.Text;
            DataTable dt = cn.MostarVentaClienteNombre(valor1);
            string dta = string.Join(Environment.NewLine, dt.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));
            textBox2.Text = dta;
        }

        public void MostarVentaProducto()
        {
            DataTable dt = cn.MostarVentaProducto();
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "codigo_producto";
        }

        public void MostarVentaProductoNombre()
        {
            string valor1 = comboBox2.Text;
            DataTable dt = cn.MostarVentaProductoNombre(valor1);
            string dta = string.Join(Environment.NewLine, dt.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));
            textBox5.Text = dta;
        }

        public void MostarVentaProductoPrecio()
        {
            string valor1 = comboBox2.Text;
            DataTable dt = cn.MostarVentaProductoPrecio(valor1);
            string dta = string.Join(Environment.NewLine, dt.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));
            textBox6.Text = dta;

        }

        public void MostarVentaTotal()
        {
            string valor1 = textBox1.Text;
            DataTable dt = cn.MostarVentaTotal(valor1);
            string dta = string.Join(Environment.NewLine, dt.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));
            textBox4.Text = dta;
        }

        public void Limpiar()
        {
            textBox1.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            textBox7.Text = "";

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;


            dataGridView1.DataSource = "";

        }




        private void button1_Click(object sender, EventArgs e)
        {
            string valor1 = textBox1.Text; //documento_ventaenca 
            string valor2 = comboBox2.Text;  //codigo_producto
            string valor3 = textBox7.Text; //cantidad_ventadet	
            float valor4 = float.Parse(textBox6.Text); //costo_ventadet
            float valor5 = float.Parse(textBox6.Text); //precio_ventadet
            string valor6 = "1"; //codigo_bodega

            cn.InsertarVentaDetalle(valor1, valor2, valor3, valor4, valor5, valor6);
            MostarVentaDetalle();
            MostarVentaTotal();
            InsertarVentaTotal();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostarVentaProductoNombre();
            MostarVentaProductoPrecio();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostarVentaClienteNombre();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostarVentaDetalle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string valor1 = textBox1.Text;
            cn.EliminarTodoVentaDetalle(valor1);
            MostarVentaDetalle();
            InsertarVentaTotal();
        }
    }
}
