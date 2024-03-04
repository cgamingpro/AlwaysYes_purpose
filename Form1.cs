using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace defintlyYes
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        private Point[] POINTS = new Point[6];
        public Form1()
        {
           
            InitializeComponent();
            BackColor = Color.LightPink;
            inPoint();
        }
        private void inPoint()
        {
            POINTS[0] = new Point(678,380);
            POINTS[1] = new Point(692,47);
            POINTS[2] = new Point(409,35);
            POINTS[3] = new Point(12,29);
            POINTS[4] = new Point(12,217);
            POINTS[5] = new Point(28,382);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Love you !!");
        }

        private void NOBB_MouseEnter(object sender, EventArgs e)
        {
            int i = rnd.Next(0,POINTS.Length);
            Point locNew = POINTS[i];
            NOBB.Location = locNew;
        }
    }
}
