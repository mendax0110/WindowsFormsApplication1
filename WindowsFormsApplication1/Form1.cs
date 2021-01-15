using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int x1,y1,zufall;
        public Form1()
        {
            InitializeComponent();
            x1 = 0;
            y1 = 0;
            zufall = 0;
            timer1.Interval = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(zufall == 1)
                timer1.Stop();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics dev = e.Graphics;
            if (zufall == 1) 
            dev.FillRectangle(Brushes.Green, 100, 100, 100, 100);
            if (zufall == 2)
                dev.FillRectangle(Brushes.Red, 100, 100, 100, 100);
            if (zufall == 3)
                dev.FillRectangle(Brushes.Blue, 100, 100, 100, 100);
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (zufall<3)
                zufall++;
            else
                zufall = 1;

            //Random Rnd = new Random(); // initialisiert die Zufallsklasse
            //zufall = Rnd.Next(0, 4);
            pictureBox1.Invalidate();
        }
    }
}
