namespace DescuentoPorCompra
{
    public partial class Descuento : Form
    {
        public Descuento()
        {
            InitializeComponent();
            txtDescuento.Enabled = false;
            txtTotal.Enabled = false;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is TextBox)
                    control.Text = "";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            double importe = double.Parse(txtImporte.Text);
            double dcto = 0;

            if (importe > 3000 && importe < 5000)
            {
                dcto = importe * 0.1;
            }

            if (importe >= 5000)
            {
                dcto = importe * 0.2;
            }

            txtDescuento.Text = dcto.ToString();
            txtTotal.Text = (importe - dcto).ToString();
        }

    }
}