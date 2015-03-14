using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIPaint
{
    
    public partial class Form1 : Form
    {
        MyPaint paint = null;
        Point firstPoint = Point.Empty;
        Point secondPoint = Point.Empty;



        public Form1()
        {
            InitializeComponent();
            paint = new MyPaint(pictureBox1.Size);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {


            switch (paint.shape)
            {
                case Shape.Line:
                    e.Graphics.DrawLine(paint.p, firstPoint, secondPoint);
                    break;
                case Shape.Rectangle:
                    e.Graphics.DrawRectangle(paint.p, firstPoint.X, firstPoint.Y, secondPoint.X - firstPoint.X, secondPoint.Y - firstPoint.Y);
                    break;
                case Shape.Circle:
                    break;
                default:
                    break;
            }

            e.Graphics.DrawImage(paint.bitmap, Point.Empty);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            secondPoint = e.Location;

            switch (paint.shape)
            {
                case Shape.Line:
                    paint.g.DrawLine(paint.p, firstPoint, secondPoint);
                    break;
                case Shape.Rectangle:
                    paint.g.DrawRectangle(paint.p, firstPoint.X, firstPoint.Y, secondPoint.X - firstPoint.X, secondPoint.Y - firstPoint.Y);
                    break;

                case Shape.Circle:
                    break;
                default:
                    break;
            }

            this.Refresh();

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                secondPoint = e.Location;
                this.Refresh();
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            paint.p.Color = b.BackColor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            paint.shape = Shape.Rectangle;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            paint.shape = Shape.Line;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paint.bitmap.Save("1.png");
        }
    }
}
