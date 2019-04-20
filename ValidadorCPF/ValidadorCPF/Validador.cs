using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidadorCPF
{
    public partial class frmValidadorCPF : Form
    {
        public frmValidadorCPF()
        {
            InitializeComponent();
        }
        
        public void button1_Click(object sender, EventArgs e)
        {
            string cpf = txtCPF.Text;
            int amountCharacterCPF = cpf.Length;

            if (amountCharacterCPF == 11)
            {
                var sum = 0;
                var multiplier = 10;

                for (int counter = 0; counter < 9; counter++)
                {
                    int number = int.Parse(cpf.Substring(counter, 1)) * multiplier;
                    sum = sum + number;
                    multiplier--;

                }

                var division1 = sum % 11;
                var digit = 11 - division1;

                if (digit > 9)
                    digit = 0;

                var sum2 = 0;
                multiplier = 11;
                for (int counter = 0; counter < 9; counter++)
                {
                    int number = int.Parse(cpf.Substring(counter, 1)) * multiplier;
                    sum2 = sum2 + number;
                    multiplier--;
                }

                var numero10 = digit * 2;
                sum2 = sum2 + numero10;

                var division2 = sum2 % 11;
                var digit2 = 11 - division2;

                if (digit2 > 9)
                    digit2 = 0;

                if (digit == int.Parse(cpf.Substring(9, 1)) && digit2 == int.Parse(cpf.Substring(10, 1)))
                    MessageBox.Show("CPF Valido!!");
                else
                    MessageBox.Show("CPF Invalido!!");

            }
            else
            {
                MessageBox.Show("Informe um CPF com 11 caracteres");
            }
        }
    }
}
