using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;


namespace LoginSemana8
{
    public partial class Login : Form
    {
        OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\sistema\\BaseLogin.accdb");
        public Login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                MessageBox.Show("conectado");
            }
            catch (Exception a)
            {
                MessageBox.Show("error por" + a.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string consulta = "select password,usuario from tusuario where password ='" + txtpass.Text + "' and usuario = '" + txtusuario.Text + "';";
            OleDbCommand comando = new OleDbCommand(consulta, conexion);
            OleDbDataReader leedb;
            leedb = comando.ExecuteReader();
            Boolean existereg = leedb.HasRows;
            if (existereg)
            {
                MessageBox.Show("bienvenido al sistema " + txtusuario.Text);
                Inicio f1 = new Inicio();
                f1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrecto trate de nuevo");
                return;
            }
            conexion.Close();
        }
    }
}
