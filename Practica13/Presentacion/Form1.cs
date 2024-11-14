using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Practica13.Presentacion

{
    public partial class Form1 : Form
    {
        private TextBox txt_Contraseña;
        public Form1()
        {
            InitializeComponent();
            txt_Contraseña = new TextBox();
            txt_Contraseña.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string validUsername = "Yuliriam";
            string validPassword = "uabc1998";

            if (textBox1.Text == validUsername && textBox2.Text == validPassword)
            {
                Form2 contenido = new Form2();

                contenido.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos, por favor inténtalo de nuevo.");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
