namespace ProyectoIntegradorForm
{
    partial class frmMenuAdministrador
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
            btnRegistrarPago = new Button();
            btnObtenerVencimientos = new Button();
            btnRegistrarCliente = new Button();
            SuspendLayout();
            // 
            // btnRegistrarPago
            // 
            btnRegistrarPago.Cursor = Cursors.Hand;
            btnRegistrarPago.Location = new Point(341, 169);
            btnRegistrarPago.Margin = new Padding(2);
            btnRegistrarPago.Name = "btnRegistrarPago";
            btnRegistrarPago.Size = new Size(154, 46);
            btnRegistrarPago.TabIndex = 1;
            btnRegistrarPago.Text = "Registrar pago";
            btnRegistrarPago.UseVisualStyleBackColor = true;
            btnRegistrarPago.Click += btnRegistrarPago_Click;
            // 
            // btnObtenerVencimientos
            // 
            btnObtenerVencimientos.Cursor = Cursors.Hand;
            btnObtenerVencimientos.Location = new Point(341, 258);
            btnObtenerVencimientos.Margin = new Padding(2);
            btnObtenerVencimientos.Name = "btnObtenerVencimientos";
            btnObtenerVencimientos.Size = new Size(154, 46);
            btnObtenerVencimientos.TabIndex = 2;
            btnObtenerVencimientos.Text = "Obtener vencimientos";
            btnObtenerVencimientos.UseVisualStyleBackColor = true;
            btnObtenerVencimientos.Click += btnObtenerVencimientos_Click;
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.Cursor = Cursors.Hand;
            btnRegistrarCliente.Location = new Point(341, 80);
            btnRegistrarCliente.Margin = new Padding(2);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(154, 46);
            btnRegistrarCliente.TabIndex = 0;
            btnRegistrarCliente.Text = "Registrar cliente";
            btnRegistrarCliente.UseVisualStyleBackColor = true;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // frmMenuAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(840, 377);
            Controls.Add(btnRegistrarCliente);
            Controls.Add(btnObtenerVencimientos);
            Controls.Add(btnRegistrarPago);
            ForeColor = SystemColors.HotTrack;
            Margin = new Padding(2);
            Name = "frmMenuAdministrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CLUB DEPORTIVO";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistrarPago;
        private Button btnObtenerVencimientos;
        private Button btnRegistrarCliente;
    }
}