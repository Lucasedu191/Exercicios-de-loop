using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // numeros primos ou nao
            int primo, contador = 0;
            primo = (int)numericUpDown1.Value;

            for ( int i = primo; i >= 1; i--)
            {
                if ( primo % i == 0)
                {
                    contador = contador + 1; 
                }
            }
            if (contador == 2)
            {
                MessageBox.Show(" O NUMERO : " + primo.ToString() + " é primo");
            }
            else
            {
                MessageBox.Show(" O NUMERO : " + primo.ToString() + " nao é primo");
            }
        }
    }
}
