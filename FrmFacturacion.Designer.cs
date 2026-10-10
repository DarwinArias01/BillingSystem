namespace Billing_System
{
    partial class FrmFacturacion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbProducto = new ComboBox();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            txtTotal = new TextBox();
            txtDisponible = new TextBox();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            dataGridView1 = new DataGridView();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(385, 9);
            label1.Name = "label1";
            label1.Size = new Size(302, 41);
            label1.TabIndex = 0;
            label1.Text = "Facturación / Ventas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 91);
            label2.Name = "label2";
            label2.Size = new Size(97, 24);
            label2.TabIndex = 1;
            label2.Text = "Producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 136);
            label3.Name = "label3";
            label3.Size = new Size(99, 24);
            label3.TabIndex = 2;
            label3.Text = "Cantidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 185);
            label4.Name = "label4";
            label4.Size = new Size(72, 24);
            label4.TabIndex = 3;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(88, 284);
            label5.Name = "label5";
            label5.Size = new Size(63, 24);
            label5.TabIndex = 8;
            label5.Text = "Total:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(50, 233);
            label6.Name = "label6";
            label6.Size = new Size(119, 24);
            label6.TabIndex = 6;
            label6.Text = "Disponible:";
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(191, 91);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(192, 28);
            cmbProducto.TabIndex = 4;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(191, 133);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(192, 27);
            txtCantidad.TabIndex = 5;
            txtCantidad.TextChanged += CalcularTotal;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(191, 185);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(192, 27);
            txtPrecio.TabIndex = 6;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(191, 284);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(192, 27);
            txtTotal.TabIndex = 7;
            // 
            // txtDisponible
            // 
            txtDisponible.Location = new Point(191, 233);
            txtDisponible.Name = "txtDisponible";
            txtDisponible.ReadOnly = true;
            txtDisponible.Size = new Size(192, 27);
            txtDisponible.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(778, 64);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(109, 41);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(778, 127);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(109, 41);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 344);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1012, 270);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(120, 40);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "← Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmFacturacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 617);
            Controls.Add(dataGridView1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnVolver);
            Controls.Add(label6);
            Controls.Add(txtDisponible);
            Controls.Add(label5);
            Controls.Add(txtTotal);
            Controls.Add(txtPrecio);
            Controls.Add(txtCantidad);
            Controls.Add(cmbProducto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmFacturacion";
            Text = "Facturacion / Ventas";
            Load += FrmFacturacion_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbProducto;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private TextBox txtTotal;
        private TextBox txtDisponible;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Button btnVolver;
        private DataGridView dataGridView1;
    }
}
