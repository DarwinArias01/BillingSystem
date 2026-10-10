using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing_System
{
    public class ReporteDatos
    {
        public DataTable ObtenerReporteVentas()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string query = "SELECT v.ID_venta, v.Fecha, v.Total, " +
                               "(SELECT SUM(dv.Cantidad) FROM DetalleVentas dv WHERE dv.ID_venta = v.ID_venta) AS Cantidad " +
                               "FROM Ventas v";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable ObtenerReporteProductos()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string query = "SELECT ID_producto, Nombre, Precio, Cantidad FROM Productos ORDER BY Nombre";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
    }
}
