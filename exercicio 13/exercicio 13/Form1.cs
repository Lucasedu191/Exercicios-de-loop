using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_13
{
    public partial class Form1 : Form

    
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonmostrar_Click(object sender, EventArgs e)
        {
           double cima=1, baixo=1,termos,progressao=3;
            double conta=0;
            termos = (int)numericUpDowntermos.Value;
            for (int i = 1; i <= termos; i++)
            {
                cima = cima + 1;
                if (i == 1)
                {
                    baixo = 1;
                }
                else
                {
                    baixo = baixo + progressao;
                }
                conta = (cima / baixo) + conta;
                if (i != 1)
                {
                    progressao = progressao + 2;
                }
            }
          
            labelmostraresul.Text = conta.ToString("n3");
        }
    }
}
