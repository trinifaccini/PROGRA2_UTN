namespace ContarPalabras
{
    partial class ContadorPalabras
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
            btnCalcular = new Button();
            richTxtPalabras = new RichTextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(574, 278);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(103, 38);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // richTxtPalabras
            // 
            richTxtPalabras.Location = new Point(12, 12);
            richTxtPalabras.Name = "richTxtPalabras";
            richTxtPalabras.Size = new Size(665, 260);
            richTxtPalabras.TabIndex = 1;
            richTxtPalabras.Text = "";
            // 
            // ContadorPalabras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 328);
            Controls.Add(richTxtPalabras);
            Controls.Add(btnCalcular);
            Name = "ContadorPalabras";
            Text = "Contador de Palabras";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCalcular;
        private RichTextBox richTxtPalabras;
    }
}