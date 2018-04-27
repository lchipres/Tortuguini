using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tortuguini
{
    public partial class Form1 : Form
    {
        Mapa m = new Mapa();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inicializar(m);
        }

        private void inicializar(Mapa ms)
        {
            int[,] m = new int[20, 20];
            for(int i = 0; i < 20; i++)
            {
                for(int j = 0; j < 20; j++)
                {
                    m[i, j] = 0;
                }
            }
            ms.setMapa(m);
        }

        private string mostrar(Mapa ms)
        {
            int[,] m = new int[20, 20];
            m=ms.getMapa();
            string s = "";
            for (int i = 0; i < 20; i++)
            {
                s += Environment.NewLine;
                for (int j = 0; j < 20; j++)
                {
                    s += m[i, j];
                }
            }
            return s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = mostrar(m);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                m.avanzar(Convert.ToInt32(textBox2.Text));
            }
            catch (IndexOutOfRangeException est)
            {
                throw est;
            }
}

        private void button5_Click(object sender, EventArgs e)
        {
            m.girarDerecha();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            m.girarIzquierda();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            m.bajarPluma();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            m.subirPluma();
        }
    }
}
