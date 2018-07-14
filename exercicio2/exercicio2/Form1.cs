using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio2
{
    public partial class Formpotencia : Form
    {
        public Formpotencia()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttoncalcular_Click(object sender, EventArgs e)
        {
            int um,expoente,calcula;
            um = (int)numericUpDownbase.Value;
            calcula = um;
            expoente = (int)numericUpDownexpoente.Value;
            for (int i = 2; i <= expoente; i++)
            {
                um = um * calcula;
                 richTextBoxmostra.AppendText(um.ToString());
                 richTextBoxmostra.AppendText(Environment.NewLine);
            }
            labelmostra.Text=um.ToString();

        }
    }
}
