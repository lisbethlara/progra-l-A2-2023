using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_Etapa_de_Vida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(textedad.Text);
            if (edad <= 2)
            {
                lblquesoy.Text = "Eres un bebe";
            }
            else if (edad <= 12)
            {
                lblquesoy.Text = "Eres un niño";

            }
            else if (edad <= 18)
            {
                lblquesoy.Text = "Eres un adolesente";

            }
            else if (edad <=25)

            {
                lblquesoy.Text = "Eres un Joven";

            } 
            else if (edad<=32)

            {
                lblquesoy.Text = "Eres un Adulto";

            } 
            else if (edad<=50)

            {
                lblquesoy.Text = "Eresn mayor de edad";

            } 
            else if (edad<=99)

            {
                lblquesoy.Text = "Eres de la tercera edad";

            } else if (edad<=100)

            {
                lblquesoy.Text = "Eres de larga Vida";
            }
        }
    }
}