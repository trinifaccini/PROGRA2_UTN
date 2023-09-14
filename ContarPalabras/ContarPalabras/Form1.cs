using System.Text;

namespace ContarPalabras
{
    public partial class ContadorPalabras : Form
    {
        public ContadorPalabras()
        {
            InitializeComponent();
        }

        private void RecorrerRichTextBox()
        {
            string texto = richTxtPalabras.Text;

            Dictionary<string, int> dic = new Dictionary<string, int>();


            string[] palabras = texto.Split(' ', ',', '.', ':', '\t','\n');
            
            foreach (string palabra in palabras)
            {
                if(palabra.Trim().Length > 0)
                {
                    if (!dic.ContainsKey(palabra.Trim()))
                        dic.Add(palabra, 1);

                    else dic[palabra] += 1;
                }
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 3; i++)
            {
                if (dic.Count > 0)
                {
                    int maxAparicion = dic.OrderByDescending(x => x.Value).First().Value;
                    string maxAparicionKey = dic.OrderByDescending(x => x.Value).First().Key;

                    dic.Remove(maxAparicionKey);

                    sb.AppendLine($"{maxAparicionKey}: {maxAparicion}");
                }
            }
               
            MessageBox.Show(sb.ToString());
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            RecorrerRichTextBox();
        }
    }
}