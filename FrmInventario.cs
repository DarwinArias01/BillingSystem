using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System
{
    public partial class FrmInventario : Form
    {
        ProductoDatos datos = new ProductoDatos();
        int idProductoSeleccionado = 0;

        public FrmInventario()
        {
            InitializeComponent();
        }

        // Método único para cargar el DataGridView desde la capa de datos
        public void CargarInventario()
        {
            try
            {
                dataGridView1.DataSource = datos.ObtenerProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            CargarInventario();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Usar CellClick para capturar el clic en cualquier parte de la fila
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];


                    txtNombre.Text = fila.Cells["nombre"].Value.ToString();
                    txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                    txtCantidad.Text = fila.Cells["Cantidad"].Value.ToString();


                    idProductoSeleccionado = Convert.ToInt32(fila.Cells["ID_Productos"].Value);
                }
            
        }
        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ProductoEntidad nuevo = new ProductoEntidad();
                nuevo.Nombre = txtNombre.Text;
                nuevo.Precio = Convert.ToDecimal(txtPrecio.Text);
                nuevo.Cantidad = Convert.ToInt32(txtCantidad.Text);

                int nuevoId = datos.Insertar(nuevo);

               

                MessageBox.Show("¡Producto guardado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarInventario();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Por favor, selecciona primero un producto de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ProductoEntidad editado = new ProductoEntidad();
                editado.Nombre = txtNombre.Text;
                editado.Precio = Convert.ToDecimal(txtPrecio.Text);
                editado.Cantidad = Convert.ToInt32(txtCantidad.Text);

                datos.Modificar(editado, idProductoSeleccionado);

                MessageBox.Show("¡Producto modificado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarInventario();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Por favor, selecciona primero un producto de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    string nombre = txtNombre.Text;
                    int cantidad = string.IsNullOrEmpty(txtCantidad.Text) ? 0 : Convert.ToInt32(txtCantidad.Text);
                    datos.Eliminar(idProductoSeleccionado);

                  

                    MessageBox.Show("¡Producto eliminado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarInventario();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            idProductoSeleccionado = 0;
        }
    }
}