namespace OrdenarNumeros
{
    partial class Form1
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
            grpNum = new GroupBox();
            btnAgregar = new Button();
            txtNum = new TextBox();
            grpOrden = new GroupBox();
            btnOrdenar = new Button();
            btnDescendente = new RadioButton();
            btnAscendente = new RadioButton();
            grpLista = new GroupBox();
            lstNum = new ListBox();
            btnLimpiar = new Button();
            grpNum.SuspendLayout();
            grpOrden.SuspendLayout();
            grpLista.SuspendLayout();
            SuspendLayout();
            // 
            // grpNum
            // 
            grpNum.Controls.Add(btnAgregar);
            grpNum.Controls.Add(txtNum);
            grpNum.Location = new Point(31, 34);
            grpNum.Name = "grpNum";
            grpNum.Size = new Size(234, 79);
            grpNum.TabIndex = 0;
            grpNum.TabStop = false;
            grpNum.Text = "Ingrese un nuevo número";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(153, 35);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(6, 35);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 0;
            txtNum.Text = "15";
            // 
            // grpOrden
            // 
            grpOrden.Controls.Add(btnOrdenar);
            grpOrden.Controls.Add(btnDescendente);
            grpOrden.Controls.Add(btnAscendente);
            grpOrden.Location = new Point(31, 131);
            grpOrden.Name = "grpOrden";
            grpOrden.Size = new Size(234, 111);
            grpOrden.TabIndex = 1;
            grpOrden.TabStop = false;
            grpOrden.Text = "Orden";
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(153, 46);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(75, 23);
            btnOrdenar.TabIndex = 2;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnDescendente
            // 
            btnDescendente.AutoSize = true;
            btnDescendente.Location = new Point(12, 75);
            btnDescendente.Name = "btnDescendente";
            btnDescendente.Size = new Size(93, 19);
            btnDescendente.TabIndex = 1;
            btnDescendente.TabStop = true;
            btnDescendente.Text = "Descendente";
            btnDescendente.UseVisualStyleBackColor = true;
            // 
            // btnAscendente
            // 
            btnAscendente.AutoSize = true;
            btnAscendente.Location = new Point(12, 32);
            btnAscendente.Name = "btnAscendente";
            btnAscendente.Size = new Size(87, 19);
            btnAscendente.TabIndex = 0;
            btnAscendente.TabStop = true;
            btnAscendente.Text = "Ascendente";
            btnAscendente.UseVisualStyleBackColor = true;
            // 
            // grpLista
            // 
            grpLista.Controls.Add(lstNum);
            grpLista.Location = new Point(293, 34);
            grpLista.Name = "grpLista";
            grpLista.Size = new Size(215, 254);
            grpLista.TabIndex = 2;
            grpLista.TabStop = false;
            grpLista.Text = "Lista de números";
            // 
            // lstNum
            // 
            lstNum.FormattingEnabled = true;
            lstNum.ItemHeight = 15;
            lstNum.Location = new Point(12, 32);
            lstNum.Name = "lstNum";
            lstNum.Size = new Size(185, 199);
            lstNum.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(31, 257);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(234, 31);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(grpLista);
            Controls.Add(grpOrden);
            Controls.Add(grpNum);
            Name = "Form1";
            Text = "Form1";
            grpNum.ResumeLayout(false);
            grpNum.PerformLayout();
            grpOrden.ResumeLayout(false);
            grpOrden.PerformLayout();
            grpLista.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpNum;
        private GroupBox grpOrden;
        private GroupBox grpLista;
        private Button btnAgregar;
        private TextBox txtNum;
        private RadioButton btnDescendente;
        private RadioButton btnAscendente;
        private Button btnOrdenar;
        private Button btnLimpiar;
        private ListBox lstNum;
    }
}