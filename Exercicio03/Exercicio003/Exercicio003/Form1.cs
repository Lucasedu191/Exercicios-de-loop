using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonpares_Click(object sender, EventArgs e)
        {
            for (int i = -2;i <= numpares.Value *2;  i += 2 ) 
            {
                richTextBoxpares.AppendText(i.ToString() + Environment.NewLine);
            }


            int quantidade = 0;
            int i = 1;
            while (quantidade < numpares.Value )
            {
                if ( 1 % 2 == 0 )
                {
                   quantidade++;
                    richTextBoxpares.AppendText(i.ToString() + Environment.NewLine);

                }
                i++;
            }
        }
    }
}
