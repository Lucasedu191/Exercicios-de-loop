using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_6
{
    public partial class Formexercicio6 : Form
    {
        public Formexercicio6()
        {
            InitializeComponent();
        }

        private void buttoncalcular_Click(object sender, EventArgs e)
        {
            int quanto,guarda=1,resultado=0,mostra;
            
            quanto = (int)numericUpDownquanto.Value;

            for (int i = 0; i <= quanto; i++)
            {

                
                mostra = resultado+guarda;
                resultado =guarda ;
                guarda = mostra;
                

                richTextBoxmostra.AppendText(mostra.ToString());
                richTextBoxmostra.AppendText(Environment.NewLine);


            }
        }
    }
}
