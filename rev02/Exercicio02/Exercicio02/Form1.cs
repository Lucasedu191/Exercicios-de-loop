using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //somar os dez primeiros numeros naturais

            int soma = 0;

            for (int numero = 0; numero <= 10; numero++)
            {
                soma = soma + numero;
                richTextBox1.AppendText(" o resultado é: " + soma.ToString());
                richTextBox1.AppendText(Environment.NewLine);
            }
        }
    }
}
