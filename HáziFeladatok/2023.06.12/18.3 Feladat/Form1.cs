namespace _18._3_Feladat
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

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            Eg�r.Text = $"Az eg�r koordin�t�i X:{e.X}, Y:{e.Y}";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Eg�r.Text = $"Az eg�r koordin�t�i X:{e.X}, Y:{e.Y}";
        }
    }
}