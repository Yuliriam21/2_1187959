using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
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

        private void button1_Click(object sender, EventArgs e)
        {
            string validUsername = "Yuliriam"; 
            string validPassword = "uabc1998";

            if (textBox1.Text == validUsername && textBox2.Text == validPassword)
            {
                
                Form2 contenido = new Form2();
                contenido.Show();
                contenido.LoadWelcomeMessage("¡Bienvenido, " + validUsername + "!");

                this.Hide();
            }
            else
            {
                
                MessageBox.Show("Usuario o contraseña incorrectos, por favor inténtalo de nuevo.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
