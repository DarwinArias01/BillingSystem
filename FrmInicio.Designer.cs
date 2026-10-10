namespace Billing_System
{
    partial class FrmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnMovimientos = new Button();
            btnCerrarSesion = new Button();
            btnFacturacion = new Button();
            btnInventario = new Button();
            btnUsuarios = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(btnMovimientos);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Controls.Add(btnFacturacion);
            panel1.Controls.Add(btnInventario);
            panel1.Controls.Add(btnUsuarios);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(70, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 330);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnMovimientos
            // 
            btnMovimientos.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMovimientos.Location = new Point(14, 137);
            btnMovimientos.Name = "btnMovimientos";
            btnMovimientos.Size = new Size(170, 45);
            btnMovimientos.TabIndex = 7;
            btnMovimientos.Text = "Movimientos";
            btnMovimientos.UseVisualStyleBackColor = true;
            btnMovimientos.Click += btnMovimientos_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = SystemColors.ButtonShadow;
            btnCerrarSesion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.Location = new Point(475, 269);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(170, 45);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnFacturacion
            // 
            btnFacturacion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFacturacion.Location = new Point(14, 269);
            btnFacturacion.Name = "btnFacturacion";
            btnFacturacion.Size = new Size(170, 45);
            btnFacturacion.TabIndex = 4;
            btnFacturacion.Text = "Facturación / Ventas";
            btnFacturacion.UseVisualStyleBackColor = true;
            btnFacturacion.Click += btnFacturacion_Click;
            // 
            // btnInventario
            // 
            btnInventario.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventario.Location = new Point(14, 205);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(170, 45);
            btnInventario.TabIndex = 2;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.Location = new Point(14, 73);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(170, 45);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(660, 57);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(250, 17);
            label2.Name = "label2";
            label2.Size = new Size(220, 22);
            label2.TabIndex = 0;
            label2.Text = "Sistema de Facturación";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(323, 20);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 0;
            label1.Text = "Panel de Inicio";
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FrmInicio";
            Text = "Inicio";
            Load += FrmMenu_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Button btnUsuarios;
        private Button btnInventario;
        private Button btnFacturacion;
        private Button btnCerrarSesion;
        private Button btnMovimientos;
    }
}
