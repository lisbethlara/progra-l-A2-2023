using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suma
{
    public partial class Form1 : Form
    {
        static double n1;
        static double n2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculadora_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(textnum1.Text);
            n2 = double.Parse(textnum2.Text);

            double resp = n1 + n2;
            MessageBox.Show("La suma es de: " + resp.ToString());

        }
    }
}
