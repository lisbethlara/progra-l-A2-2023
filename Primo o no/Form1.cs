using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primo_o_no
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numero;
            numero = Convert.ToInt32(textnumero.Text);

            int i;
            int c = 0;
            for (i = 1; i<numero; i++)
            {
                if (numero % i== 0)
                {
                    c++;
                    i = numero;
                    i++;
                }

            }
            if (c == 0)
            {
                lblresultado.Text = ("Es Primo " + numero);
            }
            else
            {
                lblresultado.Text = ("No es primo" + numero);
            } 

        }

        private void btn_Click(object sender, EventArgs e)
        {
            textnumero.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
