using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModelo
{
    public class Sentencias
    {
        private Conexion cn = new Conexion();
        private OdbcCommand Comm;


        //FRM LINEA -------------------------------------------------------------------------
        public OdbcDataAdapter MostarLinea()
        {
            string sql = "SELECT * FROM lineas;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public void InsertarLinea(string valor1, string valor2, string valor3)
        {
            string sql = "INSERT INTO lineas(`codigo_linea`, `nombre_linea`, `estatus_linea`) Values( '" + valor1 + "', '" + valor2 + "', '" + valor3 + "');";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void DestruirLinea(string valor1)
        {
            string sql = "DELETE FROM lineas WHERE codigo_linea = '" + valor1 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void ModificarLinea(string valor1, string valor2, string valor3, string valor4)
        {
            string sql = "UPDATE lineas SET codigo_linea = '" + valor1 + "', nombre_linea = '" + valor2 + "', estatus_linea = '" + valor3 + "'  WHERE codigo_linea = '" + valor4 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void BorrarLinea(string valor1, string valor2)
        {
            string sql = "UPDATE lineas SET estatus_linea = '" + valor1 + "'  WHERE codigo_linea = '" + valor2 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        //FRM MARCA -------------------------------------------------------------------------
        public OdbcDataAdapter MostarMarca()
        {
            string sql = "SELECT * FROM marcas;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public void InsertarMarca(string valor1, string valor2, string valor3)
        {
            string sql = "INSERT INTO marcas(`codigo_marca`, `nombre_marca`, `estatus_marca`) Values( '" + valor1 + "', '" + valor2 + "', '" + valor3 + "');";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void DestruirMarca(string valor1)
        {
            string sql = "DELETE FROM marcas WHERE codigo_marca = '" + valor1 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void ModificarMarca(string valor1, string valor2, string valor3, string valor4)
        {
            string sql = "UPDATE marcas SET codigo_marca = '" + valor1 + "', nombre_marca = '" + valor2 + "', estatus_marca = '" + valor3 + "'  WHERE codigo_marca = '" + valor4 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void BorrarMarca(string valor1, string valor2)
        {
            string sql = "UPDATE marcas SET estatus_marca = '" + valor1 + "'  WHERE codigo_marca = '" + valor2 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }



        //FRM BODEGA -------------------------------------------------------------------------
        public OdbcDataAdapter MostarBodega()
        {
            string sql = "SELECT * FROM bodegas;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public void InsertarBodega(string valor1, string valor2, string valor3)
        {
            string sql = "INSERT INTO bodegas(`codigo_bodega`, `nombre_bodega`, `estatus_bodega`) Values( '" + valor1 + "', '" + valor2 + "', '" + valor3 + "');";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void DestruirBodega(string valor1)
        {
            string sql = "DELETE FROM bodegas WHERE codigo_bodega = '" + valor1 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void ModificarBodega(string valor1, string valor2, string valor3, string valor4)
        {
            string sql = "UPDATE bodegas SET codigo_bodega = '" + valor1 + "', nombre_bodega = '" + valor2 + "', estatus_bodega = '" + valor3 + "'  WHERE codigo_bodega = '" + valor4 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void BorrarBodega(string valor1, string valor2)
        {
            string sql = "UPDATE bodegas SET estatus_bodega = '" + valor1 + "'  WHERE codigo_bodega = '" + valor2 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }


        //FRM PRODUCTOS -------------------------------------------------------------------------
        public OdbcDataAdapter MostarProducto()
        {
            string sql = "SELECT * FROM productos;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter MostarProductoLinea()
        {
            string sql = "SELECT * FROM lineas;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter MostarProductoMarca()
        {
            string sql = "SELECT * FROM marcas;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public void InsertarProducto(string valor1, string valor2, string valor3, string valor4, float valor5, string valor6)
        {
            string sql = "INSERT INTO productos(`codigo_producto`, `nombre_producto`, `codigo_linea`, `codigo_marca`, `precio_producto`,  `estatus_producto`) Values( '" + valor1 + "', '" + valor2 + "', '" + valor3 + "', '" + valor4 + "', " + valor5 + ", '" + valor6 + "');";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void DestruirProducto(string valor1)
        {
            string sql = "DELETE FROM productos WHERE codigo_producto = '" + valor1 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void ModificarProducto(string valor1, string valor2, string valor3, string valor4, float valor5, string valor6, string valor7)
        {
            string sql = "UPDATE productos SET codigo_producto = '" + valor1 + "', nombre_producto = '" + valor2 + "', codigo_linea = '" + valor3 + "', codigo_marca = '" + valor4 + "', precio_producto = " + valor5 + ", estatus_producto = '" + valor6 + "'  WHERE codigo_producto = '" + valor7 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void BorrarProducto(string valor1, string valor2)
        {
            string sql = "UPDATE productos SET estatus_producto = '" + valor1 + "'  WHERE codigo_producto = '" + valor2 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        //FRM VENTA ---------------------------------------------------------------
        public OdbcDataAdapter MostarVentaCliente()
        {
            string sql = "SELECT * FROM clientes;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter MostarVentaTotal(string valor1)
        {
            string sql = " SELECT SUM(precio_ventadet * cantidad_ventadet) FROM `ventas_detalle` WHERE documento_ventaenca = '" + valor1 + "';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public void InsertarVentaTotal(string valor1, string valor2)
        {
            string sql = "UPDATE ventas_encabezado SET 	total_ventaenca = '" + valor1 + "'  WHERE documento_ventaenca = '" + valor2 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }


        public OdbcDataAdapter MostarVentaClienteNombre(string valor1)
        {
            string sql = "SELECT nombre_cliente FROM clientes WHERE codigo_cliente = '" + valor1 + "';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter MostarVentaProducto()
        {
            string sql = "SELECT * FROM productos;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        public OdbcDataAdapter MostarVentaProductoNombre(string valor1)
        {
            string sql = "SELECT nombre_producto FROM productos  WHERE codigo_producto = '" + valor1 + "';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter MostarVentaProductoPrecio(string valor1)
        {
            string sql = "SELECT precio_producto FROM productos WHERE codigo_producto = '" + valor1 + "';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public void InsertarVentaDetalle(string valor1, string valor2, string valor3, float valor4, float valor5, string valor6)
        {
            string sql = "INSERT INTO ventas_detalle(`documento_ventaenca`, `codigo_producto`, `cantidad_ventadet`, `costo_ventadet`, `precio_ventadet`, `codigo_bodega`) Values( '" + valor1 + "', '" + valor2 + "', '" + valor3 + "', " + valor4 + ", " + valor5 + ", '" + valor6 + "');";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public OdbcDataAdapter MostarVentaDetalle()
        {
            string sql = "SELECT * FROM ventas_detalle;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public void EliminarTodoVentaDetalle(string valor1)
        {
            string sql = "DELETE FROM ventas_detalle WHERE documento_ventaenca = '" + valor1 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }


        //FRM CLIENTES -------------------------------------------------------------------------
        public OdbcDataAdapter MostarCliente()
        {
            string sql = "SELECT * FROM clientes;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter MostarClienteVendedor()
        {
            string sql = "SELECT nombre_vendedor FROM vendedores;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }


        public void InsertarCliente(string valor1, string valor2, string valor3, string valor4, string valor5, string valor6, string valor7)
        {
            string sql = "INSERT INTO clientes(`codigo_cliente`, `nombre_cliente`, `direccion_cliente`, `nit_cliente`, `telefono_cliente`, `codigo_vendedor`,  `estatus_cliente`) Values( '" + valor1 + "', '" + valor2 + "', '" + valor3 + "', '" + valor4 + "', '" + valor5 + "', '" + valor6 + "', '" + valor7 + "');";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void DestruirCliente(string valor1)
        {
            string sql = "DELETE FROM clientes WHERE codigo_cliente = '" + valor1 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void ModificarCliente(string valor1, string valor2, string valor3, string valor4, string valor5, string valor6, string valor7, string valor8)
        {
            string sql = "UPDATE clientes SET codigo_cliente = '" + valor1 + "', nombre_cliente = '" + valor2 + "', direccion_cliente = '" + valor3 + "', nit_cliente = '" + valor4 + "', telefono_cliente = '" + valor5 + "',  codigo_vendedor = '" + valor6 + "',  estatus_cliente = '" + valor7 + "'  WHERE codigo_cliente = '" + valor8 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void BorrarCliente(string valor1, string valor2)
        {
            string sql = "UPDATE clientes SET estatus_cliente = '" + valor1 + "'  WHERE codigo_cliente = '" + valor2 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        //FRM PROVEEDOR -------------------------------------------------------------------------
        public OdbcDataAdapter MostarProveedor()
        {
            string sql = "SELECT * FROM proveedores;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public void InsertarProveedor(string valor1, string valor2, string valor3, string valor4, string valor5, string valor6)
        {
            string sql = "INSERT INTO proveedores(`codigo_proveedor`, `nombre_proveedor`, `direccion_proveedor`, `telefono_proveedor`, `nit_proveedor`,  `estatus_proveedor`) Values( '" + valor1 + "', '" + valor2 + "', '" + valor3 + "', '" + valor4 + "', '" + valor5 + "', '" + valor6 + "');";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void DestruirProveedor(string valor1)
        {
            string sql = "DELETE FROM proveedores WHERE codigo_proveedor = '" + valor1 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void ModificarProveedor(string valor1, string valor2, string valor3, string valor4, string valor5, string valor6, string valor7)
        {
            string sql = "UPDATE proveedores SET codigo_proveedor = '" + valor1 + "', nombre_proveedor = '" + valor2 + "', direccion_proveedor = '" + valor3 + "', telefono_proveedor = '" + valor4 + "', nit_proveedor = '" + valor5 + "', estatus_proveedor = '" + valor6 + "'  WHERE codigo_proveedor = '" + valor7 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void BorrarProveedor(string valor1, string valor2)
        {
            string sql = "UPDATE proveedores SET estatus_proveedor = '" + valor1 + "'  WHERE codigo_proveedor = '" + valor2 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }




        //FRM TIPO MOVIMIENTO -------------------------------------------------------------------------
        public OdbcDataAdapter MostarTipoMovimiento()
        {
            string sql = "SELECT * FROM tipomovimiento;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public void InsertarTipoMovimiento(string valor1, string valor2, string valor3)
        {
            string sql = "INSERT INTO tipomovimiento(`codigo_tipomovimiento`, `nombre_tipomovimiento`, `estatus_tipomovimiento`) Values( '" + valor1 + "', '" + valor2 + "', '" + valor3 + "');";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void DestruirTipoMovimiento(string valor1)
        {
            string sql = "DELETE FROM tipomovimiento WHERE codigo_tipomovimiento = '" + valor1 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void ModificarTipoMovimiento(string valor1, string valor2, string valor3, string valor4)
        {
            string sql = "UPDATE tipomovimiento SET codigo_tipomovimiento = '" + valor1 + "', nombre_tipomovimiento = '" + valor2 + "', estatus_tipomovimiento = '" + valor3 + "'  WHERE codigo_tipomovimiento = '" + valor4 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void BorrarTipoMovimiento(string valor1, string valor2)
        {
            string sql = "UPDATE tipomovimiento SET estatus_tipomovimiento = '" + valor1 + "'  WHERE codigo_tipomovimiento = '" + valor2 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }



    }
}
