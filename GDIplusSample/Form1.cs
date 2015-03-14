using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIplusSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Pen p = new Pen(Color.Red, 5);
        Graphics g = null;


        private void button1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            this.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (g != null)
            {
                g.DrawRectangle(p, 10, 10, 100, 200);
            }
        }
    }
}
