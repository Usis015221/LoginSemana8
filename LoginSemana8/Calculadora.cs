using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginSemana8
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }
        double Num1, Num2;
        private void button1_Click(object sender, EventArgs e)
        {
            double Suma;

            Num1 = Convert.ToDouble(TxtNum1.Text);
            Num2 = Convert.ToDouble(TxtNum2.Text);

            Suma = Num1 + Num2;

            MessageBox.Show("El Resultado de la suma es :  " + Suma);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double Resta;
            Num1 = Convert.ToDouble(TxtNum1.Text);
            Num2 = Convert.ToDouble(TxtNum2.Text);
            Resta = Num1 - Num2;
            MessageBox.Show("  El Resultado de la Resta es: " + Resta);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double Multiplicacion;

            Num1 = Convert.ToDouble(TxtNum1.Text);
            Num2 = Convert.ToDouble(TxtNum2.Text);

            Multiplicacion = Num1 * Num2;

            MessageBox.Show("El Resultado de la Multiplicación es: " + Multiplicacion);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double Division;

            Num1 = Convert.ToDouble(TxtNum1.Text);
            Num2 = Convert.ToDouble(TxtNum2.Text);

            Division = Num1 / Num2;

            MessageBox.Show(" El Resultado de la División es : " + Division);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Inicio f1 = new Inicio();
            f1.Show();
            this.Hide();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
