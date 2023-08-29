using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suma_y_multiplicacion
{
    public partial class Form1 : Form
    {
        static double num1;
        static double num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculadora_Click(object sender, EventArgs e)
        {
            
            num1 = double.Parse(textnum1.Text);
            num2 = double.Parse(textnum2.Text);

            double resp = (num1 + num2)     +3 ;
            MessageBox.Show("La suma es de: " + resp.ToString());
        }
    }
}
