using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio3
{
    public partial class Formreceb : Form
    {
        public Formreceb()
        {
            InitializeComponent();
        }

        private void buttonler_Click(object sender, EventArgs e)
        {
            int lidos,numero;          
            lidos = (int)numericUpDownquantos.Value;
            for (int i = 0;i<= lidos;i++)
            {
                numero=// essa é minha duvida como leio do usuário?atraves d NUP ele le apenas um numero e precisa ser os 10 que o usuário informar
                if (numero % 2 == 0)
                {
                    richTextBoxmostra.AppendText("o seguinte numero é par"+numero.ToString());
                    richTextBoxmostra.AppendText(Environment.NewLine);
                }
            }
        }
    }
}
