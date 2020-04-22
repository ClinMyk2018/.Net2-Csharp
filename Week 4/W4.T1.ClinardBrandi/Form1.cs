using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W4.T1.ClinardBrandi
{
    public partial class Form1 : Form
    {
        int second = 0;
        private System.Drawing.Graphics g;
        private System.Drawing.Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 5);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second += 1;

            g = PictureBox1.CreateGraphics();
            if (second == 1)
            {
                using (Font myFont = new Font("Arial", 30))
                {
                    g.DrawString("HAPPY EASTER", myFont, Brushes.Green, new Point(200, 10));
                }
            }
            if (second == 2)
            {
                using (Font myFont = new Font("Arial", 30))
                {
                    g.DrawString("DR. JEFF", myFont, Brushes.Green, new Point(270, 120));
                }
            }
            if (second == 3)
            {
                using (Font myFont = new Font("Arial", 30))
                {
                    g.DrawString("FROM THE CLINARD'S!", myFont, Brushes.Green, new Point(135, 220));
                }
            }

            if (second == 4)
            {
                g.DrawRectangle(blackPen, 10, 50, 100, 100);
            }

            if (second == 5)
            {
                g.DrawRectangle(blackPen, 600, 50, 100, 100);
            }

        }

    }
}
