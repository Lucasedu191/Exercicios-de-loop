using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mostrar os dez primeiros numeros naturais
            int numero = 0;
            MessageBox.Show("ok");
            for (int numero1= 0; numero <= 10; numero1++)
            {
                numero = numero1;
                richTextBox1.AppendText( numero.ToString());
                richTextBox1.AppendText(Environment.NewLine);
            }
        }
    }
}
