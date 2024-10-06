namespace ProyectoIntegradorForm
{
    partial class frmInicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            btnIngresar = new Button();
            labelCredenciales = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.Location = new Point(440, 137);
            txtUsuario.Margin = new Padding(5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(279, 29);
            txtUsuario.TabIndex = 0;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtClave
            // 
            txtClave.Cursor = Cursors.IBeam;
            txtClave.Location = new Point(440, 234);
            txtClave.Margin = new Padding(5);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.PlaceholderText = "Contraseña";
            txtClave.Size = new Size(279, 29);
            txtClave.TabIndex = 1;
            txtClave.TextAlign = HorizontalAlignment.Center;
            txtClave.Enter += txtPass_Enter;
            txtClave.Leave += txtPass_Leave;
            // 
            // btnIngresar
            // 
            btnIngresar.AutoSize = true;
            btnIngresar.BackgroundImageLayout = ImageLayout.Zoom;
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.Location = new Point(440, 342);
            btnIngresar.Margin = new Padding(5);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(279, 66);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // labelCredenciales
            // 
            labelCredenciales.AutoSize = true;
            labelCredenciales.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelCredenciales.ForeColor = SystemColors.InactiveBorder;
            labelCredenciales.Location = new Point(3, 2);
            labelCredenciales.Name = "labelCredenciales";
            labelCredenciales.Size = new Size(253, 30);
            labelCredenciales.TabIndex = 3;
            labelCredenciales.Text = "Credenciales de Pueba:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.InactiveBorder;
            label1.Location = new Point(29, 39);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 4;
            label1.Text = "Usuario : adm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.InactiveBorder;
            label2.Location = new Point(29, 69);
            label2.Name = "label2";
            label2.Size = new Size(194, 30);
            label2.TabIndex = 5;
            label2.Text = "Contraseña: 1234";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelCredenciales);
            panel1.ForeColor = SystemColors.InactiveCaption;
            panel1.Location = new Point(790, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 143);
            panel1.TabIndex = 6;
            // 
            // frmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1200, 629);
            Controls.Add(panel1);
            Controls.Add(btnIngresar);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.HotTrack;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(5);
            Name = "frmInicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CLUB DEPORTIVO";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtPass;
        private Button btnIngresar;
        private TextBox txtClave;
        private Label labelCredenciales;
        private Label label1;
        private Label label2;
        private Panel panel1;
    }
}