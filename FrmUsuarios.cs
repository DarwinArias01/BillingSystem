using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Billing_System
{
    public partial class Form1 : Form
    {
        UsuarioDatos datos = new UsuarioDatos();
        int idUsuarioSeleccionado = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

               
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                TxtCorreo.Text = fila.Cells["Correo"].Value.ToString();
                cmbRol.Text = fila.Cells["Rol"].Value.ToString();

                
                idUsuarioSeleccionado = Convert.ToInt32(fila.Cells["ID_usuario"].Value);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarTabla();

        }

        private void CargarTabla()
        {
            try
            {

                dataGridView1.DataSource = datos.ObtenerUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
               
                UsuarioEntidad nuevo = new UsuarioEntidad();
                nuevo.Nombre = txtNombre.Text;
                nuevo.Correo = TxtCorreo.Text;
                nuevo.Contrasena = TxtContraseña.Text;
                nuevo.Rol = cmbRol.Text;

                
                datos.Insertar(nuevo);

                MessageBox.Show("¡Usuario guardado con éxito!");

                
                CargarTabla();

               
                txtNombre.Clear();
                TxtCorreo.Clear();
                TxtContraseña.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == 0)
            {
                MessageBox.Show("Por favor, selecciona primero un usuario de la tabla.");
                return;
            }

            try
            {
                
                UsuarioEntidad editado = new UsuarioEntidad();
                editado.Nombre = txtNombre.Text;
                editado.Correo = TxtCorreo.Text;
                editado.Rol = cmbRol.Text;

                
                datos.modificar(editado, idUsuarioSeleccionado);

                MessageBox.Show("¡Usuario modificado con éxito!");

               
                CargarTabla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

       
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            TxtCorreo.Clear();
            idUsuarioSeleccionado = 0;

        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            TxtCorreo.Clear();
            TxtContraseña.Clear();


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == 0)
            {
                MessageBox.Show("Por favor, selecciona primero un usuario de la tabla.");
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    datos.eliminar(idUsuarioSeleccionado);
                    MessageBox.Show("¡Usuario eliminado con éxito!");
                    CargarTabla();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }
    }
}
