using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_Conversores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            int i, j;
            double conversor, resultado;

            i = cboA.SelectedIndex;
            j = cboD.SelectedIndex;

            conversor = double.Parse(textCantidad.Text);
            double[] Convertir = { 0.0929, 0.698896, 0.8361, 1, 438, 7000, 10000, };

            resultado = Convertir[j] / Convertir[i] * conversor;
            textResultado.Text = " " + Math.Round(resultado, 3);
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
