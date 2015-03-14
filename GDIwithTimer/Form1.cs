using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIwithTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            MySuperMathLib.SuperCalculation s = new MySuperMathLib.SuperCalculation();
            MessageBox.Show(s.apb(new Random().Next(),new Random().Next()).ToString());
        }

        float d = 0;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Red, 5);
            //e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.DrawEllipse(p, 120 - d/2, 120 - d/2, 10 + d, 10 + d);
            d++;
        }


    }
}
