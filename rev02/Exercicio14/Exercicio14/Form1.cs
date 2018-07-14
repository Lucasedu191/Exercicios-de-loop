using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //colocar asteriscos aumentando 
            int quanto;
            string aste = "";
            quanto = (int)numericUpDown1.Value;
            for (int i = 1; i <= quanto; i++)
            {
                aste = aste + "*";
                richTextBox1.AppendText(aste.ToString());
                richTextBox1.AppendText(Environment.NewLine);
            }
        }
    }
}
