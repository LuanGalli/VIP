using System;
using System.Windows.Forms;

namespace ValidadorCPF
{
    public partial class cpf : Form
    {
        public cpf()
        {
            InitializeComponent();
        }

        public void btnCalcular_Click(object sender, EventArgs e)
        {
            validarCPF(txtCPF.Text);
        }

        public void validarCPF(string cpf)
        {
            if (cpf.Length != 11)
            {
                MessageBox.Show("Informe um CPF com 11 caracteres");
                return;
            }

            var sum = 0;
            var multiplier = 10;
            for (var counter = 0; counter < 9; counter++)
            {
                var number = int.Parse(cpf.Substring(counter, 1)) * multiplier;
                sum = sum + number;
                multiplier--;
            }
            var division = sum % 11;
            var digit = 11 - division;
            if (digit > 9)
                digit = 0;

            sum = 0;
            multiplier = 11;
            for (var counter = 0; counter < 10; counter++)
            {
                var number = int.Parse(cpf.Substring(counter, 1)) * multiplier;
                sum = sum + number;
                multiplier--;
            }
            division = sum % 11;
            var digit2 = 11 - division;
            if (digit2 > 9)
                digit2 = 0;

            if (digit == int.Parse(cpf.Substring(9, 1)) && digit2 == int.Parse(cpf.Substring(10, 1)))
                MessageBox.Show("CPF Válido!!");
            else
                MessageBox.Show("CPF Inválido!! :( ");
        }

    }
    
}