using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgra_CCaneces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxConversion.Items.Add("Kilómetros a Millas");
            comboBoxConversion.Items.Add("Millas a Kilómetros");
            comboBoxConversion.Items.Add("Metros a Pies");
            comboBoxConversion.Items.Add("Pies a Metros");
            comboBoxConversion.Items.Add("Centímetros a Pulgadas");
            comboBoxConversion.Items.Add("Pulgadas a Centímetros");
            comboBoxConversion.SelectedIndex = 0;
        }

        private void buttonConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                double cantidad = double.Parse(textBoxCantidad.Text);
                double resultado = 0;
                string unidadFinal = "";

                switch (comboBoxConversion.SelectedIndex)
                {
                    case 0:
                        resultado = cantidad * 0.621371;
                        unidadFinal = "mi";
                        break;
                    case 1:
                        resultado = cantidad * 1.60934;
                        unidadFinal = "km";
                        break;
                    case 2:
                        resultado = cantidad * 3.28084;
                        unidadFinal = "ft";
                        break;
                    case 3:
                        resultado = cantidad / 3.28084;
                        unidadFinal = "m";
                        break;
                    case 4:
                        resultado = cantidad / 2.54;
                        unidadFinal = "in";
                        break;
                    case 5:
                        resultado = cantidad * 2.54;
                        unidadFinal = "cm";
                        break;
                }

                labelResultado.Text = $"Resultado: {resultado:F2} {unidadFinal}";
            }
            catch
            {
                MessageBox.Show("Por favor ingrese una cantidad válida.");
            }
        }

    }
}

