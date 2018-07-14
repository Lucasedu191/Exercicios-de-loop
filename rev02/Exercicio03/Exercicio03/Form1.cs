using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //calcular base e expoente calcular potencia
            int Base = (int)numericUpDown1.Value;
            int Expoente = (int)numericUpDown2.Value;
            int resultado = 1;

            for (int i = 1; i <= Expoente; i++)
            {
                resultado = Base * resultado;
            }
            MessageBox.Show(" A potencia é: " + resultado.ToString());
        } 
    }
}
