namespace ProyectoIntegradorForm.Documentos
{
    partial class frmComprobanteDePago
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
            lblIDComprobante = new Label();
            lblValorFecha = new Label();
            lblIDCliente = new Label();
            lblTipo = new Label();
            lblNombre = new Label();
            lblDNI = new Label();
            label1 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            panel1 = new Panel();
            panel2 = new Panel();
            lblValorMonto = new Label();
            lblValorTipo = new Label();
            lblValorDNI = new Label();
            lblValorNombre = new Label();
            lblValorIdCliente = new Label();
            lblValorIdPago = new Label();
            btnImprimir = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblIDComprobante
            // 
            lblIDComprobante.AutoSize = true;
            lblIDComprobante.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblIDComprobante.Location = new Point(10, 7);
            lblIDComprobante.Name = "lblIDComprobante";
            lblIDComprobante.Size = new Size(196, 32);
            lblIDComprobante.TabIndex = 0;
            lblIDComprobante.Text = "Comprobante Nº";
            lblIDComprobante.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValorFecha
            // 
            lblValorFecha.AutoSize = true;
            lblValorFecha.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorFecha.Location = new Point(533, 7);
            lblValorFecha.Name = "lblValorFecha";
            lblValorFecha.Size = new Size(155, 32);
            lblValorFecha.TabIndex = 1;
            lblValorFecha.Text = "lblValorFecha";
            lblValorFecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIDCliente
            // 
            lblIDCliente.AutoSize = true;
            lblIDCliente.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblIDCliente.Location = new Point(59, 6);
            lblIDCliente.Name = "lblIDCliente";
            lblIDCliente.Size = new Size(166, 32);
            lblIDCliente.TabIndex = 2;
            lblIDCliente.Text = "Nº de cliente :";
            lblIDCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipo.Location = new Point(59, 131);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(168, 32);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "Tipo de pago :";
            lblTipo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(3, 48);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(222, 32);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre completo :";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDNI.Location = new Point(158, 90);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(67, 32);
            lblDNI.TabIndex = 5;
            lblDNI.Text = "DNI :";
            lblDNI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(127, 172);
            label1.Name = "label1";
            label1.Size = new Size(98, 32);
            label1.TabIndex = 6;
            label1.Text = "Monto :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblIDCliente);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTipo);
            panel1.Controls.Add(lblDNI);
            panel1.Controls.Add(lblNombre);
            panel1.Location = new Point(27, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 210);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblValorMonto);
            panel2.Controls.Add(lblValorTipo);
            panel2.Controls.Add(lblValorDNI);
            panel2.Controls.Add(lblValorNombre);
            panel2.Controls.Add(lblValorIdCliente);
            panel2.Location = new Point(265, 81);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(353, 210);
            panel2.TabIndex = 8;
            // 
            // lblValorMonto
            // 
            lblValorMonto.AutoSize = true;
            lblValorMonto.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorMonto.Location = new Point(7, 172);
            lblValorMonto.Name = "lblValorMonto";
            lblValorMonto.Size = new Size(165, 32);
            lblValorMonto.TabIndex = 6;
            lblValorMonto.Text = "lblValorMonto";
            lblValorMonto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValorTipo
            // 
            lblValorTipo.AutoSize = true;
            lblValorTipo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorTipo.Location = new Point(7, 131);
            lblValorTipo.Name = "lblValorTipo";
            lblValorTipo.Size = new Size(140, 32);
            lblValorTipo.TabIndex = 5;
            lblValorTipo.Text = "lblValorTipo";
            lblValorTipo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValorDNI
            // 
            lblValorDNI.AutoSize = true;
            lblValorDNI.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorDNI.Location = new Point(7, 90);
            lblValorDNI.Name = "lblValorDNI";
            lblValorDNI.Size = new Size(134, 32);
            lblValorDNI.TabIndex = 4;
            lblValorDNI.Text = "lblValorDNI";
            lblValorDNI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValorNombre
            // 
            lblValorNombre.AutoSize = true;
            lblValorNombre.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorNombre.Location = new Point(7, 48);
            lblValorNombre.Name = "lblValorNombre";
            lblValorNombre.Size = new Size(181, 32);
            lblValorNombre.TabIndex = 3;
            lblValorNombre.Text = "lblValorNombre";
            lblValorNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValorIdCliente
            // 
            lblValorIdCliente.AutoSize = true;
            lblValorIdCliente.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorIdCliente.Location = new Point(7, 6);
            lblValorIdCliente.Name = "lblValorIdCliente";
            lblValorIdCliente.Size = new Size(188, 32);
            lblValorIdCliente.TabIndex = 2;
            lblValorIdCliente.Text = "lblValorIdCliente";
            lblValorIdCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValorIdPago
            // 
            lblValorIdPago.AutoSize = true;
            lblValorIdPago.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorIdPago.Location = new Point(210, 9);
            lblValorIdPago.Name = "lblValorIdPago";
            lblValorIdPago.Size = new Size(165, 32);
            lblValorIdPago.TabIndex = 9;
            lblValorIdPago.Text = "lblValorIdPago";
            lblValorIdPago.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(613, 303);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 10;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // frmComprobanteDePago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnImprimir);
            Controls.Add(lblValorIdPago);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblValorFecha);
            Controls.Add(lblIDComprobante);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmComprobanteDePago";
            Text = "Comprobante De Pago";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIDComprobante;
        private Label lblValorFecha;
        private Label lblIDCliente;
        private Label lblTipo;
        private Label lblNombre;
        private Label lblDNI;
        private Label label1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Panel panel1;
        private Panel panel2;
        private Label lblValorIdCliente;
        private Label lblValorMonto;
        private Label lblValorTipo;
        private Label lblValorDNI;
        private Label lblValorNombre;
        private Label lblValorIdPago;
        private Button btnImprimir;
    }
}