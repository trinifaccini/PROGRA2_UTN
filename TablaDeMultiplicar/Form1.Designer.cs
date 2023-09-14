namespace TablaDeMultiplicar
{
    partial class Tabla
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
            txtNumero = new TextBox();
            lstTabla = new ListBox();
            lblNumero = new Label();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(428, 65);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(50, 23);
            txtNumero.TabIndex = 1;
            txtNumero.Text = "15";
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // lstTabla
            // 
            lstTabla.FormattingEnabled = true;
            lstTabla.ItemHeight = 15;
            lstTabla.Location = new Point(318, 103);
            lstTabla.Name = "lstTabla";
            lstTabla.Size = new Size(160, 199);
            lstTabla.TabIndex = 2;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(318, 68);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(113, 15);
            lblNumero.TabIndex = 3;
            lblNumero.Text = "Ingrese un número: ";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(361, 332);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Tabla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(lblNumero);
            Controls.Add(lstTabla);
            Controls.Add(txtNumero);
            Name = "Tabla";
            Text = "Form1";
            FormClosing += Tabla_FormClosing;
            Load += Tabla_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private ListBox lstTabla;
        private Label lblNumero;
        private Button btnLimpiar;
    }
}