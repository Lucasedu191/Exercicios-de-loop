using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //criar a formula delta Σ n 1 N * 1/n+1
            float quantidade;
            float guarda = 0;

            quantidade = (int)numericUpDown1.Value;
            for (int i = 1; i <=quantidade; i++)
            {
                guarda = (quantidade / (quantidade + 1)) + guarda;

                richTextBox1.AppendText(guarda.ToString());
                richTextBox1.AppendText(Environment.NewLine);
            }
        }
    }
}
