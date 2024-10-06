namespace ProyectoIntegradorForm.Documentos
{
    partial class frmCarnet
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
            picUsuarioCarnet = new PictureBox();
            lblNombre = new Label();
            lblID = new Label();
            lblSocio = new Label();
            lblDNI = new Label();
            lblTituloDNI = new Label();
            lblTituloID = new Label();
            btnImprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)picUsuarioCarnet).BeginInit();
            SuspendLayout();
            // 
            // picUsuarioCarnet
            // 
            picUsuarioCarnet.BackgroundImage = Recursos.usuariopng;
            picUsuarioCarnet.BackgroundImageLayout = ImageLayout.Stretch;
            picUsuarioCarnet.Location = new Point(49, 48);
            picUsuarioCarnet.Name = "picUsuarioCarnet";
            picUsuarioCarnet.Size = new Size(146, 147);
            picUsuarioCarnet.TabIndex = 0;
            picUsuarioCarnet.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(241, 115);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(156, 47);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblID.Location = new Point(321, 287);
            lblID.Name = "lblID";
            lblID.Size = new Size(40, 32);
            lblID.TabIndex = 2;
            lblID.Text = "ID";
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblSocio.Location = new Point(647, 20);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(0, 30);
            lblSocio.TabIndex = 3;
            lblSocio.UseMnemonic = false;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDNI.Location = new Point(321, 359);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(59, 32);
            lblDNI.TabIndex = 4;
            lblDNI.Text = "DNI";
            // 
            // lblTituloDNI
            // 
            lblTituloDNI.AutoSize = true;
            lblTituloDNI.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloDNI.Location = new Point(241, 354);
            lblTituloDNI.Name = "lblTituloDNI";
            lblTituloDNI.Size = new Size(69, 37);
            lblTituloDNI.TabIndex = 5;
            lblTituloDNI.Text = "DNI:";
            // 
            // lblTituloID
            // 
            lblTituloID.AutoSize = true;
            lblTituloID.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloID.Location = new Point(255, 282);
            lblTituloID.Name = "lblTituloID";
            lblTituloID.Size = new Size(49, 37);
            lblTituloID.TabIndex = 6;
            lblTituloID.Text = "ID:";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(702, 400);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 7;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // frmCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 446);
            Controls.Add(btnImprimir);
            Controls.Add(lblTituloID);
            Controls.Add(lblTituloDNI);
            Controls.Add(lblDNI);
            Controls.Add(lblSocio);
            Controls.Add(lblID);
            Controls.Add(lblNombre);
            Controls.Add(picUsuarioCarnet);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmCarnet";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carnet";
            ((System.ComponentModel.ISupportInitialize)picUsuarioCarnet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picUsuarioCarnet;
        private Label lblNombre;
        private Label lblID;
        private Label lblDNI;
        private Label lblTituloDNI;
        private Label lblTituloID;
        private Label lblSocio;
        private Button btnImprimir;
    }
}