namespace ProyectoIntegradorForm
{
    partial class frmRegistrarPago
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
            lblIdCliente = new Label();
            txtNroId = new TextBox();
            btnPagar = new Button();
            label1 = new Label();
            txtMonto = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Location = new Point(82, 71);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(75, 15);
            lblIdCliente.TabIndex = 4;
            lblIdCliente.Text = "ID de cliente:";
            // 
            // txtNroId
            // 
            txtNroId.Location = new Point(167, 68);
            txtNroId.Margin = new Padding(3, 2, 3, 2);
            txtNroId.Name = "txtNroId";
            txtNroId.Size = new Size(148, 23);
            txtNroId.TabIndex = 0;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(150, 249);
            btnPagar.Margin = new Padding(3, 2, 3, 2);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(124, 52);
            btnPagar.TabIndex = 4;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 107);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 7;
            label1.Text = "Monto:";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(167, 107);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(148, 23);
            txtMonto.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 155);
            label2.Name = "label2";
            label2.Size = new Size(255, 15);
            label2.TabIndex = 9;
            label2.Text = "* Todos los pagos se generan con fecha del día.";
            // 
            // frmRegistrarPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 365);
            Controls.Add(label2);
            Controls.Add(txtMonto);
            Controls.Add(label1);
            Controls.Add(txtNroId);
            Controls.Add(lblIdCliente);
            Controls.Add(btnPagar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmRegistrarPago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrarPago";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPagar;
        private Label lblIdCliente;
        private TextBox txtNroId;
        private Label label1;
        private TextBox txtMonto;
        private Label label2;
    }
}