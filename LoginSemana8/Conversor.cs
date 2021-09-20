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
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();
        }

        private void Conversor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //comboBox1.Text = "";


            if (comboBox1.Text == "Kilogramos")
            {
                double Lb, Kg;

                Lb = System.Double.Parse(txtLb.Text);

                Kg = Lb * 0.4535;

                txtkg.Text = Kg.ToString() + "  Kilogramos ";
            }
            else if (comboBox1.Text == "Toneladas")
            {
                double Lb, tn;

                Lb = System.Double.Parse(txtLb.Text);

                tn = Lb * 0.000453592;

                txtkg.Text = tn.ToString() + " Toneladas ";

            }

            else if (comboBox1.Text == "Gramos")
            {
                double Lb, gr;

                Lb = System.Double.Parse(txtLb.Text);

                gr = Lb * 453.592;

                txtkg.Text = gr.ToString() + " Gramos";

            }
            else if (comboBox1.Text == "Onza")
            {
                double Lb, on;

                Lb = System.Double.Parse(txtLb.Text);

                on = Lb * 16;

                txtkg.Text = on.ToString() + " Onzas";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inicio f1 = new Inicio();
            f1.Show();
            this.Hide();
        }
    }
}
