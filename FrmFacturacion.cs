using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System
{
    public partial class FrmFacturacion : Form
    {
        VentaDatos datos = new VentaDatos();
        int idProductoSeleccionado = 0;

        public FrmFacturacion()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            
            txtCantidad.TextChanged += CalcularTotal;

            CargarProductos();
            CargarVentas();
        }

        private void CargarProductos()
        {
            try
            {
                DataTable dt = datos.ObtenerProductos();

                if (dt != null && dt.Rows.Count > 0)
                {
                    
                    cmbProducto.DataSource = null;
                    cmbProducto.DisplayMember = "Nombre";
                    cmbProducto.ValueMember = "ID_Productos";
                    cmbProducto.DataSource = dt;

                    cmbProducto.SelectedIndex = -1; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cmbProducto.SelectedIndex != -1 && cmbProducto.SelectedItem is DataRowView)
            {
                DataRowView drv = (DataRowView)cmbProducto.SelectedItem;
                idProductoSeleccionado = Convert.ToInt32(drv["ID_Productos"]);
                txtPrecio.Text = drv["Precio"].ToString();
                txtDisponible.Text = drv["Cantidad"].ToString();
            }
            else
            {
                idProductoSeleccionado = 0;
                txtPrecio.Clear();
                txtDisponible.Clear();
            }

            CalcularTotal(null, EventArgs.Empty);
        }

        private void CalcularTotal(object sender, EventArgs e)
        {
            try
            {
                int cantidad = string.IsNullOrEmpty(txtCantidad.Text) ? 0 : Convert.ToInt32(txtCantidad.Text);
                decimal precio = string.IsNullOrEmpty(txtPrecio.Text) ? 0 : Convert.ToDecimal(txtPrecio.Text);

                txtTotal.Text = (cantidad * precio).ToString("N2"); 
            }
            catch
            {
                txtTotal.Text = "0.00";
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idProductoSeleccionado == 0)
                {
                    MessageBox.Show("Por favor, selecciona un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Ingresa una cantidad válida mayor a cero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal precio = Convert.ToDecimal(txtPrecio.Text);
                int disponible = Convert.ToInt32(txtDisponible.Text);

                if (cantidad > disponible)
                {
                    MessageBox.Show("No hay suficiente stock disponible para realizar la venta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                datos.RegistrarVenta(idProductoSeleccionado, cantidad, precio);

                string nombreProducto = cmbProducto.Text;
                MovimientoDatos mov = new MovimientoDatos();
                mov.Registrar(idProductoSeleccionado, nombreProducto, "Vendido", cantidad);

                MessageBox.Show("¡Venta registrada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                CargarVentas();
                CargarProductos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtTotal.Clear();
            txtDisponible.Clear();
            cmbProducto.SelectedIndex = -1;
            idProductoSeleccionado = 0;
        }

        private void CargarVentas()
        {
            try
            {
                DataTable dtVentas = datos.ObtenerVentas();

                if (dtVentas != null)
                {
                    
                    dataGridView1.DataSource = null;
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = dtVentas;
                    dataGridView1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
