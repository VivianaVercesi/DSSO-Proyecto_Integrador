namespace ProyectoIntegradorForm
{
    partial class frmRegistrarCliente
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDNI = new Label();
            chbSocio = new CheckBox();
            chbAptoFisico = new CheckBox();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(111, 97);
            txtNombre.Margin = new Padding(1, 1, 1, 1);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(131, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Cursor = Cursors.IBeam;
            txtApellido.Location = new Point(111, 175);
            txtApellido.Margin = new Padding(1, 1, 1, 1);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(131, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtDNI
            // 
            txtDNI.Cursor = Cursors.IBeam;
            txtDNI.Location = new Point(111, 261);
            txtDNI.Margin = new Padding(1, 1, 1, 1);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(131, 23);
            txtDNI.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(111, 74);
            lblNombre.Margin = new Padding(1, 0, 1, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(111, 152);
            lblApellido.Margin = new Padding(1, 0, 1, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(111, 238);
            lblDNI.Margin = new Padding(1, 0, 1, 0);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 5;
            lblDNI.Text = "DNI";
            // 
            // chbSocio
            // 
            chbSocio.AutoSize = true;
            chbSocio.Location = new Point(316, 225);
            chbSocio.Margin = new Padding(1, 1, 1, 1);
            chbSocio.Name = "chbSocio";
            chbSocio.Size = new Size(55, 19);
            chbSocio.TabIndex = 6;
            chbSocio.Text = "Socio";
            chbSocio.UseVisualStyleBackColor = true;
            // 
            // chbAptoFisico
            // 
            chbAptoFisico.AutoSize = true;
            chbAptoFisico.Location = new Point(316, 261);
            chbAptoFisico.Margin = new Padding(1, 1, 1, 1);
            chbAptoFisico.Name = "chbAptoFisico";
            chbAptoFisico.Size = new Size(83, 19);
            chbAptoFisico.TabIndex = 7;
            chbAptoFisico.Text = "Apto físico";
            chbAptoFisico.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.ForeColor = SystemColors.HotTrack;
            btnRegistrar.Location = new Point(508, 225);
            btnRegistrar.Margin = new Padding(1, 1, 1, 1);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(167, 56);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // frmRegistrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(840, 377);
            Controls.Add(btnRegistrar);
            Controls.Add(chbAptoFisico);
            Controls.Add(chbSocio);
            Controls.Add(lblDNI);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtDNI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Margin = new Padding(1, 1, 1, 1);
            Name = "frmRegistrarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CLUB DEPORTIVO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDNI;
        private CheckBox chbAptoFisico;
        private Button btnRegistrar;
        private CheckBox chbSocio;
    }
}