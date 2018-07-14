using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //limpa 
            richTextBox1.Clear();
            //contador de repetição
            //i++ é a mesma coisa que i=i+1 (operadores unarios
            for (int i = 1; i <= 10; i++)
            {

                richTextBox1.AppendText (i.ToString());
                richTextBox1.AppendText(Environment.NewLine);

            }
            //loop
            //laço de repetição: para : for, enquanto: whiile, repita :
        }
    }
}
