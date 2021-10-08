using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace LoginSemana8
{
    public partial class Usuarios : Form
    {
        public OleDbConnection miconexion;
        public string usuario_modificar;
        
        public Usuarios()
        {
                OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\PC\\source\\repos\\LoginSemana8\\LoginSemana8\\BaseLogin.accdb");
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'baseLoginDataSet.tusuario' Puede moverla o quitarla según sea necesario.
            this.tusuarioTableAdapter.Fill(this.baseLoginDataSet.tusuario);
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            txtnivel.Enabled = false;
            this.tusuarioTableAdapter.Fill(this.baseLoginDataSet.tusuario);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tusuarioBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tusuarioBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tusuarioBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tusuarioBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            txtnivel.Enabled = true;
            txtusuario.Text = "" ;
            txtclave.Text = "" ;
            txtnivel.Text = "Seleccione nivel";
            button5.Visible = false;
            button9.Visible = true;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try{
                OleDbCommand guardar = new OleDbCommand();
                miconexion.Open();
                guardar.Connection = miconexion;
                guardar.CommandType = CommandType.Text;
                guardar.CommandText = "INSERT INTO tusuario ([usuario], [password], [nivel]) Values ('" + txtusuario.Text.ToString() + "','" + txtclave.Text.ToString() + "','" + txtnivel.Text.ToString() + "') ";
                guardar.ExecuteNonQuery();
                miconexion.Close();

                button5.Visible = true;
                button9.Visible = false;

                txtusuario.Enabled = false;
                txtclave.Enabled = false;
                txtnivel.Enabled = false;
                button5.Focus();
                MessageBox.Show("Usuario agregado con éxito", "Ok",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tusuarioTableAdapter.Fill(this.baseLoginDataSet.tusuario);
                this.tusuarioBindingSource.MoveLast();


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            txtnivel.Enabled = true;
            txtusuario.Focus();
            button7.Visible = false;
            button10.Visible = true;

            usuario_modificar = txtusuario.Text.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand actualizar = new OleDbCommand();
                miconexion.Open();
                actualizar.Connection = miconexion;
                actualizar.CommandType = CommandType.Text;
                string nom = txtusuario.Text.ToString();
                string cla = txtclave.Text.ToString();
                string niv = txtnivel.Text;
                actualizar.CommandText = "UPDATE tusuario SET usuario = '" + nom + "', password = '" + cla + "' WHERE nombre '" + usuario_modificar + "'";
                actualizar.ExecuteNonQuery();
                miconexion.Close();
                button7.Visible = true;
                button10.Visible = false;
                txtusuario.Enabled = false;
                txtclave.Enabled = false;
                txtnivel.Enabled = false;
                MessageBox.Show("Usuario actualizado con éxito", "Ok",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand eliminar = new OleDbCommand();
                miconexion.Open();
                eliminar.Connection = miconexion;
                eliminar.CommandType = CommandType.Text;
                eliminar.CommandText = "DELETE FROM tusuario WHERE nombre = '" +
                txtusuario.Text.ToString() + "'";

                eliminar.ExecuteNonQuery();
                this.tusuarioBindingSource.MoveNext();
                miconexion.Close();
                MessageBox.Show("Usuario eliminado con éxito", "Ok",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tusuarioBindingSource.MovePrevious();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Inicio f1 = new Inicio();
            f1.Show();
            this.Hide();
        }
    }
}
