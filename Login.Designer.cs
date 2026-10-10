namespace Billing_System
{
    partial class Login
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
            btnaceptar = new Button();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtContra = new TextBox();
            label1 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(btnaceptar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(txtContra);
            panel1.Location = new Point(159, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(516, 235);
            panel1.TabIndex = 1;
            // 
            // btnaceptar
            // 
            btnaceptar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnaceptar.Location = new Point(370, 189);
            btnaceptar.Name = "btnaceptar";
            btnaceptar.Size = new Size(94, 32);
            btnaceptar.TabIndex = 6;
            btnaceptar.Text = "Aceptar";
            btnaceptar.UseVisualStyleBackColor = true;
            btnaceptar.Click += btnaceptar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 139);
            label5.Name = "label5";
            label5.Size = new Size(119, 22);
            label5.TabIndex = 5;
            label5.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 90);
            label4.Name = "label4";
            label4.Size = new Size(85, 22);
            label4.TabIndex = 4;
            label4.Text = "Usuario:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(516, 57);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(178, 17);
            label2.Name = "label2";
            label2.Size = new Size(172, 22);
            label2.TabIndex = 0;
            label2.Text = "Control de acceso";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(190, 85);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(307, 27);
            txtUsuario.TabIndex = 2;
            // 
            // txtContra
            // 
            txtContra.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtContra.Location = new Point(190, 139);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(307, 27);
            txtContra.TabIndex = 3;
            txtContra.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(362, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 4;
            label1.Text = "Sistema";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(337, 37);
            label3.Name = "label3";
            label3.Size = new Size(150, 28);
            label3.TabIndex = 5;
            label3.Text = "de facturación";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtContra;
        private Label label1;
        private Label label3;
        private Button btnaceptar;
        private Label label5;
        private Label label4;
    }
}