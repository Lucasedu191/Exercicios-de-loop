using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio14
{
    public partial class Formexercicio14 : Form
    {
        public Formexercicio14()
        {
            InitializeComponent();
        }

        private void buttonpirame_Click(object sender, EventArgs e)
        {
            int quanto;
            string aste="";
            quanto = (int)numericUpDownquanto.Value;
            for (int i = 1; i <= quanto; i++)
            {
                aste = aste + "*";
                richTextBoxmostra.AppendText(aste.ToString());
                richTextBoxmostra.AppendText(Environment.NewLine);

            }
        }
    }
}
