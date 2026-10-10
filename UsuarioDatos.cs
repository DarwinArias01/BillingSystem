using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing_System
{
    public class UsuarioDatos
    {

        public DataTable ObtenerUsuarios()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string query = "SELECT ID_usuario ,Nombre, Correo, Rol FROM Usuarios";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);


            }
            return dt;

        }

        public void Insertar(UsuarioEntidad obj)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string query = "INSERT INTO Usuarios (Nombre, Correo, Contraseña, Rol) VALUES (@n, @c, @p, @r)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@n", obj.Nombre);
                cmd.Parameters.AddWithValue("@c", obj.Correo);
                cmd.Parameters.AddWithValue("@p", obj.Contrasena);
                cmd.Parameters.AddWithValue("@r", obj.Rol);


                cmd.ExecuteNonQuery();


            }
        }

        public void modificar(UsuarioEntidad obj, int id)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string query = "UPDATE Usuarios SET Nombre  = @n, Correo = @c, Rol = @r WHERE ID_usuario = @id";
                using (SqlCommand cmd = new SqlCommand(query,con)) 
                {
                    cmd.Parameters.AddWithValue("@n", obj.Nombre);
                    cmd.Parameters.AddWithValue("@c", obj.Correo);
                    cmd.Parameters.AddWithValue("@r", obj.Rol);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }

        }




        public void eliminar(int id)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string query = "DELETE FROM Usuarios WHERE ID_usuario = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable ValidarLogin(string correo, string contrasena)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
               
                string query = "SELECT Nombre, Correo, Rol FROM usuarios WHERE Correo = @correo AND Contraseña = @contraseña";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@contraseña", contrasena);

                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(tabla);
            }

            return tabla;
        }


    } 
    


}
