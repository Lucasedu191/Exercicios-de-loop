using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttoncalcular_Click(object sender, EventArgs e)
        {
            int potencia = 1; // elemento neutro da multiplicacao

                for (int i = 1; i <= numexpo.Value; i++) 
            {
                potencia *= (int)numbase.Value;
            }

            MessageBox.Show(potencia.ToString());

            int potencia2 = 1; // elemento neutro da multiplicacao
            int i = 1;
            while ( i <= numexpo.Value)
            {
                potencia *= (int)numbase.Value;
                i++;
            }

            MessageBox.Show(potencia2.ToString());

        }

    }


    }
}
