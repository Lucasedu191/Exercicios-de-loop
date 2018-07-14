using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //calcular o somatorio da serie informado pelo o usuario s=2/1...
            double cima = 1, baixo = 1, termos, progressao = 3;
            double conta = 0;
            termos = (int)numericUpDown1.Value;

            for ( int i = 1; i <= termos; i++)
            {
                cima = cima + 1;
                if ( i == 1)
                {
                    baixo = 1;
                }
                else
                {
                    baixo = baixo + progressao;
                }

                conta = (cima / baixo) + conta;
                if ( i !=1)
                {
                    progressao = progressao + 2;
                }
                label1.Text = conta.ToString("n3");
            }
        }
    }
}
