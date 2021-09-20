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
    public partial class Ayuda_III : Form
    {
        public Ayuda_III()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio f1 = new Inicio();
            f1.Show();
            this.Hide();
        }
    }
}
