using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing_System
{
    public class Conexion
    {
        private static string _connectionString = "Server=localhost; Database=negocio; Integrated Security=true; TrustServerCertificate=true";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(_connectionString);
            conexion.Open();
            return conexion;
        }
    }
    
}
