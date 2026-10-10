using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDatos usuarioDatos = new UsuarioDatos();
                DataTable dt = usuarioDatos.ValidarLogin(txtUsuario.Text.Trim(), txtContra.Text.Trim());

                if (dt.Rows.Count > 0)
                {
                   
                    UsuarioEntidad usuarioLogueado = new UsuarioEntidad
                    {
                        Nombre = dt.Rows[0]["Nombre"].ToString(),
                        Correo = dt.Rows[0]["Correo"].ToString(),
                        Rol = dt.Rows[0]["Rol"].ToString()
                    };

                  
                    SesionActual.Usuario = usuarioLogueado;

                    MessageBox.Show($"Bienvenido {SesionActual.Usuario.Nombre} ({SesionActual.Usuario.Rol})");

                    
                    this.Hide();

                    using (FrmInicio menu = new FrmInicio())
                    {
                        menu.ShowDialog();
                    }

                   
                    SesionActual.Usuario = null;
                    txtContra.Clear();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al validar el login: {ex.Message}");
            } 
        }
    }


}
