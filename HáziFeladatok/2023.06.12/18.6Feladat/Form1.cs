using System;

namespace _18._6Feladat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Image1_Click(object sender, EventArgs e)
        {
            Image s = Image1.Image;
            Image1.Image = Image2.Image;
            Image2.Image = Image3.Image;
            Image3.Image = Image4.Image;
            Image4.Image = Image5.Image;
            Image5.Image = Image6.Image;
            Image6.Image = s;
        }

        private void Image1_MouseClick(object sender, MouseEventArgs e)
        {
            //Image s = Image6.Image;
            //Image6.Image = Image5.Image;
            //Image5.Image = Image4.Image;
            //Image4.Image = Image3.Image;
            //Image3.Image = Image2.Image;
            //Image2.Image = Image1.Image;
            //Image1.Image = s;
        }

        private void Image1_MouseCaptureChanged(object sender, EventArgs e)
        {

        }
    }
}