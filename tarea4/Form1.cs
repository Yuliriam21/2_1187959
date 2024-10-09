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

namespace tarea4
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> sonidos;
        public Form1()
        {
            InitializeComponent();
            sonidos = new Dictionary<string, string>
            {
                {"boo",@"resources\boo.wav" },
                {"cat",@"resources\cat.wav" },
                {"drums",@"resources\drums.wav" },
                {"laugh",@"resources\laugh.wav" },
            };
        }

        //para invocar los sonidos
        public void ReproducirSonidos(string sonido)
        {
            if (sonidos.ContainsKey(sonido)) {
                SoundPlayer player = new SoundPlayer(sonidos[sonido]);   
                player.Play();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("boo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("cat");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("drums");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("laugh");
        }
    }
}
