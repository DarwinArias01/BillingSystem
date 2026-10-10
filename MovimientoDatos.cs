using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing_System
{
    public class MovimientoDatos
    {
        public DataTable ObtenerMovimientos()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string query = "SELECT ID_movimiento, NombreProducto, Tipo, Cantidad, Fecha FROM Movimientos ORDER BY ID_movimiento DESC";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public void Registrar(int idProducto, string nombreProducto, string tipo, int cantidad)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string query = "INSERT INTO Movimientos (ID_producto, NombreProducto, Tipo, Cantidad, Fecha) VALUES (@p, @n, @t, @c, GETDATE())";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@p", idProducto);
                cmd.Parameters.AddWithValue("@n", nombreProducto);
                cmd.Parameters.AddWithValue("@t", tipo);
                cmd.Parameters.AddWithValue("@c", cantidad);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
