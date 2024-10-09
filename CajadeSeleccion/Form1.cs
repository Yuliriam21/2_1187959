using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajadeSeleccion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            -Negrita_CheckedChanged();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Italic_CheckedChanged();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Strikeout_CheckedChanged();
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Underline_CheckedChanged();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Consolas_CheckedChanged();
        }



        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            Verdana_CheckedChanged();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            Broadway_CheckedChanged();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            Ocho_CheckedChanged();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            Doce_CheckedChanged();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            diecisedoceis_CheckedChanged();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            veinte_CheckedChanged();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            salir_Click();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar_Click();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            ColonnaMT_CheckedChanged();
        }

        private void Negrita_CheckedChanged()
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily,
            this.label1.Font.Size, this.label1.Font.Style ^ FontStyle.Bold);
        }

        private void Italic_CheckedChanged()
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily,
            this.label1.Font.Size, this.label1.Font.Style ^ FontStyle.Italic);
        }

        private void Strikeout_CheckedChanged()
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily,
            this.label1.Font.Size, this.label1.Font.Style ^ FontStyle.Strikeout);
        }
        private void Underline_CheckedChanged()
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily,
            this.label1.Font.Size, this.label1.Font.Style ^ FontStyle.Underline);
        }


        private void Consolas_CheckedChanged()
        {
            FontFamily csl = new FontFamily("Consolas");
            this.label1.Font = new Font(csl, this.label1.Font.Size,
            this.label1.Font.Style);
        }

        private void ColonnaMT_CheckedChanged()
        {
            FontFamily csl = new FontFamily("Colonna MT");
            this.label1.Font = new Font(csl, this.label1.Font.Size,
            this.label1.Font.Style);
        }

        private void Verdana_CheckedChanged()
        {
            FontFamily csl = new FontFamily("Verdana");
            this.label1.Font = new Font(csl, this.label1.Font.Size,
            this.label1.Font.Style);
        }

        private void Broadway_CheckedChanged()
        {
            FontFamily csl = new FontFamily("Broadway");
            this.label1.Font = new Font(csl, this.label1.Font.Size,
            this.label1.Font.Style);
        }

        private void Ocho_CheckedChanged()
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily, 8,
            this.label1.Font.Style);
        }

        private void Doce_CheckedChanged()
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily, 12,
            this.label1.Font.Style);
        }

        private void diecisedoceis_CheckedChanged()
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily, 16,
            this.label1.Font.Style);
        }

        private void veinte_CheckedChanged()
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily, 20,
            this.label1.Font.Style);
        }

        private void salir_Click()
        {
            Application.Exit(); // Cierra la aplicación
        }

        private void limpiar_Click()
        {
            // Desmarcar todos los CheckBox
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;

            // Restablecer el font del label1 al valor predeterminado
            this.label1.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        }
    }
}

