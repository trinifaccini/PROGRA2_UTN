namespace WinFormsApp1
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
            btnSaludar = new Button();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // btnSaludar
            // 
            btnSaludar.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaludar.Location = new Point(257, 156);
            btnSaludar.Margin = new Padding(2, 1, 2, 1);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(81, 113);
            btnSaludar.TabIndex = 0;
            btnSaludar.Text = "SALUDAR";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(177, 67);
            txtName.Name = "txtName";
            txtName.Size = new Size(240, 23);
            txtName.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 339);
            Controls.Add(txtName);
            Controls.Add(btnSaludar);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaludar;
        private TextBox txtName;
    }
}