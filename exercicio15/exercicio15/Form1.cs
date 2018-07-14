using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio15
{
    public partial class Formexercicio14 : Form
    {
        public Formexercicio14()
        {
            InitializeComponent();
        }

        private void buttonmostrar_Click(object sender, EventArgs e)
        {
            int quanto;
            string guarda="";
            quanto = (int)numericUpDownquanto.Value;
            for (int i = 1; i <= quanto; i++)
            {
                 
                guarda=guarda+ Convert.ToString(i);
                i = Convert.ToInt16(i);
                richTextBoxmostra.AppendText (guarda.ToString());
                richTextBoxmostra.AppendText(Environment.NewLine);
            }
        }
    }
}
