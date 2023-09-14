namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            lblSaludo.Text = "¡¡¡Hola mundo WinForm!!!";
            this.lblSaludo.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSaludo.Visible = false;
            Text = "Saludo desde un Form";
        }
    }
}