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
    public partial class FrmMovimientos : Form
    {
        MovimientoDatos datos = new MovimientoDatos();

        public FrmMovimientos()
        {
            InitializeComponent();
        }

        private void FrmMovimientos_Load(object sender, EventArgs e)
        {
            CargarMovimientos();
        }

        private void CargarMovimientos()
        {
            try
            {
                dataGridView1.DataSource = datos.ObtenerMovimientos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los movimientos: " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
