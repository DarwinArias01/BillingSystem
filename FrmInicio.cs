namespace Billing_System
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            FrmInventario frm = new FrmInventario();
            frm.ShowDialog();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmInventario frm = new FrmInventario();
            frm.ShowDialog();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            FrmFacturacion frm = new FrmFacturacion();
            frm.ShowDialog();
        }

        

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            FrmMovimientos frm = new FrmMovimientos();
            frm.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            if (SesionActual.Usuario != null)
            {
                string rolActual = SesionActual.Usuario.Rol?.Trim().ToLower() ?? "";

                switch (rolActual)
                {
                    case "vendedor":
                        btnUsuarios.Enabled = false;
                        btnMovimientos.Enabled = false;
                       
                       
                        break;

                    case "encargado de inventario":
                    case "encargado inventario":
                        btnUsuarios.Enabled = false;
                        btnFacturacion.Enabled = false;
                        btnMovimientos.Enabled = false;
                       
                        break;

                    case "contador":
                        btnUsuarios.Enabled = false;
                        btnFacturacion.Enabled = false;
                      
                        break;

                    case "administrador":
                       
                        break;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
