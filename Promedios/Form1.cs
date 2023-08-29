using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promedios
{
    public partial class Form1 : Form

    {
        static double lab1;
        static double lab2;
        static double tareas;
        static double parcial;
        static double notafinal;
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)

        {
            lab1 = Convert.ToDouble(textlab1.Text) * 0.15;
            lab2 = Convert.ToDouble(textlab2.Text) * 0.15;
            tareas = Convert.ToDouble(texttareas.Text) * 0.3;
            parcial = Convert.ToDouble(textparcial.Text) * 0.4;

            double notafinal = lab1 + lab2 + tareas + parcial;
            lblnotafinal.Text = notafinal.ToString();

            if (notafinal >= 6)
            {
                lblresultado.Text = "Aprobado";
            }
            else
                lblresultado.Text = "Reprobado";

        }
       
        
    }
}
