using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Procesar_Click();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Procesar_Click()
        {
            string Cadena = textBox1.Text;
            int Longitud = Cadena.Length;
            string UltimoC = Cadena.Substring(Longitud - 1);
            char PrimeroC = Cadena[0];
            int ContA = 0;

            textBox2.Text = Longitud.ToString();
            textBox3.Text = "" + UltimoC;
            textBox4.Text = "" + PrimeroC;
            textBox5.Text = Cadena.Substring(2, 6);

            for (int i = 0; i < Cadena.Length; i++)
            {
                if (Cadena.Contains("a"))
                {
                    ContA++;
                }

            }
            textBox6.Text = ContA.ToString();
            textBox7.Text = Cadena.ToUpper();
            textBox8.Text = Cadena.ToLower();
            textBox9.Text = Cadena.Replace(" ", "");
        }
    }
}
