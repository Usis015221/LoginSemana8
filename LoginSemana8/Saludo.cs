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
    public partial class Saludo : Form
    {
        public Saludo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtsaludar.SelectAll();
            if (txtsaludar.SelectionLength > 0)
            {
                MessageBox.Show(("Hola " + txtsaludar.Text), "Saludo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Digite un texto!", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void txtsaludar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inicio f1 = new Inicio();
            f1.Show();
            this.Hide();
        }
    }
}
