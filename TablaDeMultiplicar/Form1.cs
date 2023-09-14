using System.Text;

namespace TablaDeMultiplicar
{
    public partial class Tabla : Form
    {
        public Tabla()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            lstTabla.Items.Clear();

        }

        private void Tabla_Load(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            lstTabla.Items.Clear();
        }

        private void Calcular()
        {
            int numero;

            if (int.TryParse(txtNumero.Text.Trim(), out numero))
            {
                lstTabla.Items.Clear();

                for (int i = 1; i < 11; i++)
                {
                    int mult = numero * i;
                    lstTabla.Items.Add($"{numero} * {i} = {mult}");
                }
            }

            else
                MessageBox.Show("Ingresa un numero");

 
        }
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                Calcular();
        }

        private void Tabla_FormClosing(object sender, FormClosingEventArgs e)
        {
            string mensaje = "Estas seguro de cerrar el formulario?";
            string titulo = "Atencion";

            var result = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}