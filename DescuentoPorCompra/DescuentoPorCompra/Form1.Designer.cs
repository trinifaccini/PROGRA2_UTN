namespace DescuentoPorCompra
{
    partial class Descuento
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
            groupBox1 = new GroupBox();
            txtTotal = new TextBox();
            txtDescuento = new TextBox();
            txtImporte = new TextBox();
            lblTotal = new Label();
            lblDescuento = new Label();
            lblImporte = new Label();
            btnAceptar = new Button();
            btnLimpiar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(txtDescuento);
            groupBox1.Controls.Add(txtImporte);
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Controls.Add(lblDescuento);
            groupBox1.Controls.Add(lblImporte);
            groupBox1.Location = new Point(251, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(298, 190);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(192, 141);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 5;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(192, 95);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 4;
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(192, 40);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(100, 23);
            txtImporte.TabIndex = 3;
            txtImporte.Text = "5";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(6, 144);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(77, 15);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total a pagar";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(6, 98);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(109, 15);
            lblDescuento.TabIndex = 1;
            lblDescuento.Text = "Descuento recibido";
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblImporte.Location = new Point(6, 43);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(145, 15);
            lblImporte.TabIndex = 0;
            lblImporte.Text = "Ingrese importe a cobrar";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(301, 321);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(423, 321);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Descuento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAceptar);
            Controls.Add(groupBox1);
            Name = "Descuento";
            Text = "Descuento";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDescuento;
        private TextBox txtImporte;
        private Label lblTotal;
        private Label lblDescuento;
        private Label lblImporte;
        private TextBox txtTotal;
        private Button btnAceptar;
        private Button btnLimpiar;
    }
}