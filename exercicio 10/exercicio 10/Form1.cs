using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_10
{
    public partial class Formexercicio10 : Form
    {
        public Formexercicio10()
        {
            InitializeComponent();
        }

        private void buttoncalcula_Click(object sender, EventArgs e)
        {
            int primo,contador=0;
            primo = (int)numericUpDownprimo.Value;

            for (int i = primo; i >= 1; i--)
            {
                if (primo % i == 0)
                {
                    contador = contador + 1;
                }

            }
            if (contador == 2)
            {
                MessageBox.Show("o numero : " + primo.ToString() + " é primo");
            }
            else {
                MessageBox.Show("o numero : " + primo.ToString() + " não é primo");
            }


        }
    }
}
