using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = (int)numericUpDown1.Value;
            for (int i = 1; i <= numero; i+=2)
            {
                richTextBox1.AppendText(numero.ToString());
            }
        }
    }
}
