using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promedio
{
    public partial class Form1 : Form
    {
        static double n1;
        static double n2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            n1 = Double.Parse(textNum1Calculadora.Text);
            n2= Double.Parse(textNum2Calculadora.Text);

            double resp = n1 * n2;
            MessageBox.Show("La suma es:" + resp.ToString());

        }

        private void textNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
