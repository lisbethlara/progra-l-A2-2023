using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabla_de_Multiplicar
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesador_Click(object sender, EventArgs e)
        {
            int ntabla = int.Parse(textNtabla.Text);
            string msg = " Tabla de multiplicar " + ntabla + "\n";
            for (int i = 0; i <= 10; i++)
            {
                msg += ntabla + "*" + i + "=" + (ntabla * i) + "\n";

            }
            lblcalcular.Text=(msg);

        }
    }
}