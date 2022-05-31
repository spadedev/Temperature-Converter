using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Converter
{
    public partial class TemperatureConverter : Form
    {
        public TemperatureConverter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void convertFahren_btn_Click(object sender, EventArgs e)
        {
            double celsius = Convert.ToDouble(celcius_txtbox.Text);
            fahrenheit_txtbox.Text = Convert.ToString((celsius * 9 / 5) + 32);
        }

        private void convertCelcius_btn_Click(object sender, EventArgs e)
        {
            double fahrenheit = Convert.ToDouble(fahrenheit_txtbox.Text);
            celcius_txtbox.Text = Convert.ToString((fahrenheit - 32) * 5 / 9);
        }
    }
}
