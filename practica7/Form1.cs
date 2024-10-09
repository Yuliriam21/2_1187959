using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace practica7
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> sonidos;
        private Dictionary<Keys, string> MapeoTeclas;
        public Form1()
        {
            InitializeComponent();
            sonidos = new Dictionary<string, string>
            {
                {"DO",@"resources\DO.wav"},
                {"RE",@"resources\RE.wav"},
                {"MI",@"resources\MI.wav"},
                {"FA",@"resources\FA.wav"},
                {"SOL",@"resources\SOL.wav"},
                {"LA",@"resources\LA.wav"},
                {"SI",@"resources\SI.wav"},
                {"DoUltimo",@"resources\DoUltimo.wav"},
                {"DO#",@"resources\Do#.wav"},
                {"RE#",@"resources\RE#.wav"},
                {"FA#",@"resources\FA#.wav"},
                {"SOL#",@"resources\SOL#.wav"},
                {"LA#",@"resources\LA#.wav"}
            };

            InitializeComponent();
            MapeoTeclas = new Dictionary<Keys, string>
            {
                { Keys.Q, "DO" },
                { Keys.O, "DO#" },
                { Keys.I, "DoUltimo" },
                { Keys.S, "FA##" },
                { Keys.R, "FA" },
                { Keys.H, "LA#" },
                { Keys.Y, "LA" },
                { Keys.E, "MI" },
                { Keys.P, "RE#" },
                { Keys.W, "RE" },
                { Keys.U, "SI" },
                { Keys.D, "SOL#" },
                { Keys.T, "SOL" }
            };

            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyPreview = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (MapeoTeclas.ContainsKey(e.KeyCode))
            {
                string nota = MapeoTeclas[e.KeyCode];
                ReproducirSonidos(nota);
            }
        }

        public void ReproducirSonidos(string sonido)
        {
            if (sonidos.ContainsKey(sonido))
            {
                SoundPlayer player = new SoundPlayer(sonidos[sonido]);
                player.Play();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("DO");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("RE");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("MI");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("FA");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("SOL");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("LA");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("SI");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("DoUltimo");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("DO#");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("RE#");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("FA#");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("SOL#");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("LA#");
        }
    }
}
