using System;
using System.Windows.Forms;

namespace ConversorMoedas
{
    public partial class frmConversor : Form
    {
        private void frmConversor_Load(object sender, EventArgs e)
        {
            cboMoeadas.Items.Add("Real | Dólar");
            cboMoeadas.Items.Add("Dólar | Real");
            cboMoeadas.Items.Add("Real | Euro");
            cboMoeadas.Items.Add("Euro | Real");
        }

        public frmConversor()
        {
            InitializeComponent();
        }
        
        private void bntCalcular_Click(object sender, EventArgs e)
        {
            var valor = Convert.ToDouble(txtValor.Text);
            var resultado = 0.0; 
            switch (cboMoeadas.SelectedIndex)
            {
                case 0: // Real | Dólar
                    resultado = valor * 3.94;
                    txtResultado.Text = resultado.ToString();
                    break;

                case 1: // Dólar | Real
                    resultado = (valor / 3.94);
                    txtResultado.Text = resultado.ToString();
                    break;

                case 2: // Real | Euro
                    resultado = (valor * 4.42);
                    txtResultado.Text = resultado.ToString();
                    break;

                case 3: // Euro | Real
                    resultado = (valor / 4.42);
                    txtResultado.Text = resultado.ToString();
                    break;
            }
        }

        private void cboMoeadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboMoeadas.SelectedIndex)
            {
                case 0: // Real | Dólar
                    lblValor.Text = "Real";
                    lblResultado.Text = "Dólar";
                    break;

                case 1: // Dólar | Real
                    lblValor.Text = "Dólar";
                    lblResultado.Text = "Reais";
                    break;

                case 2: // Real | Euro
                    lblValor.Text = "Real";
                    lblResultado.Text = "Euro";
                    break;

                case 3: // Euro | Real
                    lblValor.Text = "Euro";
                    lblResultado.Text = "Real";
                    break;
            }

        }
    }
}
