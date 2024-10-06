namespace ProyectoIntegradorForm
{
    partial class PantallaPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            imageList1 = new ImageList(components);
            btnInicio = new Button();
            lblClub = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // btnInicio
            // 
            btnInicio.BackgroundImageLayout = ImageLayout.Zoom;
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.FlatStyle = FlatStyle.Popup;
            btnInicio.ForeColor = SystemColors.ActiveCaptionText;
            btnInicio.Location = new Point(425, 394);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(295, 97);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "INICIAR SESIÓN";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click_1;
            // 
            // lblClub
            // 
            lblClub.AutoSize = true;
            lblClub.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblClub.ForeColor = SystemColors.ActiveCaptionText;
            lblClub.ImageAlign = ContentAlignment.TopCenter;
            lblClub.Location = new Point(380, 136);
            lblClub.Name = "lblClub";
            lblClub.Size = new Size(379, 51);
            lblClub.TabIndex = 2;
            lblClub.Text = "\"CLUB DEPORTIVO\"";
            lblClub.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(364, 190);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(411, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // PantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1200, 630);
            Controls.Add(pictureBox1);
            Controls.Add(lblClub);
            Controls.Add(btnInicio);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ForeColor = SystemColors.GradientInactiveCaption;
            Margin = new Padding(4);
            Name = "PantallaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CLUB DEPORTIVO";
            TransparencyKey = Color.SkyBlue;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imageList1;
        private Button btnInicio;
        private Label lblClub;
        private PictureBox pictureBox1;
    }
}