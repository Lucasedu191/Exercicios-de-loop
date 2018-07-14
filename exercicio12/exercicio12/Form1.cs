using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttoncalcula_Click(object sender, EventArgs e)
        {
            float quantidade,guarda=0;
            quantidade = (int)numericUpDownguardaN.Value;
            for (int i = 1; i <= quantidade; i++)
            {
                guarda = (quantidade / (quantidade + 1))+guarda;

                richTextBoxmostra.AppendText(guarda.ToString());
                richTextBoxmostra.AppendText(Environment.NewLine);
            }


        }
            
    }
}
