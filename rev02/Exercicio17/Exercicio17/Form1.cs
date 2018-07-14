using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // cascata de numeros sem repeticao 1,23,456,78910
            int quanto, bandeira = 0;
            string guarda = "", espaco = "";
            quanto = (int)numericUpDown1.Value;
            for (int i = 1; i <= quanto; i++)
            {
                for (int z = quanto; z >= i; z--)
                {
                    espaco = espaco + " ";
                }
                for (int x = 1; x <= i; x++)
                {
                    bandeira = bandeira + 1;
                    guarda = guarda + " " + bandeira;
                }
                guarda = espaco + guarda;
                richTextBox1.AppendText(guarda.ToString());
                richTextBox1.AppendText(Environment.NewLine);
                guarda = "";
                espaco = "";
            }
        }
    }
}
