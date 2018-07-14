using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_9
{
    public partial class Formexercicio9 : Form
    {
        public Formexercicio9()
        {
            InitializeComponent();
        }

        private void buttonmostrar_Click(object sender, EventArgs e)
        {
            int guarda=0,conta=0;
            for (int i = 500; i >= 20; i = i - 20)
            {   if (guarda < 26)
                {
                    guarda = guarda + 2;
                }
                conta =( i / guarda)+conta;
                

               
                richTextBoxmostrar.AppendText(conta.ToString());
                richTextBoxmostrar.AppendText(Environment.NewLine);

            }
        }
    }
}
