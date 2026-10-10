using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing_System
{
    public class ProductoDatos
    {
        public DataTable ObtenerProductos()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string query = "SELECT ID_Productos, Nombre, Precio, Cantidad FROM Productos";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public int Insertar(ProductoEntidad obj)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string query = "INSERT INTO Productos (Nombre, Precio, Cantidad) VALUES (@n, @p, @c); SELECT SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@n", obj.Nombre);
                cmd.Parameters.AddWithValue("@p", obj.Precio);
                cmd.Parameters.AddWithValue("@c", obj.Cantidad);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void Modificar(ProductoEntidad obj, int id)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string query = "UPDATE Productos SET Nombre = @n, Precio = @p, Cantidad = @c WHERE ID_Productos = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@n", obj.Nombre);
                cmd.Parameters.AddWithValue("@p", obj.Precio);
                cmd.Parameters.AddWithValue("@c", obj.Cantidad);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string query = "DELETE FROM Productos WHERE ID_Productos = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
