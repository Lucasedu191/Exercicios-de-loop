using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio17
{
    public partial class Formexercicio17 : Form
    {
        public Formexercicio17()
        {
            InitializeComponent();
        }

        private void buttoncalcula_Click(object sender, EventArgs e)
        {
            int quanto,bandeira =0;
            string guarda = "",espaco="";
            
            quanto = (int)numericUpDownquanto.Value;
            for (int i = 1; i <= quanto; i++)
            {

                for (int z = quanto; z >= i; z--)
                {
                    espaco = espaco + " ";

                }

                for (int x =1 ; x <= i; x++)
                    {

                  //  bandeira = bandeira + 1;
                  //  guarda = guarda + " " + bandeira;

                    guarda =guarda +" "+"*"; //o exercicios  do asteriscos

                }
                guarda = espaco + guarda ;
                richTextBoxmostra.AppendText(guarda.ToString());
                    richTextBoxmostra.AppendText(Environment.NewLine);
                    guarda = "";
                    espaco = "";
                

            }
            



        }
    }
}
