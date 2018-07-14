using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //aparecer cascata de numeros, na linha seguinte volta ao começo 123, 1234
            int quanto;
            string guarda = "";
            quanto = (int)numericUpDown1.Value;

            for (int i = 1; i <= quanto; i++)
            {
                guarda = guarda + Convert.ToString(i);
                i = Convert.ToInt16(i);
                richTextBox1.AppendText(guarda.ToString());
                richTextBox1.AppendText(Environment.NewLine);
            }
        }
    }
}
