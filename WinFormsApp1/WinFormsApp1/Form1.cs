namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola windows form");

            string nombre = this.txtName.Text;
            MessageBox.Show("Hola " + nombre + " bienvenido al formulario");

            this.Text = nombre;
            this.BackColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "BIENVENIDO";

        }
    }
}