namespace OrdenarNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNum.Text);
            lstNum.Items.Add(num);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {

            if (btnAscendente.Checked)
            {
                lstNum.Sorted = true;
            }
        }
    }
}