using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_8
{
    public partial class Form1 : Form
    {
        double valor1 = 0;
        string operacion = "";
        bool operacionEnCurso = false;
        private object textBox1;

        public Form1()
        {
            InitializeComponent();
            Pantalla.Text = "0";
        }

        private void Insertar(string caracter)
        {
            if (operacionEnCurso)
            {
                Pantalla.Text = "0";
                operacionEnCurso = false;
            }

            Pantalla.Text = Pantalla.Text == "0" ? caracter : Pantalla.Text + caracter;
        }
    
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            operacion += "1";
            textBox1.Text = operacion;
            Button b = (Button)sender;
            Insertar(b.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Insertar(b.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Insertar(b.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Insertar(b.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Insertar(b.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Insertar(b.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Insertar(b.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Insertar(b.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            Button b = (Button)sender;
            Insertar(b.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Insertar(b.Text);
        }



        private void button13_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(Pantalla.Text); 
            operacion = "+"; 
            Pantalla.Text += " +";
            operacionEnCurso = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(Pantalla.Text);
            operacion = "/";
            Pantalla.Text += " /"; 
            operacionEnCurso = true;
        }

        private void resta_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(Pantalla.Text);
            operacion = "-";
            Pantalla.Text += " -";
            operacionEnCurso = true;
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(Pantalla.Text);
            operacion = "*";
            Pantalla.Text += " *"; 
            operacionEnCurso = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text.Split(' ')[0];

            double valor2 = Convert.ToDouble(Pantalla.Text); 

            switch (operacion)
            {
                case "+":
                    Pantalla.Text = (valor1 + valor2).ToString();
                    break;
                case "-":
                    Pantalla.Text = (valor1 - valor2).ToString();
                    break;
                case "*":
                    Pantalla.Text = (valor1 * valor2).ToString();
                    break;
                case "/":
                    if (valor2 != 0)
                        Pantalla.Text = (valor1 / valor2).ToString();
                    else
                        Pantalla.Text = "Error";
                    break;
            }

            operacionEnCurso = false; 
        }
        private void button21_Click(object sender, EventArgs e)
        {
            Pantalla.Text = "0";
            valor1 = 0;
            operacion = "";
        }
    }
}
