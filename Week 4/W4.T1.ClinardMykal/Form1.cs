using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W4.T1.ClinardMykal
{
    public partial class Form1 : Form
    {
        int second = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {

            timer1.Interval = 1000;
            timer1.Start();
        }

        //Instanitate the Graphics
        private System.Drawing.Graphics g;
        private System.Drawing.Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 5);
        private System.Drawing.Pen penGreen = new Pen(Color.Green, 2F);

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            second += 1;

            g = PictureBox1.CreateGraphics();
            if (second == 1)
            {

                Point[] points = {
                    new Point(40, 60),
                    new Point(50, 70),
                    new Point(30, 90)
                };

                GraphicsPath path = new GraphicsPath();

                path.StartFigure();
                path.AddArc(175, 50, 50, 50, 0, -180);
                path.AddLine(100, 0, 250, 20);
                path.CloseFigure();

                path.StartFigure(); 
                path.AddLine(50, 20, 5, 90);
                path.AddCurve(points, 3);
                path.AddLine(50, 150, 150, 180);
                path.CloseFigure();

                g.DrawPath(new Pen(Color.FromArgb(255, 255, 0, 0), 2), path);
            }
            if (second == 2)
            {
                g.DrawRectangle(blackPen, 450, 50, 180, 100);
            }
            if (second == 3)
            {

                GraphicsPath path = new GraphicsPath();

                path.StartFigure();
                path.AddArc(275, 150, 150, 150, 0, 180);
                path.AddLine(150, 100, 450, 120);
                path.CloseFigure();

                g.DrawPath(penGreen, path);
            }
            if (second == 4)
            {
                g.DrawRectangle(penGreen, 10, 250, 100, 100);
            }
            if (second == 5)
            {
                MessageBox.Show("Hope you enjoyed, HAPPY EASTER!!");
            }
        }
    }
}

