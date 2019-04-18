using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidadorCPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cpf = textBox1.Text;

            var soma = 0;
            var mult1 = 10;
            var cont1 = 0;
            var n = 0;
            for (int i = 0; i < 9; i++)
            {
                n = int.Parse(cpf.Substring(cont1, 1)) * mult1;
                soma = soma + n;
                mult1--;
                cont1++;
            }

            var divisao1 = soma % 11;
            var digito = 11 - divisao1;

            if (digito > 9)
                digito = 0;

            var soma2 = 0;
            var mult2 = 11;
            var cont2 = 0;
            var l2 = 0;
            for (int i = 0; i < 9; i++)
            {
                l2 = int.Parse(cpf.Substring(cont2, 1)) * mult2;
                soma2 = soma2 + l2;
                mult2--;
                cont2++;
            }
           
            var n10 = digito * 2;
            soma2 = soma2 + n10;
            

            var divisao2 = soma2 % 11;
            var digito2 = 11 - divisao2;

            if (digito2 > 9)
                digito2 = 0;

            if (digito == int.Parse(cpf.Substring(9, 1)) && digito2 == int.Parse(cpf.Substring(10, 1)))
                MessageBox.Show("CPF Valido!!");
            else
                MessageBox.Show("CPF Invalido!!");
            


        }
    }
}
