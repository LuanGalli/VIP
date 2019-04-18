using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            var peso = double.Parse(txtPseso.Text);
            var altura = double.Parse(txtAltura.Text) / 100;

            
            double imc = peso / (altura * altura);
            MessageBox.Show(imc.ToString());
            if (imc < 18.6)
            {
                MessageBox.Show("Abaixo do Peso", imc.ToString());
            }
            else if (imc >= 18.6 && imc < 24.9)
            {
                MessageBox.Show("Peso Ideal", imc.ToString());
            }
            else if (imc >= 24.9 && imc < 29.9)
            {
                MessageBox.Show("Levemente Acima do Peso", imc.ToString());
            }
            else if (imc >= 29.9 && imc < 34.9)
            {
                MessageBox.Show("Obesidade Grau I", imc.ToString());
            }
            else if (imc >= 34.9 && imc < 39.9)
            {
                MessageBox.Show("Obesidade Grau II", imc.ToString());
            }
            else if (imc >= 40)
            {
                MessageBox.Show("Obesidade Grau III", imc.ToString());
            }
            
        }
    }
}
