using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonsoma_Click(object sender, EventArgs e)
        {
            int soma=0;
            MessageBox.Show("ok");
            for (int numero = 0; numero <= 10; numero++)
            {
               
                soma = soma + numero;
                richTextBoxmostra.AppendText("o resultado é :" +soma.ToString());
                richTextBoxmostra.AppendText(Environment.NewLine);
                

            }
        }
    }
}
