using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelo;

namespace CapaControlador
{
    public class Controlador
    {
        private Sentencias sn = new Sentencias();

        //FRM LINEA -------------------------------------------------------------------------
        public DataTable MostarLinea()
        {
            OdbcDataAdapter dt = sn.MostarLinea();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void InsertarLinea(string valor1, string valor2, string valor3)
        {
            sn.InsertarLinea(valor1, valor2, valor3);
        }

        public void DestruirLinea(string valor1)
        {
            sn.DestruirLinea(valor1);
        }

        public void ModificarLinea(string valor1, string valor2, string valor3, string valor4)
        {
            sn.ModificarLinea(valor1, valor2, valor3, valor4);
        }

        public void BorrarLinea(string valor1, string valor2)
        {
            sn.BorrarLinea(valor1, valor2);
        }


        //FRM MARCA -------------------------------------------------------------------------
        public DataTable MostarMarca()
        {
            OdbcDataAdapter dt = sn.MostarMarca();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void InsertarMarca(string valor1, string valor2, string valor3)
        {
            sn.InsertarMarca(valor1, valor2, valor3);
        }

        public void DestruirMarca(string valor1)
        {
            sn.DestruirMarca(valor1);
        }

        public void ModificarMarca(string valor1, string valor2, string valor3, string valor4)
        {
            sn.ModificarMarca(valor1, valor2, valor3, valor4);
        }

        public void BorrarMarca(string valor1, string valor2)
        {
            sn.BorrarMarca(valor1, valor2);
        }

        //FRM BODEGA -------------------------------------------------------------------------
        public DataTable MostarBodega()
        {
            OdbcDataAdapter dt = sn.MostarBodega();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void InsertarBodega(string valor1, string valor2, string valor3)
        {
            sn.InsertarBodega(valor1, valor2, valor3);
        }

        public void DestruirBodega(string valor1)
        {
            sn.DestruirBodega(valor1);
        }

        public void ModificarBodega(string valor1, string valor2, string valor3, string valor4)
        {
            sn.ModificarBodega(valor1, valor2, valor3, valor4);
        }

        public void BorrarBodega(string valor1, string valor2)
        {
            sn.BorrarBodega(valor1, valor2);
        }

        //FRM PRODUCTO -------------------------------------------------------------------------
        public DataTable MostarProducto()
        {
            OdbcDataAdapter dt = sn.MostarProducto();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable MostarProductoLinea()
        {
            OdbcDataAdapter dt = sn.MostarProductoLinea();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable MostarProductoMarca()
        {
            OdbcDataAdapter dt = sn.MostarProductoMarca();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void InsertarProducto(string valor1, string valor2, string valor3, string valor4, float valor5, string valor6)
        {
            sn.InsertarProducto(valor1, valor2, valor3, valor4, valor5, valor6);
        }

        public void DestruirProducto(string valor1)
        {
            sn.DestruirProducto(valor1);
        }

        public void ModificarProducto(string valor1, string valor2, string valor3, string valor4, float valor5, string valor6, string valor7)
        {
            sn.ModificarProducto(valor1, valor2, valor3, valor4, valor5, valor6, valor7);
        }

        public void BorrarProducto(string valor1, string valor2)
        {
            sn.BorrarProducto(valor1, valor2);
        }

        //FRM VENTA -------------------------------------------------------------------------
        public DataTable MostarVentaCliente()
        {
            OdbcDataAdapter dt = sn.MostarVentaCliente();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable MostarVentaTotal(string valor1)
        {
            OdbcDataAdapter dt = sn.MostarVentaTotal(valor1);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void InsertarVentaTotal(string valor1, string valor2)
        {
            sn.InsertarVentaTotal(valor1, valor2);
        }

        public DataTable MostarVentaClienteNombre(string valor1)
        {
            OdbcDataAdapter dt = sn.MostarVentaClienteNombre(valor1);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable MostarVentaProducto()
        {
            OdbcDataAdapter dt = sn.MostarVentaProducto();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable MostarVentaProductoNombre(string valor1)
        {
            OdbcDataAdapter dt = sn.MostarVentaProductoNombre(valor1);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable MostarVentaProductoPrecio(string valor1)
        {
            OdbcDataAdapter dt = sn.MostarVentaProductoPrecio(valor1);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void InsertarVentaDetalle(string valor1, string valor2, string valor3, float valor4, float valor5, string valor6)
        {
            sn.InsertarVentaDetalle(valor1, valor2, valor3, valor4, valor5, valor6);
        }

        public DataTable MostarVentaDetalle()
        {
            OdbcDataAdapter dt = sn.MostarVentaDetalle();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void EliminarTodoVentaDetalle(string valor1)
        {
            sn.EliminarTodoVentaDetalle(valor1);
        }


        //FRM CLIENTE -------------------------------------------------------------------------
        public DataTable MostarCliente()
        {
            OdbcDataAdapter dt = sn.MostarCliente();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable MostarClienteVendedor()
        {
            OdbcDataAdapter dt = sn.MostarClienteVendedor();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }


        public void InsertarCliente(string valor1, string valor2, string valor3, string valor4, string valor5, string valor6, string valor7)
        {
            sn.InsertarCliente(valor1, valor2, valor3, valor4, valor5, valor6, valor7);
        }

        public void DestruirCliente(string valor1)
        {
            sn.DestruirCliente(valor1);
        }

        public void ModificarCliente(string valor1, string valor2, string valor3, string valor4, string valor5, string valor6, string valor7, string valor8)
        {
            sn.ModificarCliente(valor1, valor2, valor3, valor4, valor5, valor6, valor7, valor8);
        }

        public void BorrarCliente(string valor1, string valor2)
        {
            sn.BorrarCliente(valor1, valor2);
        }

        //FRM PROVEEDOR -------------------------------------------------------------------------
        public DataTable MostarProveedor()
        {
            OdbcDataAdapter dt = sn.MostarProveedor();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void InsertarProveedor(string valor1, string valor2, string valor3, string valor4, string valor5, string valor6)
        {
            sn.InsertarProveedor(valor1, valor2, valor3, valor4, valor5, valor6);
        }

        public void DestruirProveedor(string valor1)
        {
            sn.DestruirProveedor(valor1);
        }

        public void ModificarProveedor(string valor1, string valor2, string valor3, string valor4, string valor5, string valor6, string valor7)
        {
            sn.ModificarProveedor(valor1, valor2, valor3, valor4, valor5, valor6, valor7);
        }

        public void BorrarProveedor(string valor1, string valor2)
        {
            sn.BorrarProveedor(valor1, valor2);
        }


        //FRM TIPO MOVIMIENTO -------------------------------------------------------------------------
        public DataTable MostarTipoMovimiento()
        {
            OdbcDataAdapter dt = sn.MostarTipoMovimiento();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void InsertarTipoMovimiento(string valor1, string valor2, string valor3)
        {
            sn.InsertarTipoMovimiento(valor1, valor2, valor3);
        }

        public void DestruirTipoMovimiento(string valor1)
        {
            sn.DestruirTipoMovimiento(valor1);
        }

        public void ModificarTipoMovimiento(string valor1, string valor2, string valor3, string valor4)
        {
            sn.ModificarTipoMovimiento(valor1, valor2, valor3, valor4);
        }

        public void BorrarTipoMovimiento(string valor1, string valor2)
        {
            sn.BorrarTipoMovimiento(valor1, valor2);
        }



    }
}