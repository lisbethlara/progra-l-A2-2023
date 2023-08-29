using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1
{
    public partial class Form1 : Form    
    {
        

        public Form1()
        {
            InitializeComponent();
        }
        //Pie Cuadrado 
        //Vara Cuadrada
//Yarda Cuadrada
//Metro Cuadrado
//Tareas
//Manzana
//Hectarea
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (cboDeConversor.SelectedIndex.ToString() == "Pie Cuaderado " & cboAConversor.SelectedIndex.ToString() == "Pie Cuadrado")
            {
                double conversion;
                conversion = int.Parse(textCantidadConversor.Text) * 0.092903;
                
                textResultado.Text = " " + Math.Round(conversion, 2);
            }
          
        }

        private void textCantidadConversor_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
