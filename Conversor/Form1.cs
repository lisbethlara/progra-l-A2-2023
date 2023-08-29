using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor
{
    public partial class Form1 : Form
    {
        String[][] TiposConversores = new string[][]
       {
       new string[] {"Pie Cuadrado" },
       new string[] {"Vara Cuadrada" },
       new string [] {"Yarda Cuadrada"},
       new string [] {"Metro Cuadrado"},
       new string [] {"Tareas"}, 
       new string [] {"Manzana" }, 
       new string [] {"Hectarea"},
       };
        private object cboAconversor;
        private object txtCantidadConversor;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            int de = 0, a = 0;
            double cantidad = 0, respuesta = 0;
            de = cboDeConversor.SelectedIndex;
            a = cboAconversar.SelectedIndex;

            cantidad = double.Parse(textCantidadConversor.Text);

            double[][] monedas = {
            new double []{1, 0.92, 7.86, 24.66, 8.75, 36.58, 535.14, 145.47, 0.037, 16.99},//Monedas
            new double [] {1, 1000, 1000000, 1000000000.00, 00, 0.984207,  1.10231, 157.473, 2204.62, 35274},//Masa
            new double [] {1, 264.172, 1056.69, 4166.67, 33814, 1000, 1000000, 61023.7, 35.3147}, //Volumen
            new double [] {1, 1000, 100000, 1000000, 0, 0, 0.621371, 1093.61, 3280.84, 39370.1},//Longitud
            new double [] {1, 0.125, 0.000125, 0.000000125, 0.00000000009313226, 0.000000000000000000091, 0.000000000000000000000000000888, 0.000000000000000000000000000000000868, 0.0000000000000000000000000000000000000000000848, 0.0000000000000000000000000000000000000000000000000000000000083}, //Almacenamiento
            new double [] {1, 0.001, 0.000001, 0.000000001, 0.00000000001666667, 0.00000000000027778, 0.00000000000001157407, 0.00000000000000165344, 0.00000000000000038056, 0.0000000000000000317098 } //tiempo
            };
            respuesta = monedas[cboTipoConversor.SelectedIndex][a] / monedas[cboTipoConversor.SelectedIndex][de] * cantidad;

            lblRespuestaConversor.Text = " " + Math.Round(respuesta, 2);
        }

        private void cboTipoConversor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDeConversor.Items.Clear();
            cboDeConversor.Items.AddRange(TiposConversores[cboTipoConversor.SelectedIndex]);

            cboAconversar.Items.Clear();
            cboAconversar.Items.AddRange (TiposConversores[cboTipoConversor.SelectedIndex]);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboDeConversor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
