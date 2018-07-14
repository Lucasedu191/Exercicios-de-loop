using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //calcular o somatorio das fracoes
            int guarda = 0;
            int conta = 0;

            for ( int i = 500; i >= 20; i = i - 20)
            {
                if (guarda <26)
                {
                    guarda = guarda + 2;
                }
                conta = (i / guarda) + conta;
                richTextBox1.AppendText(conta.ToString());
                richTextBox1.AppendText(Environment.NewLine);
            }
        }
    }
}
