using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing_System
{
    public class VentaDatos
    {
       
          
            public DataTable ObtenerProductos()
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = "SELECT ID_Productos, Nombre, Precio, Cantidad FROM Productos WHERE Cantidad > 0";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                return dt;
            }

           
            public DataTable ObtenerVentas()
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = @"SELECT 
                                    f.ID_Factura AS [N° Factura], 
                                    f.Fecha AS [Fecha y Hora], 
                                    ISNULL((SELECT SUM(df.Cantidad) FROM DetalleFacturas df WHERE df.ID_Factura = f.ID_Factura), 0) AS [Cant. Artículos],
                                    f.Total AS [Total RD$]
                                 FROM Facturas f
                                 ORDER BY f.Fecha DESC";

                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                return dt;
            }

           
            public void RegistrarVenta(int idProducto, int cantidad, decimal precio, int? idCliente = null, int? idUsuario = null)
            {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
               
                using (SqlTransaction tran = con.BeginTransaction())
                {
                    try
                    {
                        decimal total = cantidad * precio;

                       
                        string insertFactura = @"INSERT INTO Facturas (ID_Cliente, ID_Usuario, Fecha, Total) 
                                         VALUES (@cliente, @usuario, @f, @t); 
                                         SELECT SCOPE_IDENTITY();";

                        SqlCommand cmdFactura = new SqlCommand(insertFactura, con, tran);
                        cmdFactura.Parameters.AddWithValue("@cliente", (object)idCliente ?? DBNull.Value);
                        cmdFactura.Parameters.AddWithValue("@usuario", (object)idUsuario ?? DBNull.Value);
                        cmdFactura.Parameters.AddWithValue("@f", DateTime.Now);
                        cmdFactura.Parameters.AddWithValue("@t", total);

                        int idFactura = Convert.ToInt32(cmdFactura.ExecuteScalar());

                       
                        string insertDetalle = @"INSERT INTO DetalleFacturas (ID_Factura, ID_Producto, Cantidad, PrecioUnitario, Subtotal) 
                                         VALUES (@factura, @producto, @cant, @precioUnit, @subtotal)";

                        SqlCommand cmdDetalle = new SqlCommand(insertDetalle, con, tran);
                        cmdDetalle.Parameters.AddWithValue("@factura", idFactura);
                        cmdDetalle.Parameters.AddWithValue("@producto", idProducto);
                        cmdDetalle.Parameters.AddWithValue("@cant", cantidad);
                        cmdDetalle.Parameters.AddWithValue("@precioUnit", precio);
                        cmdDetalle.Parameters.AddWithValue("@subtotal", total);
                        cmdDetalle.ExecuteNonQuery();

                      
                        string updateStock = "UPDATE Productos SET Cantidad = Cantidad - @cant WHERE ID_Productos = @producto";
                        SqlCommand cmdStock = new SqlCommand(updateStock, con, tran);
                        cmdStock.Parameters.AddWithValue("@cant", cantidad);
                        cmdStock.Parameters.AddWithValue("@producto", idProducto);
                        cmdStock.ExecuteNonQuery();

                       
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        
                        tran.Rollback();
                        throw new Exception("Error al registrar la factura: " + ex.Message);
                    }
                }
            }
        }
        
    }
}
