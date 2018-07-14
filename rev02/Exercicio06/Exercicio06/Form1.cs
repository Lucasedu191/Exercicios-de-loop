using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //colocar um numero e calcular a serie de fibonacci (calcula o proximo somando o anterior
            int quanto;
            int guarda = 1;
            int resultado = 0;
            int mostra;

            quanto = (int)numericUpDown1.Value;

            for (int i = 0; i <= quanto; i++)
            {
                mostra = resultado + guarda;
                resultado = guarda;
                guarda = mostra;
                richTextBox1.AppendText(mostra.ToString());
                richTextBox1.AppendText(Environment.NewLine);
            }
        }
    }
}
